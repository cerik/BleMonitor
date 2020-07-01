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
        readonly byte[] UUID_Freq = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x2F, 0x99, 0x74, 0x60 };
        readonly byte[] UUID_SndLevel = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x3B, 0xD9, 0x74, 0x60 };
        readonly byte[] UUID_Response = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xA0, 0x48, 0x74, 0x60 };
        readonly byte[] UUID_Status = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xCB, 0x64, 0x74, 0x60 };
        readonly byte[] UUID_CalibConst = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x79, 0xD8, 0x74, 0x60 };
        readonly byte[] UUID_LastCalibDate = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x7B, 0x1E, 0x74, 0x60 };
        readonly byte[] UUID_NextCalibDate = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xD0, 0x06, 0x74, 0x60 };


        frmMain m_ParentFrm = null;

        private string CvtMicMaskToString(UInt16 mask)
        {
            string str = string.Empty;
            if (mask == 0)
            {
                str = "none";
            }
            else
            {
                if ((mask & 0x0001) != 0)
                {
                    str += "IL-";
                }
                if ((mask & 0x0002) != 0)
                {
                    str += "IR-";
                }
                if ((mask & 0x0004) != 0)
                {
                    str += "OL-";
                }
                if ((mask & 0x0008) != 0)
                {
                    str += "OR-";
                }
            }
            return str;
        }

        private string CvtCalibStatusToString(byte status)
        {
            string str = string.Empty;
            switch (status)
            {
            case 0x00: str = "Success"; break;
            case 0x01: str = "OutOfRange"; break;
            case 0x02: str = "WrongParam"; break;
            case 0x03: str = "Unavaliable"; break;
            case 0x04: str = "Failure"; break;
            default: str = "Unkown"; break;
            }
            return str;
        }
        private void frmSrvCalib_Load(object sender, EventArgs e)
        {
            m_ParentFrm = (frmMain)this.ParentForm;
        }

        public frmSrvCalib()
        {
            InitializeComponent();
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
                Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
                m_ParentFrm.SendBleCmd(cmd);
            }
        }

        private void btCalibMicMaskGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            UInt16 maskVal;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);


            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_MicMask));
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
                    maskVal = System.BitConverter.ToUInt16(m_ParentFrm.c_BleDev.AttReadValue, 0);

                    tbCalibMicMaskGet.Text = CvtMicMaskToString(maskVal);
                }
            }
        }

        private void btCalibSoundLevelSet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            Single level;
            byte[] data;
            string str = string.Empty;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_SndLevel));
            if (attrID == CAttribute.InvalidHandle)
            {
                return;
            }

            level = Single.Parse(tbCalibSoundLevelSet.Text);
            data = BitConverter.GetBytes(level);
            Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
            m_ParentFrm.SendBleCmd(cmd);
        }

        private void btCalibSoundLevelGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            Single level;
            string str = string.Empty;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_SndLevel));
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
                    level = System.BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 0);
                    tbCalibSoundLevelGet.Text = level.ToString();
                }
            }
        }

        private void btCalibFreqSet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            UInt32 freq;
            byte[] data;
            string str = string.Empty;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Freq));
            if (attrID == CAttribute.InvalidHandle)
            {
                return;
            }

            freq = UInt32.Parse(tbCalibFreqSet.Text);
            data = BitConverter.GetBytes(freq);
            Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
            m_ParentFrm.SendBleCmd(cmd);
        }

        private void btCalibFreqGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            UInt32 freq;
            string str = string.Empty;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);


            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Freq));
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
                    freq = System.BitConverter.ToUInt32(m_ParentFrm.c_BleDev.AttReadValue, 0);

                    tbCalibFreqGet.Text = freq.ToString();
                }
            }
        }

        private void btCalibSpkSensSet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            float leftSpk, rightSpk;
            byte[] data = new byte[8];

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_SpkSens));
            if (attrID == CAttribute.InvalidHandle)
            {
                return;
            }
            leftSpk = float.Parse(tbCalibSpkSensLeftSet.Text);
            rightSpk = float.Parse(tbCalibSpkSensRightSet.Text);

            BitConverter.GetBytes(leftSpk).CopyTo(data, 0);
            BitConverter.GetBytes(rightSpk).CopyTo(data, 4);

            Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
            m_ParentFrm.SendBleCmd(cmd);
        }

        private void btCalibSpkSensGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            Single leftSpk, rightSpk;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);


            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_SpkSens));
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
                    leftSpk = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 0);
                    rightSpk = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 4);

                    tbCalibSpkSensLeftGet.Text = leftSpk.ToString();
                    tbCalibSpkSensRightGet.Text = rightSpk.ToString();
                }
            }
        }

        private void btCalibConstGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
            Single valIL, valIR, valOL, valOR;;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);


            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_CalibConst));
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
                    valIL = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 0);
                    valIR = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 4);
                    valOL = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 8);
                    valOR = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 12);

                    tbCalibConstGetIL.Text = valIL.ToString();
                    tbCalibConstGetIR.Text = valIR.ToString();
                    tbCalibConstGetOL.Text = valOL.ToString();
                    tbCalibConstGetOR.Text = valOR.ToString();
                }
            }
        }

        private void btCalibRspGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID, micMask;
            Single sensitivity;
            byte sts;
            DateTime tStart = DateTime.Now;
            TimeSpan ts = DateTime.Now.Subtract(tStart);


            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Response));
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
                    micMask = BitConverter.ToUInt16(m_ParentFrm.c_BleDev.AttReadValue, 1);
                    sensitivity = BitConverter.ToSingle(m_ParentFrm.c_BleDev.AttReadValue, 3);

                    tbCalibRspResult.Text = CvtCalibStatusToString(sts);
                    tbCalibRspMicMask.Text = CvtMicMaskToString(micMask);
                    tbCalibRspSensitivity.Text = sensitivity.ToString();
                }
            }
        }

        private void btCalibStart_Click(object sender, EventArgs e)
        {
            UInt16 attrID;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Status));
            if (attrID == CAttribute.InvalidHandle)
            {
                return;
            }

            byte[] data = new byte[1] { 1 };
            Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
            m_ParentFrm.SendBleCmd(cmd);
        }

        private void btCalibStop_Click(object sender, EventArgs e)
        {
            UInt16 attrID;

            attrID = m_ParentFrm.c_BleDev.AttrHandleByUUID(DatConvert.ByteArrayToHexString(UUID_Status));
            if (attrID == CAttribute.InvalidHandle)
            {
                return;
            }

            byte[] data = new byte[1] { 0 };
            Byte[] cmd = m_ParentFrm.bglib.BLECommandATTClientAttributeWrite(m_ParentFrm.c_BleDev.ConnHandle, attrID, data);
            m_ParentFrm.SendBleCmd(cmd);
        }

        private void btCalibStsGet_Click(object sender, EventArgs e)
        {
            UInt16 attrID;
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
                    byte sts = m_ParentFrm.c_BleDev.AttReadValue[0];
                    if (sts != 0) tbCalibStsGet.Text = "started";
                    else tbCalibStsGet.Text = "stoped";
                }
            }
        }
    }
}
