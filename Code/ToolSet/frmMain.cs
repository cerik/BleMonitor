﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToolSet
{
    public partial class frmMain : Form
    {
        
        //波特率;
        readonly int[] M_BAUNDRATE = { 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 43000, 56000, 57600, 115200 };

        //数据位;
        // NOPARITY            0
        // ODDPARITY           1
        // EVENPARITY          2
        readonly int[] M_PARITY = { 0, 1, 2 };

        //数据位;
        readonly int[] M_DATABITS = { 8, 7, 6 };

        // ONESTOPBIT          1
        // ONE5STOPBITS        3
        // TWOSTOPBITS         2
        readonly byte[] M_STOPBITS = { 1, 3, 2 };

        //定义端口类
        private SerialPort hComDev = new SerialPort();

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
            Byte  m_Tag; //消息计数,0~255循环,可用于统计消息丢包或误码率;
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

        public UInt16 app_state = STATE_STANDBY;        // current application state
        public Byte connection_handle = 0;              // connection handle (will always be 0 if only one connection happens at a time)
        public UInt16 att_handlesearch_start = 0;       // "start" handle holder during search
        public UInt16 att_handlesearch_end = 0;         // "end" handle holder during search
        public UInt16 att_handle_measurement = 0;       // heart rate measurement attribute handle
        public UInt16 att_handle_measurement_ccc = 0;   // heart rate measurement client characteristic configuration handle (to enable notifications)

        public Bluegiga.BGLib bglib = new Bluegiga.BGLib();
        //byte[] macaddress;
        //byte addresstype;

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

        public void GAPScanResponseEvent(object sender, Bluegiga.BLE.Events.GAP.ScanResponseEventArgs e)
        {
            string mName = "";

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
                        {
                            // partial or complete list of 16-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(2).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x04 || this_field[0] == 0x05)
                        {
                            // partial or complete list of 32-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(4).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x06 || this_field[0] == 0x07)
                        {
                            // partial or complete list of 128-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(16).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x09)
                        {//Full name
                            mName = System.Text.Encoding.ASCII.GetString(this_field.Skip(1).ToArray());
                        }
                    }
                }

                //ASCii码转换
                String log = String.Format("ble_evt_gap_scan_response:" + Environment.NewLine + "\trssi={0}, packet_type={1}, bd_addr=[ {2}], address_type={3}, bond={4}, data=[ {5}], convert={6}" + Environment.NewLine,
                    (SByte)e.rssi,
                    (SByte)e.packet_type,
                    ByteArrayToHexString(e.sender),
                    (SByte)e.address_type,
                    (SByte)e.bond,
                    ByteArrayToHexString(e.data),
                    mName
                    );
                Console.Write(log);

                int a = Math.Abs(e.rssi);
                string macaddr = ByteArrayToHexString(e.sender);

                if (mName.Length > 1)
                {
                    ThreadSafeDelegate(delegate
                    {
                        ListViewItem lvS = lvScanDev.FindItemWithText(macaddr);
                        if (lvS != null)
                        {
                            lvS.SubItems[0].Text = mName;
                            lvS.SubItems[1].Text = a.ToString();
                            lvS.SubItems[2].Text = e.packet_type.ToString();
                            lvS.SubItems[3].Text = ByteArrayToHexString(e.sender);
                        }
                        else
                        { 
                            ListViewItem lv = new ListViewItem(mName);//[0];
                            lv.SubItems.Add(a.ToString());//[1]
                            lv.SubItems.Add(e.packet_type.ToString());//[2]
                            lv.SubItems.Add(ByteArrayToHexString(e.sender));//[3]
                            lvScanDev.Items.Add(lv);
                        }
                        //txtLog.AppendText(log);
                    }
                    );
                }
            }
        }

        // the "connection_status" event occurs when a new connection is established
        public void ConnectionStatusEvent(object sender, Bluegiga.BLE.Events.Connection.StatusEventArgs e)
        {
            if (hComDev.IsOpen == false) return;

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
                connection_handle = e.connection;
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Connected to {0}", ByteArrayToHexString(e.address)) + Environment.NewLine); });
                Byte[] cmd = bglib.BLECommandATTClientReadByGroupType(e.connection, 0x0001, 0xFFFF, new Byte[] { 0x00, 0x28 }); // "service" UUID is 0x2800 (little-endian for UUID uint8array)
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                bglib.SendCommand(hComDev, cmd);
                //while (bglib.IsBusy()) ;

                // update state
                app_state = STATE_FINDING_SERVICES;
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
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            // found "service" attribute groups (UUID=0x2800), check for heart rate measurement service
            if (e.uuid.SequenceEqual(new Byte[] { 0x0D, 0x18 }))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute group for service w/UUID=0x180D: start={0}, end=%d", e.start, e.end) + Environment.NewLine); });
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
            if (e.uuid.SequenceEqual(new Byte[] { 0x37, 0x2A }))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2A37: handle={0}", e.chrhandle) + Environment.NewLine); });
                att_handle_measurement = e.chrhandle;
            }
            // check for subsequent client characteristic configuration (UUID=0x2902)
            else if (e.uuid.SequenceEqual(new Byte[] { 0x02, 0x29 }) && att_handle_measurement > 0)
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2902: handle={0}", e.chrhandle) + Environment.NewLine); });
                att_handle_measurement_ccc = e.chrhandle;
            }
        }

        public void ATTClientProcedureCompletedEvent(object sender, Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventArgs e)
        {
            if (hComDev.IsOpen == false) return;

            String log = String.Format("ble_evt_attclient_procedure_completed: connection={0}, result={1}, chrhandle={2}" + Environment.NewLine,
                e.connection,
                e.result,
                e.chrhandle
                );
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            // check if we just finished searching for services
            if (app_state == STATE_FINDING_SERVICES)
            {
                if (att_handlesearch_end > 0)
                {
                    //print "Found 'Heart Rate' service with UUID 0x180D"

                    // found the Heart Rate service, so now search for the attributes inside
                    Byte[] cmd = bglib.BLECommandATTClientFindInformation(e.connection, att_handlesearch_start, att_handlesearch_end);
                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(hComDev, cmd);
                    //while (bglib.IsBusy()) ;

                    // update state
                    app_state = STATE_FINDING_ATTRIBUTES;
                }
                else
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText("Could not find 'Heart Rate' service with UUID 0x180D" + Environment.NewLine); });
                }
            }
            // check if we just finished searching for attributes within the heart rate service
            else if (app_state == STATE_FINDING_ATTRIBUTES)
            {
                if (att_handle_measurement_ccc > 0)
                {
                    //print "Found 'Heart Rate' measurement attribute with UUID 0x2A37"

                    // found the measurement + client characteristic configuration, so enable notifications
                    // (this is done by writing 0x0001 to the client characteristic configuration attribute)
                    Byte[] cmd = bglib.BLECommandATTClientAttributeWrite(e.connection, att_handle_measurement_ccc, new Byte[] { 0x01, 0x00 });
                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(hComDev, cmd);
                    //while (bglib.IsBusy()) ;

                    // update state
                    app_state = STATE_LISTENING_MEASUREMENTS;
                }
                else
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText("Could not find 'Heart Rate' measurement attribute with UUID 0x2A37" + Environment.NewLine); });
                }
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
            if (e.connection == connection_handle && e.atthandle == att_handle_measurement)
            {
                Byte hr_flags = e.value[0];
                int hr_measurement = e.value[1];

                // display actual measurement
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Heart rate: {0} bpm", hr_measurement) + Environment.NewLine); });
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

        //列表系统所有串口;
        private void EnumAllComPort()
        {
            cmbComPort.Items.AddRange(SerialPort.GetPortNames());

            bglib.BLEEventSystemBoot += new Bluegiga.BLE.Events.System.BootEventHandler(this.SystemBootEvent);
            bglib.BLEEventGAPScanResponse += new Bluegiga.BLE.Events.GAP.ScanResponseEventHandler(this.GAPScanResponseEvent);

            //bglib.BLEEventConnectionStatus += new Bluegiga.BLE.Events.Connection.StatusEventHandler(this.ConnectionStatusEvent);
            //bglib.BLEEventATTClientGroupFound += new Bluegiga.BLE.Events.ATTClient.GroupFoundEventHandler(this.ATTClientGroupFoundEvent);
            //bglib.BLEEventATTClientFindInformationFound += new Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventHandler(this.ATTClientFindInformationFoundEvent);
            //bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(this.ATTClientProcedureCompletedEvent);
            //bglib.BLEEventATTClientAttributeValue += new Bluegiga.BLE.Events.ATTClient.AttributeValueEventHandler(this.ATTClientAttributeValueEvent);
        }

        private void InitComConfig()
        {
            
        }

        private void btOpenCom_Click(object sender, EventArgs e)
        {
            if (cmbComPort.Items.Count <= 0)
            { 
                MessageBox.Show("未发现可用串口，请检查硬件设备");
                return;
            }

            if (hComDev.IsOpen == false)
            {
                hComDev.PortName = cmbComPort.SelectedItem.ToString();
                hComDev.BaudRate = Convert.ToInt32(cmbComBaud.SelectedItem.ToString());
                hComDev.Parity = (Parity)M_PARITY[cmbComParity.SelectedIndex];
                hComDev.DataBits = M_DATABITS[cmbComDatabit.SelectedIndex];
                hComDev.StopBits = (StopBits)M_STOPBITS[cmbComStopbit.SelectedIndex];
                try
                {
                    hComDev.Open();
                    btOpenCom.Text = "关闭串口";
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
                    hComDev.Close();
                    btOpenCom.Text = "打开串口";
                    picOpenCom.Image = Properties.Resources.BMP_GRAY;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "关闭失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            cmbComPort.Enabled    = !hComDev.IsOpen;
            cmbComBaud.Enabled    = !hComDev.IsOpen;
            cmbComParity.Enabled  = !hComDev.IsOpen;
            cmbComDatabit.Enabled = !hComDev.IsOpen;
            cmbComStopbit.Enabled = !hComDev.IsOpen;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            EnumAllComPort();
            if (cmbComPort.Items.Count > 0) cmbComPort.SelectedIndex = 0;
            cmbComBaud.SelectedIndex = 5;
            cmbComParity.SelectedIndex = 0;
            cmbComDatabit.SelectedIndex = 0;
            cmbComStopbit.SelectedIndex = 0;

            //向ComDevice.DataReceived（是一个事件）注册一个方法Com_DataReceived，
            //当端口类接收到信息时时会自动调用Com_DataReceived方法
            hComDev.DataReceived += new SerialDataReceivedEventHandler(OnComReceived);
        }

        /// <summary>
        /// 一旦ComDevice.DataReceived事件发生，就将从串口接收到的数据显示到接收端对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnComReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //开辟接收缓冲区
            byte[] ReDatas = new byte[hComDev.BytesToRead];
           
            //从串口读取数据
            hComDev.Read(ReDatas, 0, ReDatas.Length);
            AddData(ReDatas);

            // DEBUG: display bytes read
            Console.WriteLine("<= RX ({0}) [ {1}]", ReDatas.Length, ByteArrayToHexString(ReDatas));

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
            if (hComDev.IsOpen)
            {
                try
                {
                    //将消息传递给串口
                    hComDev.Write(data, 0, data.Length);
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
            if (hComDev.IsOpen == true)
            {
                bglib.SendCommand(hComDev, bglib.BLECommandGAPDiscover(1));
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btScanStop_Click(object sender, EventArgs e)
        {
            // send gap_end_procedure()
            //serialAPI.Write(new Byte[] { 0, 0, 6, 4 }, 0, 4);
            if (hComDev.IsOpen == true)
            {
                bglib.SendCommand(hComDev, bglib.BLECommandGAPEndProcedure());
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
