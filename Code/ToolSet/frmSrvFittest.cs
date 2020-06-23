using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolSet
{
    public partial class frmSrvFittest : Form
    {
        readonly byte[] UUID_PrimSrv = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xD6, 0xC8, 0x74, 0x60 };

        readonly byte[] UUID_Activate = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x9A, 0x61, 0x74, 0x60 };
        readonly byte[] UUID_Result = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x2C, 0xAD, 0x74, 0x60 };
        readonly byte[] UUID_Attenuation = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x56, 0x91, 0x74, 0x60 };

        frmMain m_ParentFrm = null;

        private string CvtStatusToString(byte sts)
        {
            string str = string.Empty;

            switch (sts)
            {
            case 0x00:str = "Default";break;
            case 0x01:str = "Started";break;
            case 0x02:str = "Stoped";break;
            case 0x03:str = "NotReady";break;
            case 0x04:str = "Ready";break;
            default: str = "Unkown";break;
            }
            return str;
        }
        private string CvtResultToString(byte sts)
        {
            string str = string.Empty;

            switch (sts)
            {
            case 0x00: str = "Invalid"; break;
            case 0x01: str = "LNoFit,RGood"; break;
            case 0x02: str = "LNoFit,RPoor"; break;
            case 0x03: str = "RNoFit,LGood"; break;
            case 0x04: str = "RNoFit,LPoor"; break;
            case 0x05: str = "BothNoFit"; break;
            case 0x06: str = "LeftPoor"; break;
            case 0x07: str = "RightPoor"; break;
            case 0x08: str = "BothPoor"; break;
            case 0x09: str = "GoodFit";break;
            default: str = "Unkown"; break;
            }
            return str;
        }

        public frmSrvFittest()
        {
            InitializeComponent();
        }

        private void frmSrvFittest_Load(object sender, EventArgs e)
        {
            m_ParentFrm = (frmMain)this.ParentForm;
        }

        private void btFitStart_Click(object sender, EventArgs e)
        {
            UInt16 attrID;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Activate));
            if (attrID != CAttribute.InvalidHandle)
            {
                byte[] data = new byte[1] { 1 };
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
                m_ParentFrm.SendBleCmd(cmd);
            }
        }

        private void btFitStop_Click(object sender, EventArgs e)
        {
            UInt16 attrID;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Activate));
            if (attrID != CAttribute.InvalidHandle)
            {
                byte[] data = new byte[1] { 2 };
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
                m_ParentFrm.SendBleCmd(cmd);
            }
        }

        private void btFitStsGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            byte sts;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Activate));
            if (attrID != CAttribute.InvalidHandle)
            {
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientReadByHandle(m_ParentFrm.c_BleDev.ConnHandle, attrID);
                m_ParentFrm.BleDoReadAction();
                m_ParentFrm.SendBleCmd(cmd);

                while (m_ParentFrm.BleIsReadDone() == false)
                {
                    Application.DoEvents();
                    ts = DateTime.Now.Subtract(tStart);
                    if (ts.Seconds > 1) break;
                }

                if (ts.Seconds <= 1)
                {
                    sts = m_ParentFrm.c_BleDev.AttReadValue[0];
                    tbFitStatusGet.Text = CvtStatusToString(sts);
                }
            }
        }

        private void btFitAttenGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            Single lAtt, rAtt;

            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Attenuation));
            if (attrID != CAttribute.InvalidHandle)
            {
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientReadByHandle(m_ParentFrm.c_BleDev.ConnHandle, attrID);
                m_ParentFrm.BleDoReadAction();
                m_ParentFrm.SendBleCmd(cmd);

                while (m_ParentFrm.BleIsReadDone() == false)
                {
                    Application.DoEvents();
                    ts = DateTime.Now.Subtract(tStart);
                    if (ts.Seconds > 1) break;
                }

                if (ts.Seconds <= 1)
                {
                    lAtt = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 0);
                    rAtt = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 4);
                    tbFitAttenLeftGet.Text = lAtt.ToString();
                    tbFitAttenRightGet.Text = rAtt.ToString();
                }
            }
        }

        private void btFitResultGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            byte result;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Result));
            if (attrID != CAttribute.InvalidHandle)
            {
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientReadByHandle(m_ParentFrm.c_BleDev.ConnHandle, attrID);
                m_ParentFrm.BleDoReadAction();
                m_ParentFrm.SendBleCmd(cmd);

                while (m_ParentFrm.BleIsReadDone() == false)
                {
                    Application.DoEvents();
                    ts = DateTime.Now.Subtract(tStart);
                    if (ts.Seconds > 1) break;
                }

                if (ts.Seconds <= 1)
                {
                    result = m_ParentFrm.c_BleDev.AttReadValue[0];
                    tbFitResultGet.Text = CvtResultToString(result);
                }
            }
        }
    }
}
