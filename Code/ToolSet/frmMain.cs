using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Management;
using Microsoft.Win32;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToolSet
{
    public partial class frmMain : Form
    {
        public Dictionary<string, string> portDict = new Dictionary<string, string>();

        [StructLayout(LayoutKind.Explicit, Size=8)]
        struct mSysCfg{
            [FieldOffset(0)]
            ushort U16Val;
        }

        //
        //遥测消息帧格式定义;
        //
        [StructLayout(LayoutKind.Sequential,Pack=1)]
        public struct tDataMsg{
            Byte  m_Header;//0x55AA
            Byte  m_Frame;
            Byte  m_Tag;   //消息计数,0~255循环,可用于统计消息丢包或误码率;
        }

        //
        //广播消息帧格式定义;
        //
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct tAdvData{
            Byte m_Length;
            Byte m_Flags;
            Byte m_LLDFS;
            Byte m_DatLen;
            Byte[] m_UserDat;
        }

        /* ================================================================ */
        /*                BEGIN MAIN EVENT-DRIVEN APP LOGIC                 */
        /* ================================================================ */
        public const UInt16 STATE_STANDBY = 0;
        public const UInt16 STATE_SCANNING = 1;
        public const UInt16 STATE_CONNECTING = 2;
        public const UInt16 STATE_FINDING_SERVICES = 3;
        public const UInt16 STATE_FINDING_ATTRIBUTES = 4;
        public const UInt16 STATE_LISTENING_MEASUREMENTS = 5;

        public UInt16 gApp_state = STATE_STANDBY;       // current application state
        public Byte   gConnection_handle = 0;           // connection handle (will always be 0 if only one connection happens at a time)
        public UInt16 att_handlesearch_start = 0;       // "start" handle holder during search
        public UInt16 att_handlesearch_end = 0;         // "end" handle holder during search
        public UInt16 att_handle_measurement = 0;       // heart rate measurement attribute handle
        public UInt16 att_handle_measurement_ccc = 0;   // heart rate measurement client characteristic configuration handle (to enable notifications)

        public byte[] gMacAddr;
        public byte   gAddrType;

        public Bluegiga.BGLib bglib = new Bluegiga.BGLib();

        public void SystemBootEvent(object sender, Bluegiga.BLE.Events.System.BootEventArgs e)
        {
            String log = String.Format("ble_evt_system_boot:" + Environment.NewLine + "\tmajor={0}, minor={1}, patch={2}, build={3}, ll_version={4}, protocol_version={5}, hw={6}" + Environment.NewLine,
                e.major,
                e.minor,
                e.patch,
                e.build,
                e.ll_version,
                e.protocol_version,
                e.hw
                );
            Console.Write(log);
        }

        //Adevertising search event.
        // for master/scanner devices, the "gap_scan_response" event is a common entry-like point
        // this filters ad packets and display it into listview.
        public void GAPScanResponseEvent(object sender, Bluegiga.BLE.Events.GAP.ScanResponseEventArgs e)
        {
            string mName = "(No Name)";

            // pull all advertised service info from ad packet
            List<Byte[]> ad_services = new List<Byte[]>();

            Byte[] this_field = { };
            int bytes_left = 0;
            int field_offset = 0;
            for (int i = 0; i < e.data.Length; i++)
            {
                if (bytes_left == 0)
                {
                    bytes_left = e.data[i];
                    this_field = new Byte[e.data[i]];
                    field_offset = i + 1;
                }
                else
                {
                    this_field[i - field_offset] = e.data[i];
                    bytes_left--;
                    if (bytes_left == 0)
                    {
                        if (this_field[0] == 0x02 || this_field[0] == 0x03)
                        {// partial or complete list of 16-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(2).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x04 || this_field[0] == 0x05)
                        {// partial or complete list of 32-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(4).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x06 || this_field[0] == 0x07)
                        {// partial or complete list of 128-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(16).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x09)
                        {//Full name
                            mName = System.Text.Encoding.ASCII.GetString(this_field.Skip(1).ToArray());
                        }
                    }
                }

                //ASCii码转换
                //String log = String.Format("ble_evt_gap_scan_response:" + Environment.NewLine + "\trssi={0}, packet_type={1}, bd_addr=[ {2}], address_type={3}, bond={4}, data=[ {5}], convert={6}" + Environment.NewLine,
                //    (SByte)e.rssi,
                //    (SByte)e.packet_type,
                //    ByteArrayToHexString(e.sender),
                //    (SByte)e.address_type,
                //    (SByte)e.bond,
                //    ByteArrayToHexString(e.data),
                //    mName
                //    );
                //Console.Write(log); //to slow ,waste lots of time.

                int a = Math.Abs(e.rssi);
                string macaddr = ByteArrayToHexString(e.sender);

                ThreadSafeDelegate(delegate
                {
                    //
                    //check whether this dev is already displayed in the list.
                    //if it is not, we add it to the listbox,otherwise, just update.
                    //
                    ListViewItem lvS = lvScanDev.FindItemWithText(macaddr);
                    if (lvS != null)
                    {
                        lvS.SubItems[0].Text = mName;
                        lvS.SubItems[1].Text = a.ToString();
                        lvS.SubItems[2].Text = e.packet_type.ToString();
                        lvS.SubItems[3].Text = ByteArrayToHexString(e.sender);
                        lvS.SubItems[4].Text = e.address_type.ToString();
                    }
                    else
                    { 
                        ListViewItem lv = new ListViewItem(mName);//[0];
                        lv.SubItems.Add(a.ToString());//[1]
                        lv.SubItems.Add(e.packet_type.ToString());//[2]
                        lv.SubItems.Add(ByteArrayToHexString(e.sender));//[3]
                        lv.SubItems.Add(e.address_type.ToString());//[4]
                        lvScanDev.Items.Add(lv);
                    }
                });
            }
        }

        // the "connection_status" event occurs when a new connection is established
        public void ConnectionStatusEvent(object sender, Bluegiga.BLE.Events.Connection.StatusEventArgs e)
        {
            if (comDev.IsOpen == false) return;

            String log = String.Format("ble_evt_connection_status: connection={0}, flags={1}, address=[ {2}], address_type={3}, conn_interval={4}, timeout={5}, latency={6}, bonding={7}" + Environment.NewLine,
                e.connection,
                e.flags,
                ByteArrayToHexString(e.address),
                e.address_type,
                e.conn_interval,
                e.timeout,
                e.latency,
                e.bonding
                );
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            if ((e.flags & 0x05) == 0x05)
            {
                // connected, now perform service discovery
                gConnection_handle = e.connection;
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Connected to {0}", ByteArrayToHexString(e.address)) + Environment.NewLine); });
                Byte[] cmd = bglib.BLECommandATTClientReadByGroupType(e.connection, 0x0001, 0xFFFF, new Byte[] { 0x00, 0x28 }); // "service" UUID is 0x2800 (little-endian for UUID uint8array)
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                bglib.SendCommand(comDev, cmd);
                //while (bglib.IsBusy()) ;

                // update state
                gApp_state = STATE_FINDING_SERVICES;
            }
        }

        public void ATTClientGroupFoundEvent(object sender, Bluegiga.BLE.Events.ATTClient.GroupFoundEventArgs e)
        {
            String log = String.Format("ble_evt_attclient_group_found: connection={0}, start={1}, end={2}, uuid=[ {3}]" + Environment.NewLine,
                e.connection,
                e.start,
                e.end,
                ByteArrayToHexString(e.uuid)
                );
            //Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            // found "service" attribute groups (UUID=0x2800), check for heart rate measurement service
            if (e.uuid.SequenceEqual(new Byte[] { 0xF3, 0x64, 0x14, 0x00 }))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute group for service w/UUID=0x140D: start={0}, end=%d", e.start, e.end) + Environment.NewLine); });
                att_handlesearch_start = e.start;
                att_handlesearch_end = e.end;
            }
        }

        public void ATTClientFindInformationFoundEvent(object sender, Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventArgs e)
        {
            String log = String.Format("ble_evt_attclient_find_information_found: connection={0}, chrhandle={1}, uuid=[ {2}]" + Environment.NewLine,
                e.connection,
                e.chrhandle,
                ByteArrayToHexString(e.uuid)
                );
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            // check for heart rate measurement characteristic (UUID=0x2A37)
            if (e.uuid.SequenceEqual(new Byte[] { 0x01, 0x14 }))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x1401: handle={0}", e.chrhandle) + Environment.NewLine); });
                att_handle_measurement = e.chrhandle;
            }
            // check for subsequent client characteristic configuration (UUID=0x2902)
            else if (e.uuid.SequenceEqual(new Byte[] { 0x02, 0x14 }) && att_handle_measurement > 0)
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x1402: handle={0}", e.chrhandle) + Environment.NewLine); });
                att_handle_measurement_ccc = e.chrhandle;
            }
        }

        public void ATTClientProcedureCompletedEvent(object sender, Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventArgs e)
        {
            if (comDev.IsOpen == false) return;

            String log = String.Format("ble_evt_attclient_procedure_completed: connection={0}, result={1}, chrhandle={2}" + Environment.NewLine,
                e.connection,
                e.result,
                e.chrhandle
                );
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            // check if we just finished searching for services
            if (gApp_state == STATE_FINDING_SERVICES)
            {
#if false
                if (att_handlesearch_end > 0)
                {
                    //print "Found 'Heart Rate' service with UUID 0x180D"

                    // found the Heart Rate service, so now search for the attributes inside
                    Byte[] cmd = bglib.BLECommandATTClientFindInformation(e.connection, att_handlesearch_start, att_handlesearch_end);
                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(comDev, cmd);
                    //while (bglib.IsBusy()) ;

                    // update state
                    gApp_state = STATE_FINDING_ATTRIBUTES;
                }
                else
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText("Could not find 'Heart Rate' service with UUID 0x180D" + Environment.NewLine); });
                }
#else
                ThreadSafeDelegate(delegate { txtLog.AppendText("<<<-ATTClientProcedureCompletedEvent-service" + Environment.NewLine); });
#endif
            }
            // check if we just finished searching for attributes within the heart rate service
            else if (gApp_state == STATE_FINDING_ATTRIBUTES)
            {
#if false
                if (att_handle_measurement_ccc > 0)
                {
                    //print "Found 'Heart Rate' measurement attribute with UUID 0x2A37"

                    // found the measurement + client characteristic configuration, so enable notifications
                    // (this is done by writing 0x0001 to the client characteristic configuration attribute)
                    Byte[] cmd = bglib.BLECommandATTClientAttributeWrite(e.connection, att_handle_measurement_ccc, new Byte[] { 0x01, 0x00 });
                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(comDev, cmd);
                    //while (bglib.IsBusy()) ;

                    // update state
                    gApp_state = STATE_LISTENING_MEASUREMENTS;
                }
                else
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText("Could not find 'Heart Rate' measurement attribute with UUID 0x2A37" + Environment.NewLine); });
                }
#else
                ThreadSafeDelegate(delegate { txtLog.AppendText("<<<-ATTClientProcedureCompletedEvent-attribute" + Environment.NewLine); });
#endif
            }
        }

        public void ATTClientAttributeValueEvent(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
        {
            String log = String.Format("ble_evt_attclient_attribute_value: connection={0}, atthandle={1}, type={2}, value=[ {3}]" + Environment.NewLine,
                e.connection,
                e.atthandle,
                e.type,
                ByteArrayToHexString(e.value)
                );
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            // check for a new value from the connected peripheral's heart rate measurement attribute
            if (e.connection == gConnection_handle && e.atthandle == att_handle_measurement)
            {
                Byte hr_flags = e.value[0];
                int hr_measurement = e.value[1];

                // display actual measurement
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Heart rate: {0} bpm", hr_measurement) + Environment.NewLine); });
            }
        }

        public void ATTClientReadByTypeEvent(object sender, Bluegiga.BLE.Responses.ATTClient.ReadByTypeEventArgs e)
        {
            byte a = e.connection;
            ushort b = e.result;
            bglib.BLEEventATTClientAttributeValue += new Bluegiga.BLE.Events.ATTClient.AttributeValueEventHandler(AttributeValue);
        }

        public void WriteCommandEvent(object sender, Bluegiga.BLE.Responses.ATTClient.WriteCommandEventArgs e)
        {
            ushort a = e.result;
        }
        public void ProcedureCompleted(object sender, Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventArgs e)
        {
            ushort a = e.result;
        }

        public void AttributeWriteEvent(object sender, Bluegiga.BLE.Responses.ATTClient.AttributeWriteEventArgs e)
        {
            bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(ProcedureCompleted);
        }

        public void ConnectionEvent(object sender, Bluegiga.BLE.Events.Connection.StatusEventArgs e)
        {
            //gConnectID = e.connection;
            //gConnectFlag = e.flags;
        }

        public void ConnectDirect(object sender, Bluegiga.BLE.Responses.GAP.ConnectDirectEventArgs e)
        {
            ushort a = e.result;
            bglib.BLEEventConnectionStatus += new Bluegiga.BLE.Events.Connection.StatusEventHandler(ConnectionEvent);
        }

        ushort handel = 0;
        byte Serverconnection2;
        public void AttributeValue(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
        {
            StringBuilder n = new StringBuilder();
            Serverconnection2 = e.connection;
            byte[] f = e.value;
            if (f.Length > 3)
            {
                if (f[f.Length - 1] == 0x60 & f[f.Length - 2] == 0x74 & f[f.Length - 3] == 0xef)
                {
                    for (int i = 0; i < f.Length; i++)
                    {
                        int aa = Convert.ToInt32(f[i]);
                        string hexOutput = String.Format("{0:X}", aa);
                        n.Append(hexOutput + "|");
                    }
                    MessageBox.Show(n.ToString());
                    handel = e.atthandle;
                    bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(ProcedureCompleted);
                }
            }
        }

        public void AttributeValueFirmWare(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
        {

            if (e.value.Length == 4)
            {
                byte[] rtc = e.value;
                //string a = Ten2Hex(rtc[0].ToString());
                //string b = Ten2Hex(rtc[1].ToString());
                //string c = Ten2Hex(rtc[2].ToString());
                //string d = Ten2Hex(rtc[3].ToString());
               // string time = a + b + c + d;
                //string tentime = Hex2Ten(time);
            }
            else
            {
                //ASCii码转换
                string s = System.Text.Encoding.ASCII.GetString(e.value);
                MessageBox.Show(s);
            }
        }
        /* ================================================================ */
        /*                 END MAIN EVENT-DRIVEN APP LOGIC                  */
        /* ================================================================ */

        // Thread-safe operations from event handlers
        // I love StackOverflow: http://stackoverflow.com/q/782274
        public void ThreadSafeDelegate(MethodInvoker method)
        {
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbComPort_DropDown(sender, e);
            // initialize COM port combobox with list of ports
            cmbComPort.DataSource = new BindingSource(portDict, null);
            cmbComPort.DisplayMember = "Value";
            cmbComPort.ValueMember = "Key";

            // initialize serial port with all of the normal values (should work with BLED112 on USB)
            comDev.Handshake = System.IO.Ports.Handshake.RequestToSend;

            cmbComBaud.SelectedIndex = 5;
            cmbComParity.SelectedIndex = 0;
            cmbComDatabit.SelectedIndex = 0;
            cmbComStopbit.SelectedIndex = 0;

            //向ComDevice.DataReceived（是一个事件）注册一个方法Com_DataReceived，
            //当端口类接收到信息时时会自动调用Com_DataReceived方法
            comDev.DataReceived += new SerialDataReceivedEventHandler(OnComReceived);

            //
            //BLE 事件回调;
            //
            bglib.BLEEventSystemBoot += new Bluegiga.BLE.Events.System.BootEventHandler(this.SystemBootEvent);

            //Search Event
            // for master/scanner devices, the "gap_scan_response" event is a common entry-like point
            // this filters ad packets to find devices which advertise the Health Thermometer service
            bglib.BLEEventGAPScanResponse += new Bluegiga.BLE.Events.GAP.ScanResponseEventHandler(this.GAPScanResponseEvent);

            //连接动作
            bglib.BLEResponseGAPConnectDirect += new Bluegiga.BLE.Responses.GAP.ConnectDirectEventHandler(ConnectDirect);
            //连接事件
            bglib.BLEEventConnectionStatus += new Bluegiga.BLE.Events.Connection.StatusEventHandler(this.ConnectionStatusEvent);
            //查找一级服务
            bglib.BLEEventATTClientGroupFound += new Bluegiga.BLE.Events.ATTClient.GroupFoundEventHandler(this.ATTClientGroupFoundEvent);
            //查找二级服务
            bglib.BLEResponseATTClientReadByType += new Bluegiga.BLE.Responses.ATTClient.ReadByTypeEventHandler(ATTClientReadByTypeEvent);

            bglib.BLEEventATTClientFindInformationFound += new Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventHandler(this.ATTClientFindInformationFoundEvent);

            bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(this.ATTClientProcedureCompletedEvent);

            bglib.BLEEventATTClientAttributeValue += new Bluegiga.BLE.Events.ATTClient.AttributeValueEventHandler(this.ATTClientAttributeValueEvent);
        }

        private void btOpenCom_Click(object sender, EventArgs e)
        {
            if (cmbComPort.Items.Count <= 0)
            { 
                MessageBox.Show("未发现可用串口，请检查硬件设备");
                return;
            }

            if (comDev.IsOpen == false)
            {
                comDev.PortName = cmbComPort.SelectedValue.ToString();
                comDev.BaudRate = int.Parse(cmbComBaud.Text);
                comDev.DataBits = int.Parse(cmbComDatabit.Text);
                comDev.StopBits = (StopBits)(cmbComStopbit.SelectedIndex+1);
                comDev.Parity = (Parity)cmbComStopbit.SelectedIndex;
                try
                {
                    comDev.Open();
                    btOpenCom.Text = "Close";
                    picOpenCom.Image = Properties.Resources.BMP_GREEN;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "打开失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    comDev.Close();
                    btOpenCom.Text = "Open";
                    picOpenCom.Image = Properties.Resources.BMP_GRAY;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "关闭失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            cmbComPort.Enabled    = !comDev.IsOpen;
            cmbComBaud.Enabled    = !comDev.IsOpen;
            cmbComParity.Enabled  = !comDev.IsOpen;
            cmbComDatabit.Enabled = !comDev.IsOpen;
            cmbComStopbit.Enabled = !comDev.IsOpen;
        }

        /// <summary>
        /// 一旦ComDevice.DataReceived事件发生，就将从串口接收到的数据显示到接收端对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnComReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //开辟接收缓冲区
            byte[] ReDatas = new byte[comDev.BytesToRead];
           
            //从串口读取数据
            comDev.Read(ReDatas, 0, ReDatas.Length);
            AddData(ReDatas);

            // DEBUG: display bytes read
            //Console.WriteLine("<= RX ({0}) [ {1}]", ReDatas.Length, ByteArrayToHexString(ReDatas));
            tslbRxMsg.Text = string.Format("<= RX ({0}) [ {1}]", ReDatas.Length, ByteArrayToHexString(ReDatas));
            // parse all bytes read through BGLib parser
            for (int i = 0; i < ReDatas.Length; i++)
            {
                bglib.Parse(ReDatas[i]);
            }
            //实现数据的解码与显示
        }

        public void AddData(byte[] data)
        {
            int hex;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                hex = data[i];
                sb.AppendFormat("{0}", Char.ConvertFromUtf32(data[i]));
            }

            this.Invoke((EventHandler)(delegate
            {
                //tbCom.Text += sb + "\n\r";
            }));
        }

        /// <summary>
        /// 此函数将编码后的消息传递给串口
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SendData(byte[] data)
        {
            if (comDev.IsOpen)
            {
                try
                {
                    //将消息传递给串口
                    comDev.Write(data, 0, data.Length);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未开启", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// 16进制编码
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0) hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }
        public string ByteArrayToHexString(Byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }

        private void btScanStart_Click(object sender, EventArgs e)
        {
            // send gap_discover(mode: 1)
            //serialAPI.Write(new Byte[] { 0, 1, 6, 2, 1 }, 0, 5);
            if (comDev.IsOpen == true)
            {
                bglib.SendCommand(comDev, bglib.BLECommandGAPDiscover(1));
                //bglib.SendCommand(comDev, bglib.BLECommandGAPSetScanParameters(0xC8, 0xC8, 1));
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btScanStop_Click(object sender, EventArgs e)
        {
            //serialAPI.Write(new Byte[] { 0, 0, 6, 4 }, 0, 4);
            if (comDev.IsOpen == true)
            {
                // disconnect if connected
                bglib.SendCommand(comDev, bglib.BLECommandConnectionDisconnect(0));

                // stop scanning if scanning
                bglib.SendCommand(comDev, bglib.BLECommandGAPEndProcedure());

                // stop advertising if advertising
                bglib.SendCommand(comDev, bglib.BLECommandGAPSetMode(0, 0));

                // update state
                gApp_state = STATE_STANDBY;
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (comDev.IsOpen == false)
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Byte[] cmd = bglib.BLECommandGAPConnectDirect(gMacAddr, gAddrType, 0x20, 0x30, 0x100, 0);
            bglib.SendCommand(comDev, cmd);// 125ms interval, 125ms window, active scanning
            //while(bglib.IsBusy();

            // update state
            gApp_state = STATE_CONNECTING;
        }

        private void lvScanDev_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                gMacAddr = strToHexByte(e.Item.SubItems[3].Text);
                gAddrType = byte.Parse(e.Item.SubItems[4].Text);
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            bglib.SendCommand(comDev, bglib.BLECommandConnectionDisconnect(gAddrType));
        }

        private void cmbComPort_DropDown(object sender, EventArgs e)
        {
            // get a list of all available ports on the system
            portDict.Clear();
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort");
                //string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    portDict.Add(String.Format("{0}", queryObj["DeviceID"]), String.Format("{0} - {1}", queryObj["DeviceID"], queryObj["Caption"]));
                }
            }
            catch (ManagementException ex)
            {
                portDict.Add("0", "Error " + ex.Message);
            }
        }
    }
}
