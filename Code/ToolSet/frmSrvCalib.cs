using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolSet
{
    public partial class frmSrvCalib : Form
    {
        readonly byte[] UUID_MicMask = new byte[] { 0xF7, 0x35, 0xA0, 0x8E, 0xAC, 0xEA, 0xBB, 0xA6, 0xCB, 0x4E, 0x2A, 0x50, 0x86, 0x86, 0x74, 0x60 };
        readonly byte[] UUID_SpkSens = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xF0, 0x5B, 0x74, 0x60 };
        frmMain m_ParentFrm = null;
        public frmSrvCalib()
        {
            InitializeComponent();
        }
        private void frmSrvCalib_Load(object sender, EventArgs e)
        {
            m_ParentFrm = (frmMain)this.ParentForm;
        }

        private void btCalibMicMaskSet_Click(object sender, EventArgs e)
        {
            UInt16 micMask = 0;
            UInt16 attrID;

            if (cbCalibMicIL.Checked) micMask |= 0x01;
            if (cbCalibMicIR.Checked) micMask |= 0x02;
            if (cbCalibMicOL.Checked) micMask |= 0x04;
            if (cbCalibMicOR.Checked) micMask |= 0x08;
            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_MicMask));
            if(attrID != CAttribute.InvalidHandle)
            {
                byte[] data = new byte[2] { (byte)micMask, (byte)(micMask >> 8) };
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, maskID, data);
                m_ParentFrm.SendBleCmd(cmd);
            }
        }

        private void btCalibMicMaskGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            int maskVal;

            string str = string.Empty;
            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_MicMask));
            if (attrID != CAttribute.InvalidHandle)
            {
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientReadByHandle(m_ParentFrm.c_BleDev.ConnHandle, attrID);
                m_ParentFrm.BleDoReadAction();
                m_ParentFrm.SendBleCmd(cmd);
                while (m_ParentFrm.BleIsReadDone() == false) ;
                maskVal = System.BitConverter.ToUInt16(m_ParentFrm.c_BleDev.AttReadValue, 0);

                if ((maskVal & 0x0001) != 0)
                {
                    str += "IL-";
                }
                if ((maskVal & 0x0002) != 0)
                {
                    str += "IR-";
                }
                if ((maskVal & 0x0004) != 0)
                {
                    str += "OL-";
                }
                if ((maskVal & 0x0008) != 0)
                {
                    str += "OR-";
                }
                tbCalibMicMaskGet.Text = str;
            }
        }

        private void btCalibSpkSensSet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;

            string str = string.Empty;
            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_SpkSens));
            if (attrID == CAttribute.InvalidHandle)
            {
                return;
            }
        }
    }
}
