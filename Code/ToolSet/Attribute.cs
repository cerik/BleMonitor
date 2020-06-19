using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolSet
{
    class Attribute
    {
        public ushort m_AttrUserDescHandle;
        public byte[] m_AttrUUID;
        public byte   m_AttrHandle;
        public byte[] m_ParentUUID;
        public string m_ParentUserDesc;

        public Attribute()
        {
            m_AttrUUID = new byte[8];
            m_ParentUUID = new byte[8];
        }
    }
}
