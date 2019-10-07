namespace ToolSet
{
    partial class frmMain
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
            if (disposing && (components != null))
            {
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbSaveLog = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOpenCom = new System.Windows.Forms.Button();
            this.picOpenCom = new System.Windows.Forms.PictureBox();
            this.cmbComStopbit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComDatabit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbComParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btConnect = new System.Windows.Forms.Button();
            this.btScanStop = new System.Windows.Forms.Button();
            this.btScanStart = new System.Windows.Forms.Button();
            this.lvScanDev = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRssi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPacketType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMacAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mAdrTye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBond = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenCom)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "tslbComCnt";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel2.Text = "tslbCanCnt";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel3.Text = "tslbLogFile";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbSaveLog);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(793, 415);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 4;
            // 
            // cbSaveLog
            // 
            this.cbSaveLog.AutoSize = true;
            this.cbSaveLog.Location = new System.Drawing.Point(3, 219);
            this.cbSaveLog.Name = "cbSaveLog";
            this.cbSaveLog.Size = new System.Drawing.Size(74, 17);
            this.cbSaveLog.TabIndex = 6;
            this.cbSaveLog.Text = "保存日志";
            this.cbSaveLog.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btOpenCom);
            this.groupBox1.Controls.Add(this.picOpenCom);
            this.groupBox1.Controls.Add(this.cmbComStopbit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbComDatabit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbComParity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbComBaud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232配置";
            // 
            // btOpenCom
            // 
            this.btOpenCom.Location = new System.Drawing.Point(67, 166);
            this.btOpenCom.Name = "btOpenCom";
            this.btOpenCom.Size = new System.Drawing.Size(75, 32);
            this.btOpenCom.TabIndex = 3;
            this.btOpenCom.Text = "打开COM";
            this.btOpenCom.UseVisualStyleBackColor = true;
            this.btOpenCom.Click += new System.EventHandler(this.btOpenCom_Click);
            // 
            // picOpenCom
            // 
            this.picOpenCom.ErrorImage = global::ToolSet.Properties.Resources.BMP_RED;
            this.picOpenCom.InitialImage = global::ToolSet.Properties.Resources.BMP_GRAY;
            this.picOpenCom.Location = new System.Drawing.Point(47, 175);
            this.picOpenCom.Name = "picOpenCom";
            this.picOpenCom.Size = new System.Drawing.Size(14, 14);
            this.picOpenCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOpenCom.TabIndex = 2;
            this.picOpenCom.TabStop = false;
            // 
            // cmbComStopbit
            // 
            this.cmbComStopbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComStopbit.FormattingEnabled = true;
            this.cmbComStopbit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmbComStopbit.Location = new System.Drawing.Point(64, 135);
            this.cmbComStopbit.Name = "cmbComStopbit";
            this.cmbComStopbit.Size = new System.Drawing.Size(79, 21);
            this.cmbComStopbit.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "停止位";
            // 
            // cmbComDatabit
            // 
            this.cmbComDatabit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComDatabit.FormattingEnabled = true;
            this.cmbComDatabit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cmbComDatabit.Location = new System.Drawing.Point(64, 108);
            this.cmbComDatabit.Name = "cmbComDatabit";
            this.cmbComDatabit.Size = new System.Drawing.Size(79, 21);
            this.cmbComDatabit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据位";
            // 
            // cmbComParity
            // 
            this.cmbComParity.DisplayMember = "2";
            this.cmbComParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComParity.FormattingEnabled = true;
            this.cmbComParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cmbComParity.Location = new System.Drawing.Point(64, 81);
            this.cmbComParity.Name = "cmbComParity";
            this.cmbComParity.Size = new System.Drawing.Size(79, 21);
            this.cmbComParity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "校验位";
            // 
            // cmbComBaud
            // 
            this.cmbComBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComBaud.FormattingEnabled = true;
            this.cmbComBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbComBaud.Location = new System.Drawing.Point(64, 54);
            this.cmbComBaud.Name = "cmbComBaud";
            this.cmbComBaud.Size = new System.Drawing.Size(79, 21);
            this.cmbComBaud.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(64, 27);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(79, 21);
            this.cmbComPort.Sorted = true;
            this.cmbComPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lvScanDev);
            this.tabPage1.Controls.Add(this.txtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDisconnect);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Controls.Add(this.btScanStop);
            this.panel1.Controls.Add(this.btScanStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 244);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 23);
            this.panel1.TabIndex = 4;
            // 
            // btConnect
            // 
            this.btConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btConnect.Location = new System.Drawing.Point(150, 0);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btScanStop
            // 
            this.btScanStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btScanStop.Location = new System.Drawing.Point(75, 0);
            this.btScanStop.Name = "btScanStop";
            this.btScanStop.Size = new System.Drawing.Size(75, 23);
            this.btScanStop.TabIndex = 2;
            this.btScanStop.Text = "StopScan";
            this.btScanStop.UseVisualStyleBackColor = true;
            this.btScanStop.Click += new System.EventHandler(this.btScanStop_Click);
            // 
            // btScanStart
            // 
            this.btScanStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btScanStart.Location = new System.Drawing.Point(0, 0);
            this.btScanStart.Name = "btScanStart";
            this.btScanStart.Size = new System.Drawing.Size(75, 23);
            this.btScanStart.TabIndex = 1;
            this.btScanStart.Text = "StartScan";
            this.btScanStart.UseVisualStyleBackColor = true;
            this.btScanStart.Click += new System.EventHandler(this.btScanStart_Click);
            // 
            // lvScanDev
            // 
            this.lvScanDev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cRssi,
            this.cPacketType,
            this.cMacAddr,
            this.mAdrTye,
            this.cBond});
            this.lvScanDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScanDev.Location = new System.Drawing.Point(3, 3);
            this.lvScanDev.Name = "lvScanDev";
            this.lvScanDev.Size = new System.Drawing.Size(605, 264);
            this.lvScanDev.TabIndex = 3;
            this.lvScanDev.UseCompatibleStateImageBehavior = false;
            this.lvScanDev.View = System.Windows.Forms.View.Details;
            this.lvScanDev.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvScanDev_ItemSelectionChanged);
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 100;
            // 
            // cRssi
            // 
            this.cRssi.Text = "RSSI";
            // 
            // cPacketType
            // 
            this.cPacketType.Text = "PacketType";
            // 
            // cMacAddr
            // 
            this.cMacAddr.Text = "MacAddress";
            this.cMacAddr.Width = 120;
            // 
            // mAdrTye
            // 
            this.mAdrTye.Text = "AddressType";
            // 
            // cBond
            // 
            this.cBond.Text = "Bond";
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(3, 267);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(605, 119);
            this.txtLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(231, 0);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btDisconnect.TabIndex = 4;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 486);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenCom)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOpenCom;
        private System.Windows.Forms.PictureBox picOpenCom;
        private System.Windows.Forms.ComboBox cmbComStopbit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbComDatabit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbComParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbComBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSaveLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btScanStart;
        private System.Windows.Forms.Button btScanStop;
        private System.Windows.Forms.ListView lvScanDev;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cRssi;
        private System.Windows.Forms.ColumnHeader cPacketType;
        private System.Windows.Forms.ColumnHeader cMacAddr;
        private System.Windows.Forms.ColumnHeader cBond;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ColumnHeader mAdrTye;
        private System.Windows.Forms.Button btDisconnect;
    }
}

