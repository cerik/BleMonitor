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
    public partial class frmPersistent:Form
    {
        private class CPersistent
        {
            public UInt16 Key{get;set;}
            public byte[] Value{get;set;}

            public CPersistent(int len)
            {
                Value = new byte[len];
            }
            public CPersistent(UInt16 key,byte[] data)
            {
                Key = key;
                Value = new byte[data.Length];
                Array.Copy(data,Value,data.Length);
            }
        }

        frmMain m_ParentFrm = null;
        private bool m_ActionDone=true;

        List<CPersistent> m_PersistentList = new List<CPersistent>();

        public frmPersistent()
        {
            InitializeComponent();
        }

        public frmPersistent(Form parent)
        {
            if(m_ParentFrm==null) m_ParentFrm = (frmMain)parent;
            InitializeComponent();
        }

       
        void PSKeyEventHandler(object sender, Bluegiga.BLE.Events.Flash.PSKeyEventArgs e)
        {
            if(e.key == 0xFFFF)
            {
                m_ActionDone = true;
            }
            else
            {
                CPersistent per = new CPersistent(e.key,e.value);
                m_PersistentList.Add(per);
            }
        }

        private void frmPersistent_Load(object sender,EventArgs e)
        {
            if(m_ParentFrm == null)   m_ParentFrm = (frmMain)this.Tag;

            m_ParentFrm.bglib.BLEEventFlashPSKey += new Bluegiga.BLE.Events.Flash.PSKeyEventHandler(this.PSKeyEventHandler);
            m_ActionDone=false;

            timEvent.Start();
        }

        private void btDump_Click(object sender,EventArgs e)
        {
            byte [] cmd = m_ParentFrm.bglib.BLECommandFlashPSDump();

            m_ActionDone = false;
            m_PersistentList.Clear();
            m_ParentFrm.SendBleCmd(cmd);
        }

        private void timEvent_Tick(object sender,EventArgs e)
        {
            if(m_ActionDone==true)
            {
                m_ActionDone = false;
                lvPersistent.Items.Clear();
                foreach(CPersistent item in m_PersistentList)
                {
                    ListViewItem lv = new ListViewItem("0x"+item.Key.ToString("X4"));//[0];
                    lv.SubItems.Add(DatConvert.ByteArrayToHexString(item.Value));//[1]
                    lvPersistent.Items.Add(lv);
                }
                lvPersistent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void btEraseAll_Click(object sender,EventArgs e)
        {
            byte[] cmdErase = m_ParentFrm.bglib.BLECommandFlashPSEraseAll();
            m_ParentFrm.SendBleCmd(cmdErase);
            lvPersistent.Items.Clear();
        }

        private void btDelSel_Click(object sender,EventArgs e)
        {
            if(lvPersistent.SelectedItems != null && lvPersistent.SelectedItems.Count > 0)
            {
                UInt16 key = Convert.ToUInt16(lvPersistent.SelectedItems[0].SubItems[0].Text,16);
                byte[] cmdErase = m_ParentFrm.bglib.BLECommandFlashPSErase(key);
                m_ParentFrm.SendBleCmd(cmdErase);

                btDump_Click(sender,e);
            }
        }
    }

}
