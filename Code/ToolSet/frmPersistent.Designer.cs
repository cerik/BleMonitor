namespace ToolSet
{
    partial class frmPersistent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvPersistent = new System.Windows.Forms.ListView();
            this.colKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btDump = new System.Windows.Forms.Button();
            this.btDelSel = new System.Windows.Forms.Button();
            this.btEraseAll = new System.Windows.Forms.Button();
            this.timEvent = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPersistent
            // 
            this.lvPersistent.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPersistent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKey,
            this.colValue});
            this.lvPersistent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPersistent.FullRowSelect = true;
            this.lvPersistent.GridLines = true;
            this.lvPersistent.HideSelection = false;
            this.lvPersistent.LabelWrap = false;
            this.lvPersistent.Location = new System.Drawing.Point(0, 0);
            this.lvPersistent.MultiSelect = false;
            this.lvPersistent.Name = "lvPersistent";
            this.lvPersistent.ShowGroups = false;
            this.lvPersistent.Size = new System.Drawing.Size(324, 207);
            this.lvPersistent.TabIndex = 0;
            this.lvPersistent.UseCompatibleStateImageBehavior = false;
            this.lvPersistent.View = System.Windows.Forms.View.Details;
            // 
            // colKey
            // 
            this.colKey.Text = "Key";
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 227;
            // 
            // btDump
            // 
            this.btDump.Location = new System.Drawing.Point(24, 3);
            this.btDump.Name = "btDump";
            this.btDump.Size = new System.Drawing.Size(75, 23);
            this.btDump.TabIndex = 1;
            this.btDump.Text = "Dump";
            this.btDump.UseVisualStyleBackColor = true;
            this.btDump.Click += new System.EventHandler(this.btDump_Click);
            // 
            // btDelSel
            // 
            this.btDelSel.Location = new System.Drawing.Point(105, 3);
            this.btDelSel.Name = "btDelSel";
            this.btDelSel.Size = new System.Drawing.Size(75, 23);
            this.btDelSel.TabIndex = 1;
            this.btDelSel.Text = "Delete";
            this.btDelSel.UseVisualStyleBackColor = true;
            this.btDelSel.Click += new System.EventHandler(this.btDelSel_Click);
            // 
            // btEraseAll
            // 
            this.btEraseAll.Enabled = false;
            this.btEraseAll.Location = new System.Drawing.Point(186, 3);
            this.btEraseAll.Name = "btEraseAll";
            this.btEraseAll.Size = new System.Drawing.Size(75, 23);
            this.btEraseAll.TabIndex = 1;
            this.btEraseAll.Text = "EraseAll";
            this.btEraseAll.UseVisualStyleBackColor = true;
            this.btEraseAll.Click += new System.EventHandler(this.btEraseAll_Click);
            // 
            // timEvent
            // 
            this.timEvent.Tick += new System.EventHandler(this.timEvent_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvPersistent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btDump);
            this.splitContainer1.Panel2.Controls.Add(this.btEraseAll);
            this.splitContainer1.Panel2.Controls.Add(this.btDelSel);
            this.splitContainer1.Size = new System.Drawing.Size(326, 245);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 2;
            // 
            // frmPersistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 245);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersistent";
            this.Text = "Paired History Manager";
            this.Load += new System.EventHandler(this.frmPersistent_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPersistent;
        private System.Windows.Forms.Button btDump;
        private System.Windows.Forms.Button btDelSel;
        private System.Windows.Forms.Button btEraseAll;
        private System.Windows.Forms.ColumnHeader colKey;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.Timer timEvent;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}