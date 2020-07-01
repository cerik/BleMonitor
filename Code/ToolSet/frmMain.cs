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
    public partial class frmMain : Form
    {
        public readonly string[] AttrType = { "Read", "Notify", "Indicate", "ReadByType", "ReadBlob", "IndicateRspReq" };

        /* ================================================================ */
        /*                BEGIN MAIN EVENT-DRIVEN APP LOGIC                 */
        /* ================================================================ */
        private Dictionary<string, string> portDict = new Dictionary<string, string>();
        private Thread m_ScanThread = null;

        public Bluegiga.BGLib bglib = new Bluegiga.BGLib();
        public GhpBle c_BleDev = new GhpBle();
        

        #region
        private frmSrvCalib m_FrmSrvCalib = new frmSrvCalib();
        private frmSrvTonePlay mFrmSrvTonePly = new frmSrvTonePlay();
        private frmSrvDose mFrmSrvDose = new frmSrvDose();
        private frmSrvFittest mFrmSrvFittest = new frmSrvFittest();
        private frmPairKey mFrmPairKey = new frmPairKey();
        
        #endregion

        #region BleEventCallback
        public void EventProcedureCompleted(object sender, Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventArgs e)
        {
            c_BleDev.Busy = false;
#if false
            if(c_BleDev.State == GhpBle.ACTIION_ATTR_PAIR_CHECK)
            {
                switch(e.result)
                {
                case 0x040F:
                case 0x0405:
                case 0x0408:
                     c_BleDev.NeedPair = true;
                     break;
                default:
                    c_BleDev.NeedPair = false;
                    break;
                }
            }
#endif
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
        public void EventDevScanResponse(object sender, Bluegiga.BLE.Events.GAP.ScanResponseEventArgs e)
        {
            string mName = "(NoName)";

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
            string macaddr = DatConvert.ByteArrayToHexString(e.sender);
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
                    lvS.SubItems[2].Text = DatConvert.ByteArrayToHexString(e.sender);
                }
                else
                {
                    ListViewItem lv = new ListViewItem(mName);//[0];
                    lv.SubItems.Add(rssi.ToString());//[1]
                    lv.SubItems.Add(DatConvert.ByteArrayToHexString(e.sender));//[2]
                    lv.SubItems[2].Tag = e.bond;
                    if (e.address_type==1) lv.SubItems.Add("Random");//[3]
                    else lv.SubItems.Add("Public");//[3]
                    lv.SubItems.Add(e.bond.ToString());//[4]
                    lv.SubItems.Add(e.packet_type.ToString());//[4];
                    

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
        public void EventConnectStatus(object sender, Bluegiga.BLE.Events.Connection.StatusEventArgs e)
        {
            if (comDev.IsOpen == false) return;

            //flags:
            //bit.0 = connection_connected; the connection exists to a remote device.
            //bit.1 = connection_encrypted; the connection is encrypted.
            //bit.2 = connection_completed flag, which is used to tell a new connection has been created.
            //bit.3 = connection_parameters_change; the connection parameters have changed and. It is set when connection parameters have changed due to a link layer operation.
            if ((e.flags & 0x05) !=0)
            {
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate
                {
                    splitTab1_Main.Panel1Collapsed = true;
                    splitTab1_Main.Panel2Collapsed = false;
                    btConnect.Image = Properties.Resources.BMP_GREEN;
                    stsLb_ConnSts.Image = Properties.Resources.BMP_GREEN;
                });

                // "find primary service" UUID is 0x2800 (little-endian for UUID uint8array)
                //Byte[] cmd = bglib.BLECommandATTClientReadByGroupType(e.connection, 0x0001, 0xFFFF, new Byte[] { 0x00, 0x28 });
                // bglib.SendCommand(comDev, cmd);

                // connected, now perform service discovery
                c_BleDev.ConnHandle = e.connection;
                c_BleDev.MacAddr = e.address.ToString();
                c_BleDev.AddrType = e.address_type;
                c_BleDev.State = GhpBle.ACTTION_SCAN_PRIMSRV;
                c_BleDev.Bonding = e.bonding;

                //if(e.bonding == 0xFF)
                //{ 
                //     byte[] cmd2 = bglib.BLECommandSMEncryptStart(e.connection, 1);
                //    bglib.SendCommand(comDev, cmd2);
                //}
            }
        }

        public void EventDisconnect(object sender, Bluegiga.BLE.Events.Connection.DisconnectedEventArgs e)
        {
        }

        //This event is produced when an attributed group(a service) is found. Typically this event is produced after Read by Group Type command.
        //Data Feild:
        // [4] = uint8, connection; Connection handle;
        // [5~6] = uint16,start; Starting handle;
        // [7~8] = uint16,end; Ending handle; 'end' is a reserved word and in BGScrpit so 'end' conn't be used as such.
        // [9..] = uint8array, uuid; UUID os a service; Length is 0 if no service are found.
        public void EventGroupFound(object sender, Bluegiga.BLE.Events.ATTClient.GroupFoundEventArgs e)
        {
            if(!c_BleDev.IsSrvGerenicAccess(e.uuid) && !c_BleDev.IsSrvGenericAttribute(e.uuid))
            {
                c_BleDev.PrimSrvAdd(e.uuid,e.start,e.end);
            }
        }

        //
        //查找子服务的应答事件,从中提取子服务内容;
        //
        public void EventFindInformationFound(object sender, Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventArgs e)
        {
            //ThreadSafeDelegate(delegate { txtLog.AppendText(log); });
            if (e.connection == c_BleDev.ConnHandle)
            {
                if (c_BleDev.IsDeclarePrimaryService(e.uuid))//e.uuid.SequenceEqual(new Byte[] { 0x00, 0x28 }))
                {
                }
                else if (c_BleDev.IsDeclareAttribute(e.uuid))//e.uuid.SequenceEqual(new Byte[] { 0x03, 0x28 }))
                {
                }
                else if (c_BleDev.IsDescClientConfig(e.uuid))
                {//ClientCharacteristicConfiguration
                }
                else if (c_BleDev.IsDescUserAttribute(e.uuid))
                {//Characteristic User Description
                    if (c_BleDev.CurrentPrimSrv.AttrList.Count > 0)
                    {
                        c_BleDev.CurrentPrimSrv.AttrList[c_BleDev.CurrentPrimSrv.AttrList.Count - 1].UserDescHandle = e.chrhandle;
                    }
                        
                }
                else
                {//charactestic attribute
                    if(c_BleDev.CurrentPrimSrv != null)
                    {
                        c_BleDev.CurrentPrimSrv.AddAttribute(c_BleDev.CurrentPrimSrv.UUID, DatConvert.ByteArrayToHexString(e.uuid), "",e.chrhandle);
                    }
                }
            }
        }

        public void EventReadAttributeValue(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
        {
            // check for a new value from the connected peripheral's heart rate measurement attribute
            if (e.connection == c_BleDev.ConnHandle)// && e.atthandle == gChrHandle)
            {
                c_BleDev.AttReadDone = true;
                c_BleDev.AttReadValue = e.value;
                c_BleDev.AttReadType = e.type;
            }
        }

        public void EventBondStatusEventHandler(object sender, Bluegiga.BLE.Events.SM.BondStatusEventArgs e)
        {
            //MessageBox.Show(e.bond.ToString(), "tBondStatus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            c_BleDev.Paired = true;
        }
        public void EventPasskeyRequestEventHandler(object sender, Bluegiga.BLE.Events.SM.PasskeyRequestEventArgs e)
        {
            mFrmPairKey.ShowDialog();
        }
        public void EventPasskeyDisplayEventHandler(object sender, Bluegiga.BLE.Events.SM.PasskeyDisplayEventArgs e)
        {
            //MessageBox.Show(e.handle.ToString(), "PasskeyDisplay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        public void EventBondingFailEventHandler(object sender, Bluegiga.BLE.Events.SM.BondingFailEventArgs e)
        {
        }

        public void ResponseEncryptStartEventHandler(object sender, Bluegiga.BLE.Responses.SM.EncryptStartEventArgs e)
        {
            if(e.result == 0)
            { 
                //byte[] cmd = bglib.BLECommandSMEncryptStart(e.connection, 1);
                //bglib.SendCommand(comDev, cmd);
            }
        }

        #endregion

        //Attribute read response event
        ////response data:
        //  [4~5] : uint16, handle; handle of the attribute which was read;
        //  [6~7] : uint16, offset; Offset read from;
        //  [8~9] : uint16, result; 0: the read was successfull; Non-zero:An error occurred.
        //  [10..]: uint8array; value; maximum of 32 bytes can be read at a time.

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
        private void ScanThread()
        {
            DateTime mTimStart=DateTime.Now;
            while (true)
            {
                switch (c_BleDev.State)
                {
                case GhpBle.ACTTION_IDLE:
                    Thread.Sleep(50);
                    break;
#if false
                case GhpBle.ACTIION_ATTR_PAIR_CHECK:
                    {
                        mTimStart = DateTime.Now;
                        while (c_BleDev.Busy)
                        {
                            TimeSpan mTimDif = DateTime.Now.Subtract(mTimStart);
                            if(mTimDif.Seconds>3) break;
                        }
                        c_BleDev.Busy = true;
                        byte[] cmd = bglib.BLECommandATTClientReadByType(c_BleDev.ConnHandle, 0x0001, 0xFFFF, new byte[] { 0x03, 0x28 });
                        bglib.SendCommand(comDev, cmd);

                        mTimStart = DateTime.Now;
                        while (c_BleDev.Busy)
                        {
                            TimeSpan mTimDif = DateTime.Now.Subtract(mTimStart);
                            if (mTimDif.Seconds > 3) break;
                        }
                        if(c_BleDev.NeedPair )
                        {
                            if(c_BleDev.Paired == false)
                            {
                                c_BleDev.Busy = true;
                                byte[] cmd2 = bglib.BLECommandSMEncryptStart(c_BleDev.ConnHandle, 1);
                                bglib.SendCommand(comDev, cmd2);

                                mTimStart = DateTime.Now;
                                while (c_BleDev.Paired == false) 
                                {
                                    TimeSpan mTimDif = DateTime.Now.Subtract(mTimStart);
                                    if (mTimDif.Seconds > 3) break;
                                }
                            }
                            else
                            {
                                c_BleDev.State = GhpBle.ACTIONN_ATTR_PAIR_DONE;
                            }
                        }
                        else
                        {
                            c_BleDev.State = GhpBle.ACTIONN_ATTR_PAIR_DONE;
                        }
                    }
                    break;
                case GhpBle.ACTIONN_ATTR_PAIR_DONE:
                    if(c_BleDev.NeedPair && c_BleDev.Paired)
                    {
                        c_BleDev.State = GhpBle.ACTTION_SCAN_PRIMSRV;
                    }
                    break;
#endif
                case GhpBle.ACTTION_SCAN_PRIMSRV:
                    {
                        c_BleDev.Busy = true;
                        Byte[] cmd = bglib.BLECommandATTClientReadByGroupType(c_BleDev.ConnHandle, 0x0001, 0xFFFF, new Byte[] { 0x00, 0x28 });
                        bglib.SendCommand(comDev, cmd);

                        mTimStart = DateTime.Now;
                        while (c_BleDev.Busy)
                        {
                            TimeSpan mTimDif = DateTime.Now.Subtract(mTimStart);
                            if (mTimDif.Seconds > 10) break;
                        }
                        c_BleDev.State = GhpBle.ACTTION_SCAN_PRIMSRV_DONE;
                    }
                    break;
                case GhpBle.ACTTION_SCAN_PRIMSRV_DONE:
                        break;
                case GhpBle.ACTTION_SCAN_ATTRIB:
                    if(c_BleDev.CurrentPrimSrv != null)
                    {
                        if(c_BleDev.CurrentPrimSrv.AttScanDone == false)
                        {
                            //
                            //scan all attribute first.
                            //
                            c_BleDev.Busy = true;
                            Byte[] cmd = bglib.BLECommandATTClientFindInformation(c_BleDev.ConnHandle, c_BleDev.CurrentPrimSrv.Start, c_BleDev.CurrentPrimSrv.End);
                            bglib.SendCommand(comDev, cmd);

                            mTimStart = DateTime.Now;
                            while (c_BleDev.Busy)
                            {
                                TimeSpan mTimDif = DateTime.Now.Subtract(mTimStart);
                                if (mTimDif.Seconds > 20) break;
                            }

                            //
                            //Now read user description of each attribute;
                            //
                            foreach(CAttribute attr in c_BleDev.CurrentPrimSrv.AttrList)
                            {
                                c_BleDev.Busy = true;
                                c_BleDev.AttReadDone = false;
                                cmd = bglib.BLECommandATTClientReadByHandle(c_BleDev.ConnHandle, attr.UserDescHandle);
                                bglib.SendCommand(comDev, cmd);
                                while (c_BleDev.Busy && c_BleDev.AttReadDone==false)
                                {
                                }
                                if (c_BleDev.AttReadDone == true)
                                {
                                    attr.AttName = Encoding.UTF8.GetString(c_BleDev.AttReadValue);
                                }
                            }
                            c_BleDev.CurrentPrimSrv.AttScanDone = true;
                        }
                    }
                    c_BleDev.State = GhpBle.ACTTION_SCAN_ATTRIB_DONE;
                    break;
                case GhpBle.ACTTION_SCAN_ATTRIB_DONE:
                    break;
                case GhpBle.ACTTION_ATTR_READ:
                    while (c_BleDev.Busy == false && c_BleDev.AttReadDone == false) ;
                    c_BleDev.State = GhpBle.ACTIONN_ATTR_READ_DONE;
                    break;
                case GhpBle.ACTIONN_ATTR_READ_DONE:
                    break;
                case GhpBle.ACTTION_ATTR_WRITE:
                    break;
                default:
                    break;
                }
            }
        }

        public void BleDoReadAction()
        {
            c_BleDev.Busy = true;
            c_BleDev.AttReadDone = false;
        }
        public bool BleIsReadDone()
        {
            if (c_BleDev.Busy == false || c_BleDev.AttReadDone == true) return true;
            else return false;
        }
        public void BleStateClear()
        {
            c_BleDev.State = GhpBle.ACTTION_IDLE;
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


        public void SendBleCmd(byte[] dat)
        {
            if(comDev.IsOpen==false)
            {
                MessageBox.Show("Com port is not opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bglib.SendCommand(comDev, dat);
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
            bglib.BLEEventGAPScanResponse += new Bluegiga.BLE.Events.GAP.ScanResponseEventHandler(this.EventDevScanResponse);

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
            bglib.BLEEventConnectionStatus += new Bluegiga.BLE.Events.Connection.StatusEventHandler(this.EventConnectStatus);

            bglib.BLEEventConnectionDisconnected += new Bluegiga.BLE.Events.Connection.DisconnectedEventHandler(this.EventDisconnect);


            //查找一级服务
            //This event is produced when an attributed group(a service) is found. Typically this event is produced after Read by Group Type command.
            //Data Feild:
            // [4] = uint8, connection; Connection handle;
            // [5~6] = uint16,start; Starting handle;
            // [7~8] = uint16,end; Ending handle; 'end' is a reserved word and in BGScrpit so 'end' conn't be used as such.
            // [9..] = uint8array, uuid; UUID os a service; Length is 0 if no service are found.
            bglib.BLEEventATTClientGroupFound += new Bluegiga.BLE.Events.ATTClient.GroupFoundEventHandler(this.EventGroupFound);

            //查找二级服务
            //bglib.BLEResponseATTClientReadByType += new Bluegiga.BLE.Responses.ATTClient.ReadByTypeEventHandler(ATTClientReadByTypeEvent);

            //This event is generated when characteristics type mappings are found. This happens typically after Find Information command
            //has been issued to discover all attributes of a service.
            bglib.BLEEventATTClientFindInformationFound += new Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventHandler(this.EventFindInformationFound);

            //attribute write comeplete event. 
            //This event is produced ata the GATT client when an attribute protocol event is completed a and new operation can be issued.
            //
            //This event is for example produced after an Attribute Write command is successfully used to write a value to a remote device.
            bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(this.EventProcedureCompleted);

            //This event is produced at the GATT client side when an attribute value is passed from the GATT server to the 
            //GATT client. This event is for example produced after a successfull Read by Handle operation or when an attribute 
            //is indicated or notified by the remote device.
            bglib.BLEEventATTClientAttributeValue += new Bluegiga.BLE.Events.ATTClient.AttributeValueEventHandler(this.EventReadAttributeValue);

            bglib.BLEEventSMBondStatus += new Bluegiga.BLE.Events.SM.BondStatusEventHandler(this.EventBondStatusEventHandler);
            bglib.BLEEventSMPasskeyDisplay += new Bluegiga.BLE.Events.SM.PasskeyDisplayEventHandler(this.EventPasskeyDisplayEventHandler);
            bglib.BLEEventSMPasskeyRequest += new Bluegiga.BLE.Events.SM.PasskeyRequestEventHandler(this.EventPasskeyRequestEventHandler);
            bglib.BLEEventSMBondingFail += new Bluegiga.BLE.Events.SM.BondingFailEventHandler(this.EventBondingFailEventHandler);

            //Attribute read response event
            ////response data:
            //  [4~5] : uint16, handle; handle of the attribute which was read;
            //  [6~7] : uint16, offset; Offset read from;
            //  [8~9] : uint16, result; 0: the read was successfull; Non-zero:An error occurred.
            //  [10..]: uint8array; value; maximum of 32 bytes can be read at a time.
            //bglib.BLEResponseAttributesRead += new Bluegiga.BLE.Responses.Attributes.ReadEventHandler(this.AttributesReadResponseEvent);

            bglib.BLEResponseSMEncryptStart += new Bluegiga.BLE.Responses.SM.EncryptStartEventHandler(this.ResponseEncryptStartEventHandler);
            
            
            //Indicated --attclient
            //This event is produced at the GATT server side when an attribute is successfully indicated to the GATT client.
            //This means the event is only produced at the GATT server if the indication is acknowledged by the GATT client(the removte device).

            splitTab1_Main.Panel2Collapsed = true;
            splitTab1_Main.Panel1Collapsed = false;

            SetEnableByComSts(false);

            m_ScanThread = new Thread(new ThreadStart(ScanThread));
            m_ScanThread.IsBackground = true;
            m_ScanThread.Start();
            //
            cmbGetEndian.SelectedIndex = 0;
            cmbGetFormat.SelectedIndex = 0;
            cmbGetType.SelectedIndex = 0;
            cmbSetFormat.SelectedIndex = 0;
            cmbSetType.SelectedIndex = 0;

            //
            //add each controm form into tag page;
            //
            m_FrmSrvCalib.TopLevel = false;
            pgCalib.Controls.Add(m_FrmSrvCalib);
            m_FrmSrvCalib.Show();

            mFrmSrvTonePly.TopLevel = false;
            pgTonePlay.Controls.Add(mFrmSrvTonePly);
            mFrmSrvTonePly.Show();

            mFrmSrvDose.TopLevel = false;
            pgDose.Controls.Add(mFrmSrvDose); 
            mFrmSrvDose.Show();

            mFrmSrvFittest.TopLevel = false;
            pgFittest.Controls.Add(mFrmSrvFittest);
            mFrmSrvFittest.Show();
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

                byte[] cmd1 = bglib.BLECommandSMSetBondableMode(1);
                bglib.SendCommand(comDev, cmd1);
                byte[] cmd2 = bglib.BLECommandSMSetParameters(1, 7, 2);//Keyboard Only
                bglib.SendCommand(comDev, cmd2);
                byte[] cmd3 = bglib.BLECommandSMWhitelistBonds();
                bglib.SendCommand(comDev,cmd3);
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

        private void tbtDirectLeft_Click(object sender, EventArgs e)
        {
            byte tag = byte.Parse(tbtDirectLeft.Tag.ToString());
            tbtDirectRight.Tag = 0;
            if (tag == 0)
            {
                splitTab1_Main.Panel1Collapsed = false;
                tag = 1;
            }
            else if (tag == 1)
            {
                tag = 0;
                splitTab1_Main.Panel2Collapsed = true;
            }
            tbtDirectLeft.Tag = tag;
        }

        private void tbtDirectRight_Click(object sender, EventArgs e)
        {
            byte tag = byte.Parse(tbtDirectRight.Tag.ToString());
            tbtDirectLeft.Tag = 0;

            if (tag == 0)
            {
                splitTab1_Main.Panel2Collapsed = false;
                tag = 1;
            }
            else if (tag == 1)
            {
                tag = 0;
                splitTab1_Main.Panel1Collapsed = true;
            }
            tbtDirectRight.Tag = tag;
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

            // DEBUG: display bytes read
            // parse all bytes read through BGLib parser
            for (int i = 0; i < ReDatas.Length; i++)
            {
                bglib.Parse(ReDatas[i]);
            }
            //实现数据的解码与显示
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
            btConnect.Image = Properties.Resources.BMP_GRAY;
            stsLb_ConnSts.Image = Properties.Resources.BMP_GRAY;
            bglib.SendCommand(comDev, bglib.BLECommandConnectionDisconnect(c_BleDev.ConnHandle));
        }
        
        private void btConnect_Click(object sender, EventArgs e)
        {
            listScanDev_DoubleClick(sender, e);
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

        private void timPeridic_Tick(object sender, EventArgs e)
        {
            if (bglib.IsBusy()) tsLabelScan.Text = "Busy";
            else tsLabelScan.Text = "Ready";

            if (mFrmPairKey.PairYes)
            {
                byte[] cmd = bglib.BLECommandSMPasskeyEntry(c_BleDev.ConnHandle, mFrmPairKey.PairKey);
                bglib.SendCommand(comDev, cmd);
                mFrmPairKey.PairYes = false;
            }
            switch (c_BleDev.State)
            {
            case GhpBle.ACTTION_IDLE:
                tsProcessBar.Value = 0;
                break;
            case GhpBle.ACTTION_SCAN_PRIMSRV:
                tsProcessBar.Value = (tsProcessBar.Value + 20) % 120;
                break;
            case GhpBle.ACTTION_SCAN_PRIMSRV_DONE://服务项扫描完毕,添加到树表中;
                { 
                    tsProcessBar.Value = 100;
                    tvSrvTree.Nodes.Clear();
                    foreach (CPrimService srv in c_BleDev.m_PrimSrvList)
                    {
                        TreeNode srvNode = new TreeNode();
                        if (srv.Description == null) srvNode.Text = srv.UUID;
                        else srvNode.Text = srv.Description;
                        srvNode.Tag = srv.UUID;
                        srvNode.ToolTipText = "UUID= "+srv.UUID;
                        tvSrvTree.Nodes.Add(srvNode);
                    }
                    c_BleDev.State = GhpBle.ACTTION_IDLE;
                }
                break;
            case GhpBle.ACTTION_SCAN_ATTRIB:
                tsProcessBar.Value = (tsProcessBar.Value + 20) % 120;
                break;
            case GhpBle.ACTTION_SCAN_ATTRIB_DONE://添加属性列表
                { 
                    tsProcessBar.Value = 100;
                    if (tvSrvTree.SelectedNode != null && tvSrvTree.SelectedNode.Level == 0)
                    {
                        if (tvSrvTree.SelectedNode.Nodes.Count == 0)
                        {
                            foreach (CAttribute attr in c_BleDev.CurrentPrimSrv.AttrList)
                            {
                                TreeNode attNode = new TreeNode();
                                if (attr.AttName == null) attNode.Text = attr.AttUUID;
                                else attNode.Text = attr.AttName;
                                attNode.Tag = attr.AttUUID;
                                attNode.ToolTipText = "UUID= " + attr.AttUUID;
                                tvSrvTree.SelectedNode.Nodes.Add(attNode);
                            }
                        }
                    }
                    c_BleDev.State = GhpBle.ACTTION_IDLE;
                }
                break;
            }
        }

        private void listScanDev_DoubleClick(object sender, EventArgs e)
        {
            if (comDev.IsOpen == false)
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listScanDev.SelectedIndices != null && listScanDev.SelectedItems.Count > 0)
            {
                c_BleDev.Reset();
                c_BleDev.MacAddr = listScanDev.SelectedItems[0].SubItems[2].Text;
                if(listScanDev.SelectedItems[0].SubItems[3].Text == "Random") c_BleDev.AddrType = 1;
                else c_BleDev.AddrType = 0;
                c_BleDev.DevName = listScanDev.SelectedItems[0].SubItems[0].Text;

                stsLb_ConnSts.Text = listScanDev.SelectedItems[0].SubItems[0].Text;
                stsLb_ConnMac.Text = "MacAddr=" + listScanDev.SelectedItems[0].SubItems[2].Text;

                Byte[] cmd = bglib.BLECommandGAPConnectDirect(DatConvert.strToHexByte(c_BleDev.MacAddr), c_BleDev.AddrType, 0x20, 0x30, 0x100, 0);
                bglib.SendCommand(comDev, cmd);// 125ms interval, 125ms window, active scanning
                tvSrvTree.Nodes.Clear();
            }
        }
        private void tvSrvTree_DoubleClick(object sender, EventArgs e)
        {
            if (tvSrvTree.SelectedNode == null)
            {
                return;
            }
            if (tvSrvTree.SelectedNode.Level != 0)
            {
                return;
            }
            if (tvSrvTree.SelectedNode.Nodes.Count > 0)
            {
                return;
            }
            foreach (CPrimService srv in c_BleDev.m_PrimSrvList)
            {
                if (srv.UUID == tvSrvTree.SelectedNode.Tag.ToString())
                {
                    c_BleDev.CurrentPrimSrv = srv;
                    break;
                }
            }
            if (c_BleDev.CurrentPrimSrv != null)
            {
                c_BleDev.State = GhpBle.ACTTION_SCAN_ATTRIB;
            }
        }

        private void btAttrRead_Click(object sender, EventArgs e)
        {
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);

            if (comDev.IsOpen == false)
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (c_BleDev.ConnHandle == CAttribute.InvalidHandle) return;
            if (tvSrvTree.SelectedNode.Level != 1) return;

            string uuidstr = (string)tvSrvTree.SelectedNode.Tag;
            ushort attrID=c_BleDev.AttrHandleByUUID(uuidstr);
            if (attrID == CAttribute.InvalidHandle) return;
  
            Byte[] cmd = bglib.BLECommandATTClientReadByHandle(c_BleDev.ConnHandle, attrID);
            BleDoReadAction();
            SendBleCmd(cmd);
            while (BleIsReadDone() == false)
            {
                Application.DoEvents();
                ts = DateTime.Now.Subtract(tStart);
                if (ts.Seconds > 1) break;
            }

            if(ts.Seconds<=1)
            { 
                tbAttrGet.Text = DatConvert.ByteArrayToHexString(c_BleDev.AttReadValue);
                btStrCvt_Click(sender, e);
            }
        }
        private void btAttrWrite_Click(object sender, EventArgs e)
        {
            if (comDev.IsOpen == false)
            {
                MessageBox.Show("请先打开串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (c_BleDev.ConnHandle == CAttribute.InvalidHandle) return;
            if (tvSrvTree.SelectedNode.Level != 1) return;

            string uuidstr = (string)tvSrvTree.SelectedNode.Tag;
            ushort attrID = c_BleDev.AttrHandleByUUID(uuidstr);
            if (attrID == CAttribute.InvalidHandle) return;

            
            List<byte> byteList = new List<byte>();
            switch (cmbSetType.SelectedIndex)
            {
            case 0://hex
                {
                    byte[] v = DatConvert.strToHexByte(tbAttrSet.Text);
                    byteList.AddRange(v);
                }
                break;
            case 1://Number
                switch (cmbSetFormat.SelectedIndex)
                {
                case 0://I8
                case 1://U8
                    byteList.Add(byte.Parse(tbAttrSet.Text));
                    break;
                case 2://I16
                    {
                        Int16 val = Int16.Parse(tbAttrSet.Text);
                        byte[] b = BitConverter.GetBytes(val);
                        byteList.AddRange(b);
                    }
                    break;
                case 3://U16
                    {
                        UInt16 val = UInt16.Parse(tbAttrSet.Text);
                        byte[] b = BitConverter.GetBytes(val);
                        byteList.AddRange(b);
                    }
                    break;
                case 4://I32
                    {
                        Int32 val = Int32.Parse(tbAttrSet.Text);
                        byte[] b = BitConverter.GetBytes(val);
                        byteList.AddRange(b);
                    }
                    break;
                case 5://U32
                    {
                        UInt32 val = UInt32.Parse(tbAttrSet.Text);
                        byte[] b = BitConverter.GetBytes(val);
                        byteList.AddRange(b);
                    }
                    break;
                case 6://F32
                    {
                        float val = float.Parse(tbAttrSet.Text);
                        byte[] b = BitConverter.GetBytes(val);
                        byteList.AddRange(b);
                    }
                    break;
                default:
                    break;
                }
                break;
            case 2://String
                {
                    byte[] v = System.Text.Encoding.Default.GetBytes(tbAttrSet.Text);
                    byteList.AddRange(v);
                }
                break;
            }
            Byte[] cmd = bglib.BLECommandATTClientAttributeWrite(c_BleDev.ConnHandle, attrID, byteList.ToArray());
            bglib.SendCommand(comDev, cmd);
        }

        private void btStrCvt_Click(object sender, EventArgs e)
        {
            byte[] hexDat = DatConvert.strToHexByte(tbAttrGet.Text);
            switch (cmbGetType.SelectedIndex)
            {
            case 0://Hex
                tbAttrGetCvt.Text = DatConvert.ByteArrayToHexString(hexDat);
                break;
            case 1://Number
                {
                    if (cmbGetEndian.SelectedIndex == 1)
                    {
                        Array.Reverse(hexDat);
                    }
                    switch (cmbGetFormat.SelectedIndex)
                    {
                    case 0://INT8
                    case 1://UINT8
                        tbAttrGetCvt.Text = BitConverter.ToChar(hexDat, 0).ToString();
                        break;
                    case 2://INT16;
                        tbAttrGetCvt.Text = BitConverter.ToInt16(hexDat, 0).ToString();//Int16.Parse(tbAttrGet.Text).ToString();
                        break;
                    case 3://UINT16
                        tbAttrGetCvt.Text = BitConverter.ToUInt16(hexDat, 0).ToString();// UInt16.Parse(tbAttrGet.Text).ToString();
                        //tbAttrGet.Text = ByteArrayToDecString(e.value);
                        break;
                    case 4://INT32;
                        tbAttrGetCvt.Text = BitConverter.ToInt32(hexDat, 0).ToString();
                        break;
                    case 5://UINT32;
                        tbAttrGetCvt.Text = BitConverter.ToUInt32(hexDat, 0).ToString();
                        break;
                    case 6://float
                        tbAttrGetCvt.Text = BitConverter.ToSingle(hexDat, 0).ToString();
                        break;
                    default:
                        break;
                    }
                }
                break;
            case 2://String
                tbAttrGetCvt.Text = DatConvert.HexArrayToString(hexDat);
                break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void toolBtPair_Click(object sender, EventArgs e)
        {
            c_BleDev.Busy = true;
            byte[] cmd2 = bglib.BLECommandSMEncryptStart(c_BleDev.ConnHandle, 1);
            bglib.SendCommand(comDev, cmd2);
        }

        private void toolBtKeyMgr_Click(object sender,EventArgs e)
        {
            frmPersistent mFrmKeyMgr = new frmPersistent(this);
            mFrmKeyMgr.Show(this);
        }
    }
}