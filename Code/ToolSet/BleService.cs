using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolSet
{
    class CAttribute
    {
        private byte m_AttHandle = 0;
        private string m_DescStr = string.Empty;
        
        private List<byte> m_AttUUID = new List<byte>();
        private List<byte> m_SrvUUID = new List<byte>();

        public CAttribute()
        {
            m_SrvUUID.Capacity = 16;
            m_AttUUID.Capacity = 16;
        }

        public byte AttrHandle { get { return m_AttHandle; } set { m_AttHandle = value; } }
        public string Description { get { return m_DescStr; } set { m_DescStr = value; } }
        public byte[] AttrUUID { get { return m_AttUUID.ToArray(); } set { m_AttUUID.Clear(); m_AttUUID.AddRange(value); } }
        public byte[] ServiceUUID { get { return m_SrvUUID.ToArray(); } set { m_SrvUUID.AddRange(value); } }
    }

    class CPrimService
    {
        private List<byte> m_PrimUUID = new List<byte>();
        private string m_SrvDescription = string.Empty;

        List<CAttribute> m_AttrList= new List<CAttribute>();

        public byte[] UUID { get { return m_PrimUUID.ToArray(); } set { m_PrimUUID.Clear(); m_PrimUUID.AddRange(value); } }
        public string Description { get { return m_SrvDescription; } set { m_SrvDescription = value; } }

        public CPrimService()
        {
            m_PrimUUID.Capacity = 16;
        }

        public void AppendAttribute(CAttribute attrib)
        {
            m_AttrList.Add(attrib);
        }

        public void RemoveAttribute(byte[] uuid)
        {
            foreach (CAttribute item in m_AttrList.ToArray())
            {
                if (uuid.ToString() == item.AttrUUID.ToString())
                {
                    m_AttrList.Remove(item);
                }
            }
        }
        public void RemoveAttribute(byte attHandle)
        {
            foreach (CAttribute item in m_AttrList.ToArray())
            {
                if (attHandle == item.AttrHandle)
                {
                    m_AttrList.Remove(item);
                }
            }
        }
        public CAttribute GetAttribute(byte[] uuid)
        {
            CAttribute mAttribute = null;
            foreach (CAttribute item in m_AttrList.ToArray())
            {
                if (uuid.ToString() == item.AttrUUID.ToString())
                {
                    mAttribute = item;
                    break;
                }
            }
            return mAttribute;
        }

        public CAttribute GetAttribute(byte attHandle)
        {
            CAttribute mAttribute = null;
            foreach (CAttribute item in m_AttrList.ToArray())
            {
                if (attHandle == item.AttrHandle)
                {
                    mAttribute = item;
                    break;
                }
            }
            return mAttribute;
        }

        public CAttribute GetAttritubeByIndex(int idx)
        {
            if (idx >= m_AttrList.Count) return null;

            return m_AttrList[idx];
        }

        public int GetAttributeCount()
        {
            return m_AttrList.Count;
        }
     }
    class BleService
    {
        //all uuid are defined in little endian.
        //
        readonly byte[] m_DeclarePrimaryService = new byte[] { 0x00, 0x28 };
        readonly byte[] m_DeclareSecondaryService = new byte[] { 0x01, 0x28 };
        readonly byte[] m_DeclareAttribute = new byte[] { 0x03, 0x28 };

        readonly byte[] m_DescAttribute = new byte[] { 0x01, 0x29};
        readonly byte[] m_DescClientCfg = new byte[] { 0x02, 0x29 };

        readonly byte[] m_SrvGenericAccess = new byte[] { 0x00, 0x18 };
        readonly byte[] m_SrvGenericAttrib = new byte[] { 0x01, 0x18 };

        readonly byte[] m_BatteryUUID = new byte[] { 0x0F, 0x18 };
        readonly byte[] m_DevInfoUUID = new byte[] { 0x0A, 0x18 };
        readonly byte[] m_ImmALertUUID = new byte[] { 0x02, 0x18 };

        readonly byte[] m_OAD_UUID = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB0, 0x00, 0x40, 0x51, 0x04, 0xC0, 0xFF, 0x00, 0xF0 };
        readonly byte[] m_BleCertiUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x5D, 0x5E, 0x74, 0x60 };
        readonly byte[] m_CalibrationUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xC6, 0xE5, 0x74, 0x60 };
        readonly byte[] m_CurrentTimeUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xD5, 0x11, 0x74, 0x60 };
        readonly byte[] m_DBMeterUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x82, 0x6F, 0x74, 0x60 };
        readonly byte[] m_DoseUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xC1,0xC8, 0x74, 0x60 };
        readonly byte[] m_FitTestUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xD6, 0xC8, 0x74, 0x60 };
        readonly byte[] m_GainSpkUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xcc, 0x43, 0x74, 0x60 };
        readonly byte[] m_HsConfigUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x2A, 0x48, 0x74, 0x60 };
        readonly byte[] m_HearThroughUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x52, 0x02,  0x74, 0x60 };

        readonly byte[] m_McuTemperatureUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xBC, 0x04, 0x74, 0x60 };
        readonly byte[] m_SpkBalanceUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x15, 0x5F, 0x74, 0x60 };
        readonly byte[] m_SystemUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x24, 0x14, 0x74, 0x60 };
        readonly byte[] m_TestUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x69, 0xDF, 0x74, 0x60 };

        readonly byte[] m_TonePlayUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xF2, 0x49, 0x74, 0x60 };
        readonly byte[] m_VolumeKnobUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xBD, 0x9E, 0x74, 0x60 };


        List<CAttribute> m_Attr = new List<CAttribute>();

        private bool IsByteArrayEqual(byte[] arry1, byte[] arry2)
        {
            int len1, len2, idx;

            if (arry1 == null || arry2 == null) return false;
            
            len1 = arry1.Length;
            len2 = arry2.Length;
            if (len1 != len2) return false;

            for (idx = 0; idx < len1 && idx < len2; idx++)
            {
                if (arry2[idx] != arry1[idx]) return false;
            }
            return true;
        }


        public bool IsDeclarePrimaryService(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, m_DeclarePrimaryService);
        }

        public bool IsDeclareSecondaryService(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, m_DeclareSecondaryService);
        }
        public bool IsDeclareAttribute(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, m_DeclareAttribute);
        }

        public bool IsSrvGerenicAccess(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, m_SrvGenericAccess);
        }
        public bool IsSrvGenericAttribute(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, m_SrvGenericAttrib);
        }

        public bool IsDescUserAttribute(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, m_DescAttribute);
        }

        public bool IsDescClientConfig(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, m_DescClientCfg);
        }

        public string ServiceNameByUUID(byte[] uuid)
        {
            if (uuid == null) return null;

            if (IsByteArrayEqual(uuid, m_DeclarePrimaryService))
            {
                return "DeclarePrimaryService";
            }
            else if (IsByteArrayEqual(uuid, m_DeclareSecondaryService))
            {
                return "DeclareSecondaryService";
            }
            else if (IsByteArrayEqual(uuid, m_DeclareAttribute))
            {
                return "DeclareAttribute";
            }
            else if (IsByteArrayEqual(uuid, m_SrvGenericAccess))
            {
                return "GenericAccess";
            }
            else if (IsByteArrayEqual(uuid, m_SrvGenericAttrib))
            {
                return "GenericAttribute";
            }
            else if (IsByteArrayEqual(uuid, m_DescAttribute))
            {
                return "AttrUserDesc";
            }
            else if (IsByteArrayEqual(uuid, m_BatteryUUID))
            {
                return "BatteryService";
            }
            else if (IsByteArrayEqual(uuid, m_DevInfoUUID))
            {
                return "DeviceInfomation";
            }
            else if (IsByteArrayEqual(uuid, m_OAD_UUID))
            {
                return "OAD Service";
            }
            else if (IsByteArrayEqual(uuid, m_ImmALertUUID))
            {
                return "ImmediateAlert";
            }
            else if (IsByteArrayEqual(uuid, m_BleCertiUUID))
            {
                return "BleCertification";
            }
            else if (IsByteArrayEqual(uuid, m_CalibrationUUID))
            {
                return "CalibrationService";
            }
            else if (IsByteArrayEqual(uuid, m_CurrentTimeUUID))
            {
                return "CurrentTime";
            }
            else if (IsByteArrayEqual(uuid, m_DBMeterUUID))
            {
                return "DB Meter";
            }
            else if (IsByteArrayEqual(uuid, m_DoseUUID))
            {
                return "DOSE";
            }
            else if (IsByteArrayEqual(uuid, m_FitTestUUID))
            {
                return "Fit Test";
            }
            else if (IsByteArrayEqual(uuid, m_GainSpkUUID))
            {
                return "GainSpeaker";
            }
            else if (IsByteArrayEqual(uuid, m_HearThroughUUID))
            {
                return "HearThroughSwitch";
            }
            else if (IsByteArrayEqual(uuid, m_HsConfigUUID))
            {
                return "HeadsetConfig";
            }
            else if (IsByteArrayEqual(uuid, m_McuTemperatureUUID))
            {
                return "MCU Temperature";
            }
            else if (IsByteArrayEqual(uuid, m_SpkBalanceUUID))
            {
                return "Speaker Balance";
            }
            else if (IsByteArrayEqual(uuid, m_SystemUUID))
            {
                return "SystemConfig";
            }
            else if (IsByteArrayEqual(uuid, m_TestUUID))
            {
                return "Test";
            }
            else if (IsByteArrayEqual(uuid, m_TonePlayUUID))
            {
                return "TonePlay";
            }
            else if (IsByteArrayEqual(uuid, m_VolumeKnobUUID))
            {
                return "VolumeKnob";
            }
            return null;
        }
    }
}
