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
    public partial class frmPairKey : Form
    {
        public UInt32 PairKey { get; set; }
        public bool PairYes { get; set; }
        public frmPairKey()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            PairKey = UInt32.Parse(tbPairKey.Text);
            PairYes = true;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            PairYes = false;
            Close();
        }
    }
}
