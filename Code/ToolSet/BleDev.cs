using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolSet
{
    public class CAttribute
    {
        public static readonly byte InvalidHandle = 0xFF;

        public CAttribute()
        {
            AttHandle = 0xFF;
        }

        public ushort UserDescHandle { get; set; }
        public ushort AttHandle { get; set; }
        public string AttName { get; set; }
        public string AttUUID { get; set; }
        public string SrvUUID { get; set; }
        public string AttType { get; set; }
    }

    public class CPrimService
    {
        public List<CAttribute> AttrList = new List<CAttribute>();

        public string UUID { get; set; }
        public string Description { get; set; }
        public ushort Start { get; set; }
        public ushort End { get;  set; }

        public bool AttScanDone { get; set; }


        public CPrimService()
        {
            Description = string.Empty;
            UUID = string.Empty;
            AttScanDone = false;
        }
        public CPrimService(string uuid,string name)
        {
            AttScanDone = false;
            Description = name;
            UUID = uuid;
        }

        public CPrimService(byte[] uuid, string name)
        {
            string uuidstr = DatConvert.ByteArrayToDecString(uuid);
            Description = name;
            UUID = uuidstr;
            AttScanDone = false;
        }

        public void Reset()
        {
            UUID = string.Empty;
            Description = string.Empty;
            AttrList.Clear();
            AttScanDone = false;
        }
        public void AddAttribute(CAttribute attrib)
        {
            AttrList.Add(attrib);
        }
        public CAttribute AddAttribute(string parentUUID, string attrUUID, string attrName, ushort attrHandle)
        {
            CAttribute mAttr = new CAttribute();
            mAttr.AttUUID = attrUUID;
            mAttr.SrvUUID = parentUUID;
            mAttr.AttHandle = attrHandle;
            mAttr.AttName = attrName;
            AddAttribute(mAttr);
            return mAttr;
        }
        public void DelAttribute(byte[] uuid)
        {
            string uuidstr = DatConvert.HexArrayToString(uuid);
            foreach (CAttribute item in AttrList.ToArray())
            {
                if (uuidstr == item.AttUUID)
                {
                    AttrList.Remove(item);
                }
            }
        }
        public void DelAttribute(string uuid)
        {
            foreach (CAttribute item in AttrList.ToArray())
            {
                if (uuid == item.AttUUID)
                {
                    AttrList.Remove(item);
                }
            }
        }
        public void DelAttribute(byte attHandle)
        {
            foreach (CAttribute item in AttrList.ToArray())
            {
                if (attHandle == item.AttHandle)
                {
                    AttrList.Remove(item);
                }
            }
        }
        public CAttribute GetAttribute(byte[] uuid)
        {
            CAttribute mAttribute = null;
            string uuidstr = DatConvert.HexArrayToString(uuid);
            foreach (CAttribute item in AttrList.ToArray())
            {
                if (uuidstr == item.AttUUID)
                {
                    mAttribute = item;
                    break;
                }
            }
            return mAttribute;
        }
        public CAttribute GetAttribute(string uuid)
        {
            CAttribute mAttribute = null;
            foreach (CAttribute item in AttrList.ToArray())
            {
                if (uuid == item.AttUUID)
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
            foreach (CAttribute item in AttrList.ToArray())
            {
                if (attHandle == item.AttHandle)
                {
                    mAttribute = item;
                    break;
                }
            }
            return mAttribute;
        }
        public ushort GetAttributeHandle(byte[] uuid)
        {
            CAttribute mAttribute= GetAttribute(uuid);
            if (mAttribute != null) return mAttribute.AttHandle;
            else return 0xFF;
        }
        public ushort GetAttributeHandle(string uuid)
        {
            CAttribute mAttribute = GetAttribute(uuid);
            if (mAttribute != null) return mAttribute.AttHandle;
            else return 0xFF;
        }
        public CAttribute GetAttritubeAt(int idx)
        {
            if (idx >= AttrList.Count) return null;

            return AttrList[idx];
        }
        public int GetAttributeCount()
        {
            return AttrList.Count;
        }
        public bool IsAttributeExists(string uuid)
        {
            CAttribute mAttribute = GetAttribute(uuid);
            if (mAttribute == null) return false;
            else return true;
        }
        public bool IsAttributeExists(byte attHandle)
        {
            CAttribute mAttribute = GetAttribute(attHandle);
            if (mAttribute == null) return false;
            else return true;
        }
     }
    public class GhpBle
    {
        //all uuid are defined in little endian.
        //
        #region UUID_DEF
        public static readonly byte[] DeclarePrimaryService = new byte[] { 0x00, 0x28 };
        public static readonly byte[] DeclareSecondaryService = new byte[] { 0x01, 0x28 };
        public static readonly byte[] DeclareAttribute = new byte[] { 0x03, 0x28 };

        public static readonly byte[] DescAttribute = new byte[] { 0x01, 0x29 };
        public static readonly byte[] DescClientCfg = new byte[] { 0x02, 0x29 };

        public static readonly byte[] SrvGenericAccess = new byte[] { 0x00, 0x18 };
        public static readonly byte[] SrvGenericAttrib = new byte[] { 0x01, 0x18 };

        public static readonly byte[] BatteryUUID = new byte[] { 0x0F, 0x18 };
        public static readonly byte[] DevInfoUUID = new byte[] { 0x0A, 0x18 };
        public static readonly byte[] ImmALertUUID = new byte[] { 0x02, 0x18 };

        public static readonly byte[] OAD_UUID = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB0, 0x00, 0x40, 0x51, 0x04, 0xC0, 0xFF, 0x00, 0xF0 };
        public static readonly byte[] BleCertiUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x5D, 0x5E, 0x74, 0x60 };
        public static readonly byte[] CalibrationUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xC6, 0xE5, 0x74, 0x60 };
        public static readonly byte[] CurrentTimeUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xD5, 0x11, 0x74, 0x60 };
        public static readonly byte[] DBMeterUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x82, 0x6F, 0x74, 0x60 };
        public static readonly byte[] DoseUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xC1, 0xC8, 0x74, 0x60 };
        public static readonly byte[] FitTestUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xD6, 0xC8, 0x74, 0x60 };
        public static readonly byte[] GainSpkUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xcc, 0x43, 0x74, 0x60 };
        public static readonly byte[] HsConfigUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x2A, 0x48, 0x74, 0x60 };
        public static readonly byte[] HearThroughUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x52, 0x02, 0x74, 0x60 };

        public static readonly byte[] McuTemperatureUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xBC, 0x04, 0x74, 0x60 };
        public static readonly byte[] SpkBalanceUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x15, 0x5F, 0x74, 0x60 };
        public static readonly byte[] SystemUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x24, 0x14, 0x74, 0x60 };
        public static readonly byte[] TestUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0x69, 0xDF, 0x74, 0x60 };

        public static readonly byte[] TonePlayUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xF2, 0x49, 0x74, 0x60 };
        public static readonly byte[] VolumeKnobUUID = new byte[] { 0xf7, 0x35, 0xa0, 0x8e, 0xac, 0xea, 0xbb, 0xa6, 0xcb, 0x4e, 0x2a, 0x50, 0xBD, 0x9E, 0x74, 0x60 };
        #endregion

        public const byte ACTTION_IDLE = 0;
        public const byte ACTTION_SCAN_PRIMSRV = 1;
        public const byte ACTTION_SCAN_PRIMSRV_DONE = 2;
        public const byte ACTTION_SCAN_ATTRIB = 3;
        public const byte ACTTION_SCAN_ATTRIB_DONE = 4;
        public const byte ACTTION_ATTR_READ = 5;
        public const byte ACTIONN_ATTR_READ_DONE = 6;
        public const byte ACTTION_ATTR_WRITE = 7;

        //
        //Member
        //
        //
        #region ClassMember
        public List<CPrimService> m_PrimSrvList = new List<CPrimService>();

        #endregion

        #region Interface
        public CPrimService CurrentPrimSrv { get; set;}
        public byte[] AttReadValue { get; set; }
        public byte AttReadType { get; set; }
        public bool AttReadDone { get; set; }

        public byte State { get; set; }
        public int RSSI { get; set; }
        public byte AddrType { get; set; }
        public byte ConnHandle { get; set; }
        public string MacAddr { get; set; }
        public string DevName { get; set; }
        public bool Busy { get; set; }
        public byte Bonding { get; set; }
        public GhpBle()
        {
            ConnHandle = CAttribute.InvalidHandle;
            MacAddr = string.Empty;
            DevName = string.Empty;
            RSSI = 0;
            AddrType = 0;

            m_PrimSrvList.Clear();
            CurrentPrimSrv = null;
            AttReadValue = null;
            Busy = false;
            AttReadDone = false;
        }

        public void Reset()
        {
            ConnHandle = CAttribute.InvalidHandle;
            MacAddr = string.Empty;
            DevName = string.Empty;
            RSSI = 0;
            AddrType = 0;

            m_PrimSrvList.Clear();
            CurrentPrimSrv = null;
            AttReadValue = null;
            Busy = false;
            AttReadDone = false;
        }

        public int GetPrimSrvIndex(string uuidstr)
        {
            return m_PrimSrvList.FindIndex(CPrimService=> CPrimService.UUID==uuidstr);
        }
        public void PrimSrvAdd(string uuidstr, ushort start, ushort end)
        {
            string name = ServiceNameByUUID(uuidstr);
            CPrimService mSrv = new CPrimService(uuidstr,name);
            mSrv.Start = start;
            mSrv.End = end;
            m_PrimSrvList.Add(mSrv);
        }
        public void PrimSrvAdd(byte[] uuid,ushort start,ushort end)
        {
            string uuidstr = DatConvert.ByteArrayToHexString(uuid);
            PrimSrvAdd(uuidstr,start,end);
        }
        public void PrimSrvDel(string uuidstr)
        {
            foreach (CPrimService item in m_PrimSrvList)
            {
                if (item.UUID == uuidstr)
                {
                    m_PrimSrvList.Remove(item);
                    break;
                }
            }
        }
        public CPrimService GetPrimSrv(string uuidstr)
        {
            CPrimService mSrv=null;
            foreach (CPrimService item in m_PrimSrvList)
            {
                if (uuidstr == item.UUID)
                {
                    mSrv = item;
                    break;
                }
            }
            return mSrv;
        }
        public CPrimService GetPrimSrv(byte[] uuid)
        {
            string uuidstr = DatConvert.ByteArrayToHexString(uuid);
            return GetPrimSrv(uuidstr);
        }
        public CPrimService GetPrimSrv(int index)
        {
            return m_PrimSrvList[index];
        }

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
            return IsByteArrayEqual(uuid, DeclarePrimaryService);
        }

        public bool IsDeclareSecondaryService(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, DeclareSecondaryService);
        }
        public bool IsDeclareAttribute(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, DeclareAttribute);
        }

        public bool IsSrvGerenicAccess(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, SrvGenericAccess);
        }
        public bool IsSrvGenericAttribute(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, SrvGenericAttrib);
        }

        public bool IsDescUserAttribute(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, DescAttribute);
        }

        public bool IsDescClientConfig(byte[] uuid)
        {
            return IsByteArrayEqual(uuid, DescClientCfg);
        }

        public string ServiceNameByUUID(byte[] uuid)
        {
            if (uuid == null) return null;

            if (IsByteArrayEqual(uuid, DeclarePrimaryService))
            {
                return "DeclarePrimaryService";
            }
            else if (IsByteArrayEqual(uuid, DeclareSecondaryService))
            {
                return "DeclareSecondaryService";
            }
            else if (IsByteArrayEqual(uuid, DeclareAttribute))
            {
                return "DeclareAttribute";
            }
            else if (IsByteArrayEqual(uuid, SrvGenericAccess))
            {
                return "GenericAccess";
            }
            else if (IsByteArrayEqual(uuid, SrvGenericAttrib))
            {
                return "GenericAttribute";
            }
            else if (IsByteArrayEqual(uuid, DescAttribute))
            {
                return "AttrUserDesc";
            }
            else if (IsByteArrayEqual(uuid, BatteryUUID))
            {
                return "BatteryService";
            }
            else if (IsByteArrayEqual(uuid, DevInfoUUID))
            {
                return "DeviceInfomation";
            }
            else if (IsByteArrayEqual(uuid, OAD_UUID))
            {
                return "OAD Service";
            }
            else if (IsByteArrayEqual(uuid, ImmALertUUID))
            {
                return "ImmediateAlert";
            }
            else if (IsByteArrayEqual(uuid, BleCertiUUID))
            {
                return "BleCertification";
            }
            else if (IsByteArrayEqual(uuid, CalibrationUUID))
            {
                return "CalibrationService";
            }
            else if (IsByteArrayEqual(uuid, CurrentTimeUUID))
            {
                return "CurrentTime";
            }
            else if (IsByteArrayEqual(uuid, DBMeterUUID))
            {
                return "DB Meter";
            }
            else if (IsByteArrayEqual(uuid, DoseUUID))
            {
                return "DOSE";
            }
            else if (IsByteArrayEqual(uuid, FitTestUUID))
            {
                return "Fit Test";
            }
            else if (IsByteArrayEqual(uuid, GainSpkUUID))
            {
                return "GainSpeaker";
            }
            else if (IsByteArrayEqual(uuid, HearThroughUUID))
            {
                return "HearThroughSwitch";
            }
            else if (IsByteArrayEqual(uuid, HsConfigUUID))
            {
                return "HeadsetConfig";
            }
            else if (IsByteArrayEqual(uuid, McuTemperatureUUID))
            {
                return "MCU Temperature";
            }
            else if (IsByteArrayEqual(uuid, SpkBalanceUUID))
            {
                return "Speaker Balance";
            }
            else if (IsByteArrayEqual(uuid, SystemUUID))
            {
                return "SystemConfig";
            }
            else if (IsByteArrayEqual(uuid, TestUUID))
            {
                return "Test";
            }
            else if (IsByteArrayEqual(uuid, TonePlayUUID))
            {
                return "TonePlay";
            }
            else if (IsByteArrayEqual(uuid, VolumeKnobUUID))
            {
                return "VolumeKnob";
            }
            return null;
        }
        public string ServiceNameByUUID(string uuidstr)
        {
            byte[] uuid = DatConvert.strToHexByte(uuidstr);
            return ServiceNameByUUID(uuid);
        }

        public string AttrUuidByHandle(ushort handleid)
        {
            string uuidstr = string.Empty;
            foreach (CPrimService srv in m_PrimSrvList)
            {
                foreach (CAttribute attr in srv.AttrList)
                {
                    if (attr.AttHandle == handleid)
                    {
                        uuidstr = attr.AttUUID;
                        break;
                    }
                }
            }
            return uuidstr;
        }
        public ushort AttrHandleByUUID(string uuidstr)
        {
            ushort handle = 0xFF;
            foreach (CPrimService srv in m_PrimSrvList)
            {
                foreach (CAttribute attr in srv.AttrList)
                {
                    if (attr.AttUUID == uuidstr)
                    {
                        handle = attr.AttHandle;
                        break;
                    }
                }
            }
            return handle;
        }
        
        #endregion
    }

}
