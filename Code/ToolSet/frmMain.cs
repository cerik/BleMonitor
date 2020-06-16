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
using System.Threading;

namespace ToolSet
{
#if false
    public enum ATTR_TYPE_BIT_POS{
        TYPE_READ =1,       //value was read;
        TYPE_NOTIFY =2,     //value was notified.
        TYPE_INDICATE =3,   //vqalue was indicated.
        TYPE_READ_BY_TYPE =4,    //value was read.
        TYPE_READ_BLOB =5,       //value was part of a long attribute.
        TYPE_INDICATE_RSP_REQ =6 //value was indicated and the remote device is waiting for a confirmation.
    };
    

    //
    //广播消息帧格式定义;
    //
    public struct tPkg
    {
        
        private Byte m_Byte0;
        private Byte m_LengthLow;
        private Byte m_ClassID;
        private Byte m_CmdID;
        public Byte[] m_Payload;//max 2048 bytes;

#region interface

        public Byte MsgType
        {//0=Cmd | response; 0x80:event from statck to host.
            get { return (Byte)(m_Byte0 >> 7); }
            set { m_Byte0 = (Byte)(m_Byte0 | (value << 7)); }
        }
        public Byte TechType
        {
            get { return (Byte)((m_Byte0 >> 3) & 0x7); }
            set { m_Byte0 = (Byte)((m_Byte0 & 0x87) | (value << 3)); }
        }
        public UInt16 Length
        {
            get { return (UInt16)(((m_Byte0 & 0x3) << 8) + m_LengthLow); }
            set { m_Byte0 = (Byte)((m_Byte0 & 0xFC) | ((value & 0x300) >> 8)); m_LengthLow = (Byte)(value & 0xFF); }
        }

        public Byte ClassID
        {
            set { m_ClassID = value; }
            get { return m_ClassID; }
        }
        public Byte CmdID
        {
            set { m_CmdID = value; }
            get { return m_CmdID; }
        }

#endregion
    };
#endif

    public partial class frmMain : Form
    {
        public readonly string[] AttrType = { "Read", "Notify", "Indicate", "ReadByType", "ReadBlob", "IndicateRspReq" };

        public Dictionary<string, string> portDict = new Dictionary<string, string>();

        /* ================================================================ */
        /*                BEGIN MAIN EVENT-DRIVEN APP LOGIC                 */
        /* ================================================================ */
        public static Byte gConnectID = 0xFF;                // connection handle (will always be 0 if only one connection happens at a time)
        public static ushort gChrHandle = 0xFF;

        private Thread m_ScanThread = null;
        public  bool m_ProcCompleted = false;
        public bool m_ReadDone = true;
        private Byte[] m_AttrReadData = null;
        private bool m_CheckUserDesc = false;

        private static BleService c_BleService = new BleService();

        public static Bluegiga.BGLib bglib = new Bluegiga.BGLib();

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
        //
        //
        //Search Event
        // for master/scanner devices, the "gap_scan_response" event is a common entry-like point
        // this filters ad packets to find devices which advertise the Health Thermometer service
        // This is a scan response event. This event is normally received by a Master which is scanning for advertisement and
        // scan response packets from Slaves.
        // Data Fiels:
        // [4]=int8, rssi; RSSI value(dBm), range=[-103 ~ -38];
        // [5]=uint8,packet_type; Scan response header;
        //       0: Connectable Advertisement packet.
        //       2: Non Connectable Advertisement packet.
        //       4: Scan response packet.
        //       6: Discoverable advertisement packet.
        // [6~11]:bd_addr; Advertisers Bluetooth address.
        // [12]:uint8,address_type; Advertiser address type,
        //           1: random address; 0: public address
        // [13]:uint8,bond; Bond handle if there is known bond for this device, 0xff otherwise.
        // [14]:uint8 array, data; Scan response data.
        public void GAPScanResponseEvent(object sender, Bluegiga.BLE.Events.GAP.ScanResponseEventArgs e)
        {
            string mName = "(No Name)";

            // pull all advertised service info from ad packet
            //List<Byte[]> ad_services = new List<Byte[]>();

            Byte[] this_field = { };
            int bytes_left = 0;
            int field_offset = 0;
            for (int i = 0; i < e.data.Length; i++)
            {
                //提取设备名称;
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
#if false
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
#else
                        if (this_field[0] == 0x09)
                        {//Full name
                            mName = System.Text.Encoding.ASCII.GetString(this_field.Skip(1).ToArray());
                        }
#endif
                    }
                }
            }

            //添加扫描信息到列表中;
            int rssi = Math.Abs(e.rssi);
            string macaddr = ByteArrayToHexString(e.sender);
            ThreadSafeDelegate(delegate
            {
                //
                //check whether this dev is already displayed in the list.
                //if it is not, we add it to the listbox,otherwise, just update.
                //
                ListViewItem lvS = listScanDev.FindItemWithText(macaddr);//查找列表中是否有重复设备;
                if (lvS != null)
                {
                    lvS.SubItems[0].Text = mName;
                    lvS.SubItems[1].Text = rssi.ToString();
                    lvS.SubItems[2].Text = ByteArrayToHexString(e.sender);
                }
                else
                {
                    ListViewItem lv = new ListViewItem(mName);//[0];
                    lv.SubItems.Add(rssi.ToString());//[1]
                    lv.SubItems.Add(ByteArrayToHexString(e.sender));//[2]
                    lv.SubItems.Add(e.address_type.ToString());//[3]
                    listScanDev.Items.Add(lv);
                }
            });
        }

        // the "connection_status" event occurs when a new connection is established
        //连接事件
        //This event indicates the connection status and parameters.
        //Data field
        //[4]=uint8, connection handle;
        //[5]=uint8,flags;connection status flags use connstatus-enumerator.
        //[6~11]=ad_addr,address;remote device bluetooth address.
        //[12]=uint8,address_type; Remote address type.
        //[13~14]=uint16,conn_interval; Current connection interval(units of 1.25ms);
        //[15~16]=uint16,timeout; Current supervision timeout(units of 10ms);
        //[17~18]=uint16,latency; Slave latency which tells how many connection intervals the slave may skip.
        //[19]=uint8,bonding; Bonding handle if the device has been bonded with. Otherwise:0xFF;
        public void ConnectEvent(object sender, Bluegiga.BLE.Events.Connection.StatusEventArgs e)
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

            //flags:
            //bit.0 = connection_connected; the connection exists to a remote device.
            //bit.1 = connection_encrypted; the connection is encrypted.
            //bit.2 = connection_completed flag, which is used to tell a new connection has been created.
            //bit.3 = connection_parameters_change; the connection parameters have changed and. It is set when connection parameters have changed due to a link layer operation.
            if ((e.flags & 0x05) == 0x05)
            {
                // connected, now perform service discovery
                gConnectID = e.connection;
                //gConnection_MacAddr = e.address;// strToHexByte(listScanDev.SelectedItems[0].SubItems[3].Text);
                ThreadSafeDelegate(delegate 
                {
                    txtLog.AppendText(String.Format("Connected to {0}", ByteArrayToHexString(e.address)) + Environment.NewLine);
                    btConnect.Image = Properties.Resources.BMP_GREEN;
                    stsLb_ConnSts.Image = Properties.Resources.BMP_GREEN;
                });

                //
                Byte[] cmd = bglib.BLECommandATTClientReadByGroupType(e.connection, 0x0001, 0xFFFF, new Byte[] { 0x00, 0x28 }); // "find primary service" UUID is 0x2800 (little-endian for UUID uint8array)
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate
                {
                    txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine);
                    listPrimSrv.Items.Clear();
                });
                m_ProcCompleted = false;
                bglib.SendCommand(comDev, cmd);
            }
        }

        public void DisconnectEvent(object sender, Bluegiga.BLE.Events.Connection.DisconnectedEventArgs e)
        {
            gConnectID = 0xFF;
        }

        //This event is produced when an attributed group(a service) is found. Typically this event is produced after Read by Group Type command.
        //Data Feild:
        // [4] = uint8, connection; Connection handle;
        // [5~6] = uint16,start; Starting handle;
        // [7~8] = uint16,end; Ending handle; 'end' is a reserved word and in BGScrpit so 'end' conn't be used as such.
        // [9..] = uint8array, uuid; UUID os a service; Length is 0 if no service are found.
        public void ATTClientGroupFoundEvent(object sender, Bluegiga.BLE.Events.ATTClient.GroupFoundEventArgs e)
        {
            ThreadSafeDelegate(delegate
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = c_BleService.ServiceNameByUUID(e.uuid.ToArray());//column[0];
                lv.SubItems.Add(e.start.ToString());//column[1];
                lv.SubItems.Add(e.end.ToString());//column[2];
                lv.SubItems.Add(ByteArrayToHexString(e.uuid.ToArray()));//column[3];
                listPrimSrv.Items.Add(lv);
            });
        }


        //
        //查找子服务的应答事件,从中提取子服务内容;
        //
        public void ATTClientFindInformationFoundEvent(object sender, Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventArgs e)
        {
            String name = "";
            //ThreadSafeDelegate(delegate { txtLog.AppendText(log); });
            if (e.connection == gConnectID)
            {
                if (c_BleService.IsDeclarePrimaryService(e.uuid))//e.uuid.SequenceEqual(new Byte[] { 0x00, 0x28 }))
                {
                }
                else if ( c_BleService.IsDeclareAttribute(e.uuid))//e.uuid.SequenceEqual(new Byte[] { 0x03, 0x28 }))
                {
                }
                else if (c_BleService.IsDescClientConfig(e.uuid))
                {//ClientCharacteristicConfiguration
                }
                else if (c_BleService.IsDescUserAttribute(e.uuid))
                {//Characteristic User Description
                }
                //else
                {//charactestic attribute
                    ThreadSafeDelegate(delegate
                    {
                        ListViewItem lv = new ListViewItem();
                        lv.Text = name;//column[0];
                        lv.SubItems.Add(e.connection.ToString());//column[1];
                        lv.SubItems.Add(e.chrhandle.ToString());//column[2];attribute handle
                        lv.SubItems.Add(ByteArrayToHexString(e.uuid));//column[3];

                        listAttribute.Items.Add(lv);
                        listAttribute.Width = -1;
                    });
                }
            }
        }

        public void ATTClientProcedureCompletedEvent(object sender, Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventArgs e)
        {
            if (comDev.IsOpen == false) return;

            m_ProcCompleted = true;
        }

        public void ATTClientAttributeValueEvent(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
        {
            // check for a new value from the connected peripheral's heart rate measurement attribute
            if (e.connection == gConnectID)// && e.atthandle == gChrHandle)
            {
                m_AttrReadData = e.value;
                m_ReadDone = true;
                ThreadSafeDelegate(delegate
                {
                    if (rbChar.Checked)
                    {
                        tbAttrData.Text = Encoding.UTF8.GetString(e.value);
                    }
                    else if (rbHex.Checked)
                    {
                        tbAttrData.Text = ByteArrayToHexString(e.value);
                    }
                    else
                    {
                        tbAttrData.Text = ByteArrayToDecString(e.value);
                    }
                });
            }
        }

        public void WriteCommandEvent(object sender, Bluegiga.BLE.Responses.ATTClient.WriteCommandEventArgs e)
        {
            ushort a = e.result;
        }

        //Attribute read response event
        ////response data:
        //  [4~5] : uint16, handle; handle of the attribute which was read;
        //  [6~7] : uint16, offset; Offset read from;
        //  [8~9] : uint16, result; 0: the read was successfull; Non-zero:An error occurred.
        //  [10..]: uint8array; value; maximum of 32 bytes can be read at a time.
#if false
        public void AttributeWriteEvent(object sender, Bluegiga.BLE.Responses.ATTClient.AttributeWriteEventArgs e)
        {
            bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(ProcedureCompleted);
        }

        public void AttributeValueFirmware(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
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

        public void ATTClientProcedureCompleted(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
        {
            
        }
#endif

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
        private string GetAttrBoxID(int row)
        {
            if (listAttribute.InvokeRequired)
            {
                string str = string.Empty;
                this.listAttribute.Invoke(new MethodInvoker(delegate { str = listAttribute.Items[row].SubItems[2].Text; }));
                return str;
            }
            else
            {
            }
            return null;
        }
        private void SetAttrUserDesc(int rowIdx,string str)
        {
            listAttribute.Invoke(new Action<String>(p => { listAttribute.Items[rowIdx].SubItems[0].Text = str; }), listAttribute.Items[rowIdx].SubItems[0].Text);
        }

        private void ScanThread()
        {
            ushort attrid = 0;
            Byte[] cmd;
            string str = null;

            while (true)
            { 
                if (m_CheckUserDesc == true)
                {
                    if(m_ReadDone)
                    {
                        int idx = 0;
                        while (idx < listAttribute.Items.Count)
                        {
                            str = GetAttrBoxID(idx);// listAttribute.Items[idx].SubItems[2].Text;
                            attrid = ushort.Parse(str);
                            attrid = (ushort)(attrid +1);
                            m_ReadDone = false;
                            cmd = bglib.BLECommandATTClientReadByHandle(gConnectID, attrid);
                            //do
                            {
                                bglib.SendCommand(comDev, cmd);
                                //Thread.Sleep(1000);
                            };// 
                            while (m_ReadDone == false);
                            str = Encoding.UTF8.GetString(m_AttrReadData);
                            ThreadSafeDelegate(delegate
                            {
                                listAttribute.Items[idx].SubItems[0].Text = str;
                                idx++;
                             });
                            //SetAttrUserDesc(idx, str);
                            //idx++;
                        }
                        m_CheckUserDesc = false;
                    }
                }
                Thread.Sleep(100);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolCmbPort_DropDown(sender, e);// initialize COM port combobox with list of ports
            // initialize serial port with all of the normal values (should work with BLED112 on USB)
            comDev.Handshake = System.IO.Ports.Handshake.RequestToSend;
            toolCmbBaudrate.SelectedIndex = 5;

            //向ComDevice.DataReceived（是一个事件）注册一个方法Com_DataReceived，
            //当端口类接收到信息时时会自动调用Com_DataReceived方法
            comDev.DataReceived += new SerialDataReceivedEventHandler(OnComReceived);

            //
            //BLE 事件回调;
            //

            //This event is produced when the device boots up and is ready to receive commands.
            //This event is not sent over USB interface.
            //Data Field: ref.Page195.
            bglib.BLEEventSystemBoot += new Bluegiga.BLE.Events.System.BootEventHandler(this.SystemBootEvent);

            //Search Event
            // for master/scanner devices, the "gap_scan_response" event is a common entry-like point
            // this filters ad packets to find devices which advertise the Health Thermometer service
            // This is a scan response event. This event is normally received by a Master which is scanning for advertisement and
            // scan response packets from Slaves.
            // Data Fiels:
            // [4]=int8, rssi; RSSI value(dBm), range=[-103 ~ -38];
            // [5]=uint8,packet_type; Scan response header;
            //       0: Connectable Advertisement packet.
            //       2: Non Connectable Advertisement packet.
            //       4: Scan response packet.
            //       6: Discoverable advertisement packet.
            // [6~11]:bd_addr; Advertisers Bluetooth address.
            // [12]:uint8,address_type; Advertiser address type,
            //           1: random address; 0: public address
            // [13]:uint8,bond; Bond handle if there is known bond for this device, 0xff otherwise.
            // [14]:uint8 array, data; Scan response data.
            bglib.BLEEventGAPScanResponse += new Bluegiga.BLE.Events.GAP.ScanResponseEventHandler(this.GAPScanResponseEvent);

            //连接动作
            //This event indicates the connection status and parameters.
            //Data Field:
            // [4] = uint8,connection; Connection handle;
            // [5] = uint8,flags; Connection status flags use connstatus-enumerator.
            // [6~11]:bd_addr;
            // [12]:uint8,address_type;
            // [13~14]:uint16, conn_interval;
            // [15~16]:uint16, timeout;
            // [17~18]:uint16,latency;
            // [19]:uint8, bonding.
            //bglib.BLEResponseGAPConnectDirect += new Bluegiga.BLE.Responses.GAP.ConnectDirectEventHandler(ConnectDirect);

            //连接事件
            //This event indicates the connection status and parameters.
            //Data field
            //[4]=uint8, connection handle;
            //[5]=uint8,flags;connection status flags use connstatus-enumerator.
            //[6~11]=ad_addr,address;remote device bluetooth address.
            //[12]=uint8,address_type; Remote address type.
            //[13~14]=uint16,conn_interval; Current connection interval(units of 1.25ms);
            //[15~16]=uint16,timeout; Current supervision timeout(units of 10ms);
            //[17~18]=uint16,latency; Slave latency which tells how many connection intervals the slave may skip.
            //[19]=uint8,bonding; Bonding handle if the device has been bonded with. Otherwise:0xFF;
            bglib.BLEEventConnectionStatus += new Bluegiga.BLE.Events.Connection.StatusEventHandler(this.ConnectEvent);

            bglib.BLEEventConnectionDisconnected += new Bluegiga.BLE.Events.Connection.DisconnectedEventHandler(this.DisconnectEvent);


            //查找一级服务
            //This event is produced when an attributed group(a service) is found. Typically this event is produced after Read by Group Type command.
            //Data Feild:
            // [4] = uint8, connection; Connection handle;
            // [5~6] = uint16,start; Starting handle;
            // [7~8] = uint16,end; Ending handle; 'end' is a reserved word and in BGScrpit so 'end' conn't be used as such.
            // [9..] = uint8array, uuid; UUID os a service; Length is 0 if no service are found.
            bglib.BLEEventATTClientGroupFound += new Bluegiga.BLE.Events.ATTClient.GroupFoundEventHandler(this.ATTClientGroupFoundEvent);

            //查找二级服务
            //bglib.BLEResponseATTClientReadByType += new Bluegiga.BLE.Responses.ATTClient.ReadByTypeEventHandler(ATTClientReadByTypeEvent);

            //This event is generated when characteristics type mappings are found. This happens typically after Find Information command
            //has been issued to discover all attributes of a service.
            bglib.BLEEventATTClientFindInformationFound += new Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventHandler(this.ATTClientFindInformationFoundEvent);

            //attribute write comeplete event. 
            //This event is produced ata the GATT client when an attribute protocol event is completed a and new operation can be issued.
            //
            //This event is for example produced after an Attribute Write command is successfully used to write a value to a remote device.
            bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(this.ATTClientProcedureCompletedEvent);

            //This event is produced at the GATT client side when an attribute value is passed from the GATT server to the 
            //GATT client. This event is for example produced after a successfull Read by Handle operation or when an attribute 
            //is indicated or notified by the remote device.
            bglib.BLEEventATTClientAttributeValue += new Bluegiga.BLE.Events.ATTClient.AttributeValueEventHandler(this.ATTClientAttributeValueEvent);

            //Attribute read response event
            ////response data:
            //  [4~5] : uint16, handle; handle of the attribute which was read;
            //  [6~7] : uint16, offset; Offset read from;
            //  [8~9] : uint16, result; 0: the read was successfull; Non-zero:An error occurred.
            //  [10..]: uint8array; value; maximum of 32 bytes can be read at a time.
            //bglib.BLEResponseAttributesRead += new Bluegiga.BLE.Responses.Attributes.ReadEventHandler(this.AttributesReadResponseEvent);

            //Indicated --attclient
            //This event is produced at the GATT server side when an attribute is successfully indicated to the GATT client.
            //This means the event is only produced at the GATT server if the indication is acknowledged by the GATT client(the removte device).

            //splitTab1_Main.Panel2Collapsed = true;
            //splitTab1_Sub.Panel2Collapsed = true;

            SetEnableByComSts(false);

            m_ScanThread = new Thread(new ThreadStart(ScanThread));
            m_ScanThread.IsBackground = true;
            ///m_ScanThread.Start();
        }


        private void toolCmbPort_DropDown(object sender, EventArgs e)
        {
            // get a list of all available ports on the system
            portDict.Clear();
            toolCmbPort.ComboBox.DataSource = null;
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort");
                //string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    portDict.Add(String.Format("{0}", queryObj["DeviceID"]), String.Format("{0} - {1}", queryObj["DeviceID"], queryObj["Caption"]));
                }
                if (portDict.Count > 0)
                {
                    toolCmbPort.ComboBox.DataSource = new BindingSource(portDict, null);
                    toolCmbPort.ComboBox.ValueMember = "Key";
                    toolCmbPort.ComboBox.DisplayMember = "Value";
                }
            }
            catch (ManagementException ex)
            {
                portDict.Add("0", "Error " + ex.Message);
            }
        }

        private void toolBtOpenCom_Click(object sender, EventArgs e)
        {
            if (toolCmbPort.Items.Count <= 0)
            {
                MessageBox.Show("未发现可用串口，请检查硬件设备");
                return;
            }

            if (comDev.IsOpen == false)
            {
                comDev.PortName = toolCmbPort.ComboBox.SelectedValue.ToString();
                comDev.BaudRate = int.Parse(toolCmbBaudrate.Text);
                comDev.DataBits = 8;
                comDev.StopBits = StopBits.One;
                comDev.Parity = Parity.None;
                try
                {
                    comDev.Open();
                    toolBtOpenCom.Text = "Close";
                    toolBtOpenCom.Image = Properties.Resources.BMP_GREEN;
                    timPeridic.Start();
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
                    toolBtOpenCom.Text = "Open";
                    toolBtOpenCom.Image = Properties.Resources.BMP_GRAY;
                    timPeridic.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "关闭失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            SetEnableByComSts(comDev.IsOpen);
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
            //tslbRxMsg.Text = string.Format("<= RX ({0}) [ {1}]", ReDatas.Length, ByteArrayToHexString(ReDatas));
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
        public string ByteArrayToDecString(Byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:D} ", b);
            return hex.ToString();
        }
        private void btScanStart_Click(object sender, EventArgs e)
        {
            if (comDev.IsOpen == true)
            {
                if (btScanStart.Text == "StopScan")
                {
                    // update state
                    btScanStart.Text = "StartScan";
                    btScanStart.Image = Properties.Resources.BMP_GRAY;

                    // stop scanning if scanning
                    bglib.SendCommand(comDev, bglib.BLECommandGAPEndProcedure());
                }
                else
                {
                    listScanDev.Items.Clear();

                    // disconnect if connected
                    bglib.SendCommand(comDev, bglib.BLECommandConnectionDisconnect(0));

                    m_ProcCompleted = false;
                    btScanStart.Text = "StopScan";
                    btScanStart.Image = Properties.Resources.BMP_GREEN;
                    bglib.SendCommand(comDev, bglib.BLECommandGAPDiscover(1));//gap_discover_generic:
                }
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btDisconnect_Click(object sender, EventArgs e)
        {
            m_ProcCompleted = false;
            btConnect.Image = Properties.Resources.BMP_GRAY;
            stsLb_ConnSts.Image = Properties.Resources.BMP_GRAY;
            bglib.SendCommand(comDev, bglib.BLECommandConnectionDisconnect(gConnectID));
        }

        private void listPrimSrv_DoubleClick(object sender, EventArgs e)
        {
            if (comDev.IsOpen == false)
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listPrimSrv.SelectedIndices != null && listPrimSrv.SelectedItems.Count > 0)
            {
                Byte connHandle;// = Byte.Parse(listPrimSrv.SelectedItems[0].SubItems[0].Text) ;// strToHexByte(listPrimSrv.SelectedItems[0].SubItems[0].Text);
                UInt16 start, end;

                splitTab1_Sub.Panel2Collapsed = false;

                listAttribute.Items.Clear();

                connHandle = gConnectID;// Byte.Parse(listPrimSrv.SelectedItems[0].SubItems[0].Text);// strToHexByte(listPrimSrv.SelectedItems[0].SubItems[0].Text);
                start = UInt16.Parse(listPrimSrv.SelectedItems[0].SubItems[1].Text);
                end = UInt16.Parse(listPrimSrv.SelectedItems[0].SubItems[2].Text);
                Byte[] uuid = strToHexByte(listPrimSrv.SelectedItems[0].SubItems[3].Text);

                if (true)//uuid[0] == 0x0F && uuid[1] == 0x18)
                {
                    tabPgBat.Show();
                }
                else
                {
                    tabPgBat.Hide();
                }

                m_ProcCompleted = false;
                Byte[] cmd = bglib.BLECommandATTClientFindInformation(connHandle, start, end);
                bglib.SendCommand(comDev, cmd);
                //m_CheckUserDesc = true;
            }
        }
        private void btConnect_Click(object sender, EventArgs e)
        {
            listScanDev_DoubleClick(sender, e);
        }
        private void listScanDev_DoubleClick(object sender, EventArgs e)
        {
            byte[] gMacAddr;
            byte gAddrType;

            if (comDev.IsOpen == false)
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listScanDev.SelectedIndices != null && listScanDev.SelectedItems.Count > 0)
            {
                //splitTab1_Main.Panel1Collapsed = true;

                gMacAddr = strToHexByte(listScanDev.SelectedItems[0].SubItems[2].Text);
                gAddrType = byte.Parse(listScanDev.SelectedItems[0].SubItems[3].Text);

                stsLb_ConnSts.Text = listScanDev.SelectedItems[0].SubItems[0].Text;
                stsLb_ConnMac.Text = "MacAddr=" + listScanDev.SelectedItems[0].SubItems[2].Text;

                m_ProcCompleted = false;
                Byte[] cmd = bglib.BLECommandGAPConnectDirect(gMacAddr, gAddrType, 0x20, 0x30, 0x100, 0);
                bglib.SendCommand(comDev, cmd);// 125ms interval, 125ms window, active scanning
                                               //while(bglib.IsBusy();
            }
        }

        private void listAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAttribute.SelectedIndices != null && listAttribute.SelectedIndices.Count > 0)
            {
                gChrHandle = ushort.Parse(listAttribute.SelectedItems[0].SubItems[2].Text);
                tbAttrID.Text = gChrHandle.ToString("D");
                tbConnID.Text = gConnectID.ToString("D");
            }
        }
        private void toolBtDevPanel_Click(object sender, EventArgs e)
        {
            splitTab1_Main.Panel1Collapsed = false;
            splitTab1_Main.Panel2Collapsed = true;
        }

        private void toolBtPrimSrvPanel_Click(object sender, EventArgs e)
        {
            //splitTab1_Sub.Panel1Collapsed = !splitTab1_Sub.Panel1Collapsed;
            //if(gApp_state != STATE_STANDBY)
            //{ 
            //    splitTab1_Main.Panel1Collapsed = true;
            //    splitTab1_Main.Panel2Collapsed = false;
            //}
        }
        
        //
        //Auto adjust the cloumn width both for contents and header.
        //
        private void AutoResizeColumnWidth(ListView lv)
        {
            for (int i = 0; i < lv.Columns.Count; i++)
            {
                lv.Columns[i].Width = -1;
                lv.Columns[i].Width = -2;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (comDev.IsOpen)
            {
                //btScanStart_Click(sender, e);
            }
        }

        private void SetEnableByComSts(bool enable)
        {
            if (enable)
            {
                btScanStart.Enabled = true;
                btConnect.Enabled = true;
                btDisconnect.Enabled = true;

                toolCmbPort.Enabled = false;
                toolCmbBaudrate.Enabled = false;
            }
            else
            {
                btScanStart.Enabled = false;
                btConnect.Enabled = false;
                btDisconnect.Enabled = false;

                toolCmbPort.Enabled = true;
                toolCmbBaudrate.Enabled = false;
            }
        }

        private void timPeridic_Tick(object sender, EventArgs e)
        {
            if (bglib.IsBusy()) tsLabelScan.Text = "Busy";
            else tsLabelScan.Text = "Ready";

            if (m_CheckUserDesc == true)
            {
                if (m_ProcCompleted == true)
                {
                    UpdateUserDesc();
                    m_CheckUserDesc = false;
                }
            }
        }

        private void btAttrRead_Click(object sender, EventArgs e)
        {
            m_ProcCompleted = false;
            Byte[] cmd = bglib.BLECommandATTClientReadByHandle(gConnectID,gChrHandle);
            bglib.SendCommand(comDev,cmd);
        }

        private void UpdateUserDesc()
        {
            ushort attrid = 0;
            Byte[] cmd;
            string str = null;

            int idx = 0;
            while (idx < listAttribute.Items.Count)
            {
                //str = GetAttrBoxID(idx);// 
                str = listAttribute.Items[idx].SubItems[2].Text;
                attrid = ushort.Parse(str);
                attrid = (ushort)(attrid + 1);
                m_ReadDone = false;
                cmd = bglib.BLECommandATTClientReadByHandle(gConnectID, attrid);

                bglib.SendCommand(comDev, cmd);
                while (m_ReadDone == false) ;
                str = Encoding.UTF8.GetString(m_AttrReadData);
                ThreadSafeDelegate(delegate
                {
                    listAttribute.Items[idx].SubItems[0].Text = str;
                    idx++;
                });
            }
        }
    }
}