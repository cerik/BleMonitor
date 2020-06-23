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
    public partial class frmSrvTonePlay : Form
    {
        readonly byte[] UUID_PrimSrv = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xF2, 0x49, 0x74, 0x60 };

        readonly byte[] UUID_Status = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xA1, 0xCC, 0x74, 0x60 };
        readonly byte[] UUID_Config = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xC4, 0x7B, 0x74, 0x60 };

        frmMain m_ParentFrm = null;

        private void frmSrvTonePlay_Load(object sender, EventArgs e)
        {
            m_ParentFrm = (frmMain)this.ParentForm;
        }

        public frmSrvTonePlay()
        {
            InitializeComponent();
        }

        private void btTonePlyCfgSet_Click(object sender, EventArgs e)
        {
            UInt16 attrID,freq;
            byte spl;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Config));
            if (attrID != CAttribute.InvalidHandle)
            {
                byte[] data = new byte[3];

                spl = byte.Parse(tbTonePlySplSet.Text);
                freq = UInt16.Parse(tbTonePlyFreqSet.Text);

                data[0] = spl;
                BitConverter.GetBytes(freq).CopyTo(data, 1);

                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
                m_ParentFrm.SendBleCmd(cmd);
            }
        }

        private void btTonePlyCfgGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID, freq;
            byte spl;

            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Config));
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
                    spl = m_ParentFrm.c_BleDev.AttReadValue[0];
                    freq = BitConverter.ToUInt16(m_ParentFrm.c_BleDev.AttReadValue, 1);

                    tbTonePlyFreqGet.Text = freq.ToString();
                    tbTonePlySplGet.Text = spl.ToString();
                }
            }
        }

        private void btTonePlyStsGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            byte sts;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Status));
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
                    tbTonePlyStsGet.Text = sts.ToString();
                }
            }
        }

        private void btTonePlyStart_Click(object sender, EventArgs e)
        {
            UInt16 attrID;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Status));
            if (attrID != CAttribute.InvalidHandle)
            {
                byte[] data = new byte[1] { 1 };
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
                m_ParentFrm.SendBleCmd(cmd);
            }
        }

        private void btTonePlyStop_Click(object sender, EventArgs e)
        {
            UInt16 attrID;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Status));
            if (attrID != CAttribute.InvalidHandle)
            {
                byte[] data = new byte[1] { 0 };
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
                m_ParentFrm.SendBleCmd(cmd);
            }
        }
    }
}
