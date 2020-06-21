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
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbNodeName.Text))
            {
                return;
            }
            tvSrvList.Nodes.Add(tbNodeName.Text.Trim());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNodeName.Text.Trim()))
            {
                MessageBox.Show("要添加的节点名称不能为空！");
                return;
            }
            if(tvSrvList.SelectedNode==null)
            {
                MessageBox.Show("请选择要添加子节点的节点！");
                return;
            }
            tvSrvList.SelectedNode.Nodes.Add(tbNodeName.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tvSrvList.SelectedNode == null)
            {
                MessageBox.Show("请选择要删除的节点！");
                return;
            }
            tvSrvList.SelectedNode.Remove();
        }
    }
}
