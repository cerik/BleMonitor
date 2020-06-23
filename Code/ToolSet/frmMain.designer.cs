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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsLb_ConnSts = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsLb_ConnMac = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbRxMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProBarScan = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLabelScan = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProcessBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_File = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.srvTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitTab1_Main = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listScanDev = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRssi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMacAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAddrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btScanStart = new System.Windows.Forms.Button();
            this.splitTab1_Attr = new System.Windows.Forms.SplitContainer();
            this.tvSrvTree = new System.Windows.Forms.TreeView();
            this.tabCharacter = new System.Windows.Forms.TabControl();
            this.tabPgRW = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSetType = new System.Windows.Forms.ComboBox();
            this.cmbSetFormat = new System.Windows.Forms.ComboBox();
            this.btAttrSet = new System.Windows.Forms.Button();
            this.tbAttrSet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btStrCvt = new System.Windows.Forms.Button();
            this.tbAttrGetCvt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGetType = new System.Windows.Forms.ComboBox();
            this.cmbGetFormat = new System.Windows.Forms.ComboBox();
            this.cmbGetEndian = new System.Windows.Forms.ComboBox();
            this.tbAttrGet = new System.Windows.Forms.TextBox();
            this.btAttrGet = new System.Windows.Forms.Button();
            this.tbAttrID = new System.Windows.Forms.TextBox();
            this.tbConnID = new System.Windows.Forms.TextBox();
            this.lbAttrHandle = new System.Windows.Forms.Label();
            this.lbConnHandle = new System.Windows.Forms.Label();
            this.tabPgCalib = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btCalibMicConstRead = new System.Windows.Forms.Button();
            this.tbCalibConstOR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCalibConstOL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCalibConstIR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCalibConstIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btCalibStart = new System.Windows.Forms.Button();
            this.btCalibSetDBSPL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalibSetFreq = new System.Windows.Forms.Button();
            this.tbCalibDBSPL = new System.Windows.Forms.TextBox();
            this.tbCalibFreq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMicMaskAttrID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCalibMicGet = new System.Windows.Forms.TextBox();
            this.btCalibMicSet = new System.Windows.Forms.Button();
            this.cbCalibMicIL = new System.Windows.Forms.CheckBox();
            this.cbCalibMicOR = new System.Windows.Forms.CheckBox();
            this.cbCalibMicIR = new System.Windows.Forms.CheckBox();
            this.cbCalibMicOL = new System.Windows.Forms.CheckBox();
            this.tabTonePlay = new System.Windows.Forms.TabPage();
            this.tbTonePlayStartHandle = new System.Windows.Forms.TextBox();
            this.tbTonePlayCfgHandle = new System.Windows.Forms.TextBox();
            this.btTonePlayStop = new System.Windows.Forms.Button();
            this.btTonePlayStart = new System.Windows.Forms.Button();
            this.btTonePlaySet = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTonePlayAmp = new System.Windows.Forms.TextBox();
            this.tbTonePlayFreq = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comDev = new System.IO.Ports.SerialPort(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolCmbPort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolCmbBaudrate = new System.Windows.Forms.ToolStripComboBox();
            this.toolBtOpenCom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtDevPanel = new System.Windows.Forms.ToolStripButton();
            this.toolBtPrimSrvPanel = new System.Windows.Forms.ToolStripButton();
            this.timPeridic = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Main)).BeginInit();
            this.splitTab1_Main.Panel1.SuspendLayout();
            this.splitTab1_Main.Panel2.SuspendLayout();
            this.splitTab1_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Attr)).BeginInit();
            this.splitTab1_Attr.Panel1.SuspendLayout();
            this.splitTab1_Attr.Panel2.SuspendLayout();
            this.splitTab1_Attr.SuspendLayout();
            this.tabCharacter.SuspendLayout();
            this.tabPgRW.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPgCalib.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTonePlay.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLb_ConnSts,
            this.stsLb_ConnMac,
            this.toolStripStatusLabel1,
            this.tslbRxMsg,
            this.tsProBarScan,
            this.tsLabelScan,
            this.tsProcessBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsLb_ConnSts
            // 
            this.stsLb_ConnSts.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsLb_ConnSts.Image = global::ToolSet.Properties.Resources.BMP_GRAY;
            this.stsLb_ConnSts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stsLb_ConnSts.Name = "stsLb_ConnSts";
            this.stsLb_ConnSts.Size = new System.Drawing.Size(72, 20);
            this.stsLb_ConnSts.Text = "Connect";
            this.stsLb_ConnSts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stsLb_ConnMac
            // 
            this.stsLb_ConnMac.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsLb_ConnMac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stsLb_ConnMac.Name = "stsLb_ConnMac";
            this.stsLb_ConnMac.Size = new System.Drawing.Size(34, 20);
            this.stsLb_ConnMac.Text = "Dev:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel1.Text = "||";
            // 
            // tslbRxMsg
            // 
            this.tslbRxMsg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tslbRxMsg.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslbRxMsg.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslbRxMsg.Name = "tslbRxMsg";
            this.tslbRxMsg.Size = new System.Drawing.Size(65, 20);
            this.tslbRxMsg.Text = "tslbRxMsg";
            // 
            // tsProBarScan
            // 
            this.tsProBarScan.Name = "tsProBarScan";
            this.tsProBarScan.Size = new System.Drawing.Size(100, 19);
            // 
            // tsLabelScan
            // 
            this.tsLabelScan.Name = "tsLabelScan";
            this.tsLabelScan.Size = new System.Drawing.Size(69, 20);
            this.tsLabelScan.Text = "tsLabelScan";
            // 
            // tsProcessBar
            // 
            this.tsProcessBar.Name = "tsProcessBar";
            this.tsProcessBar.Size = new System.Drawing.Size(100, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_File,
            this.m_Edit,
            this.m_Tool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_File
            // 
            this.m_File.Name = "m_File";
            this.m_File.Size = new System.Drawing.Size(37, 20);
            this.m_File.Text = "&File";
            // 
            // m_Edit
            // 
            this.m_Edit.Name = "m_Edit";
            this.m_Edit.Size = new System.Drawing.Size(39, 20);
            this.m_Edit.Text = "&Edit";
            // 
            // m_Tool
            // 
            this.m_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srvTreeToolStripMenuItem});
            this.m_Tool.Name = "m_Tool";
            this.m_Tool.Size = new System.Drawing.Size(42, 20);
            this.m_Tool.Text = "&Tool";
            // 
            // srvTreeToolStripMenuItem
            // 
            this.srvTreeToolStripMenuItem.Name = "srvTreeToolStripMenuItem";
            this.srvTreeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.srvTreeToolStripMenuItem.Text = "SrvTree";
            this.srvTreeToolStripMenuItem.Click += new System.EventHandler(this.srvTreeToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(908, 492);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.splitTab1_Main);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // splitTab1_Main
            // 
            this.splitTab1_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitTab1_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTab1_Main.Location = new System.Drawing.Point(3, 3);
            this.splitTab1_Main.Name = "splitTab1_Main";
            // 
            // splitTab1_Main.Panel1
            // 
            this.splitTab1_Main.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitTab1_Main.Panel2
            // 
            this.splitTab1_Main.Panel2.Controls.Add(this.splitTab1_Attr);
            this.splitTab1_Main.Size = new System.Drawing.Size(894, 460);
            this.splitTab1_Main.SplitterDistance = 241;
            this.splitTab1_Main.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listScanDev);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(239, 458);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 5;
            // 
            // listScanDev
            // 
            this.listScanDev.BackColor = System.Drawing.SystemColors.Info;
            this.listScanDev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cRssi,
            this.cMacAddr,
            this.cAddrType});
            this.listScanDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScanDev.FullRowSelect = true;
            this.listScanDev.GridLines = true;
            this.listScanDev.HideSelection = false;
            this.listScanDev.Location = new System.Drawing.Point(0, 0);
            this.listScanDev.MultiSelect = false;
            this.listScanDev.Name = "listScanDev";
            this.listScanDev.ShowGroups = false;
            this.listScanDev.Size = new System.Drawing.Size(239, 324);
            this.listScanDev.TabIndex = 3;
            this.listScanDev.UseCompatibleStateImageBehavior = false;
            this.listScanDev.View = System.Windows.Forms.View.Details;
            this.listScanDev.DoubleClick += new System.EventHandler(this.listScanDev_DoubleClick);
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
            // cMacAddr
            // 
            this.cMacAddr.Text = "MacAddr";
            this.cMacAddr.Width = 120;
            // 
            // cAddrType
            // 
            this.cAddrType.Text = "AddrType";
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 23);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(239, 107);
            this.txtLog.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDisconnect);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Controls.Add(this.btScanStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 23);
            this.panel1.TabIndex = 4;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(145, 0);
            this.btDisconnect.Margin = new System.Windows.Forms.Padding(0);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(69, 23);
            this.btDisconnect.TabIndex = 4;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Image = global::ToolSet.Properties.Resources.BMP_GRAY;
            this.btConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConnect.Location = new System.Drawing.Point(77, 0);
            this.btConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(68, 23);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connect";
            this.btConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btScanStart
            // 
            this.btScanStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btScanStart.Image = global::ToolSet.Properties.Resources.BMP_GRAY;
            this.btScanStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btScanStart.Location = new System.Drawing.Point(0, 0);
            this.btScanStart.Margin = new System.Windows.Forms.Padding(0);
            this.btScanStart.Name = "btScanStart";
            this.btScanStart.Size = new System.Drawing.Size(75, 23);
            this.btScanStart.TabIndex = 1;
            this.btScanStart.Text = "StartScan";
            this.btScanStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btScanStart.UseVisualStyleBackColor = true;
            this.btScanStart.Click += new System.EventHandler(this.btScanStart_Click);
            // 
            // splitTab1_Attr
            // 
            this.splitTab1_Attr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTab1_Attr.Location = new System.Drawing.Point(0, 0);
            this.splitTab1_Attr.Name = "splitTab1_Attr";
            // 
            // splitTab1_Attr.Panel1
            // 
            this.splitTab1_Attr.Panel1.Controls.Add(this.tvSrvTree);
            // 
            // splitTab1_Attr.Panel2
            // 
            this.splitTab1_Attr.Panel2.Controls.Add(this.tabCharacter);
            this.splitTab1_Attr.Size = new System.Drawing.Size(647, 458);
            this.splitTab1_Attr.SplitterDistance = 363;
            this.splitTab1_Attr.TabIndex = 2;
            // 
            // tvSrvTree
            // 
            this.tvSrvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSrvTree.Location = new System.Drawing.Point(0, 0);
            this.tvSrvTree.Name = "tvSrvTree";
            this.tvSrvTree.Size = new System.Drawing.Size(363, 458);
            this.tvSrvTree.TabIndex = 0;
            this.tvSrvTree.Click += new System.EventHandler(this.tvSrvTree_Click);
            // 
            // tabCharacter
            // 
            this.tabCharacter.Controls.Add(this.tabPgRW);
            this.tabCharacter.Controls.Add(this.tabPgCalib);
            this.tabCharacter.Controls.Add(this.tabTonePlay);
            this.tabCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCharacter.Location = new System.Drawing.Point(0, 0);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.SelectedIndex = 0;
            this.tabCharacter.Size = new System.Drawing.Size(280, 458);
            this.tabCharacter.TabIndex = 0;
            // 
            // tabPgRW
            // 
            this.tabPgRW.Controls.Add(this.groupBox3);
            this.tabPgRW.Controls.Add(this.groupBox2);
            this.tabPgRW.Controls.Add(this.tbAttrID);
            this.tabPgRW.Controls.Add(this.tbConnID);
            this.tabPgRW.Controls.Add(this.lbAttrHandle);
            this.tabPgRW.Controls.Add(this.lbConnHandle);
            this.tabPgRW.Location = new System.Drawing.Point(4, 22);
            this.tabPgRW.Name = "tabPgRW";
            this.tabPgRW.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgRW.Size = new System.Drawing.Size(272, 432);
            this.tabPgRW.TabIndex = 0;
            this.tabPgRW.Text = "Read&Write";
            this.tabPgRW.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbSetType);
            this.groupBox3.Controls.Add(this.cmbSetFormat);
            this.groupBox3.Controls.Add(this.btAttrSet);
            this.groupBox3.Controls.Add(this.tbAttrSet);
            this.groupBox3.Location = new System.Drawing.Point(8, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 198);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Format:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Type:";
            // 
            // cmbSetType
            // 
            this.cmbSetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetType.FormattingEnabled = true;
            this.cmbSetType.Items.AddRange(new object[] {
            "Hex",
            "Number",
            "String"});
            this.cmbSetType.Location = new System.Drawing.Point(54, 66);
            this.cmbSetType.Name = "cmbSetType";
            this.cmbSetType.Size = new System.Drawing.Size(73, 21);
            this.cmbSetType.TabIndex = 14;
            // 
            // cmbSetFormat
            // 
            this.cmbSetFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetFormat.FormattingEnabled = true;
            this.cmbSetFormat.Items.AddRange(new object[] {
            "INT8",
            "UINT8",
            "INT16",
            "UINT16",
            "INT32",
            "UINT32",
            "FLOAT32"});
            this.cmbSetFormat.Location = new System.Drawing.Point(54, 93);
            this.cmbSetFormat.Name = "cmbSetFormat";
            this.cmbSetFormat.Size = new System.Drawing.Size(73, 21);
            this.cmbSetFormat.TabIndex = 15;
            // 
            // btAttrSet
            // 
            this.btAttrSet.Location = new System.Drawing.Point(190, 19);
            this.btAttrSet.Name = "btAttrSet";
            this.btAttrSet.Size = new System.Drawing.Size(45, 41);
            this.btAttrSet.TabIndex = 13;
            this.btAttrSet.Text = "Write";
            this.btAttrSet.UseVisualStyleBackColor = true;
            this.btAttrSet.Click += new System.EventHandler(this.btAttrWrite_Click);
            // 
            // tbAttrSet
            // 
            this.tbAttrSet.Location = new System.Drawing.Point(5, 19);
            this.tbAttrSet.Multiline = true;
            this.tbAttrSet.Name = "tbAttrSet";
            this.tbAttrSet.Size = new System.Drawing.Size(183, 41);
            this.tbAttrSet.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btStrCvt);
            this.groupBox2.Controls.Add(this.tbAttrGetCvt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbGetType);
            this.groupBox2.Controls.Add(this.cmbGetFormat);
            this.groupBox2.Controls.Add(this.cmbGetEndian);
            this.groupBox2.Controls.Add(this.tbAttrGet);
            this.groupBox2.Controls.Add(this.btAttrGet);
            this.groupBox2.Location = new System.Drawing.Point(8, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 156);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read";
            // 
            // btStrCvt
            // 
            this.btStrCvt.Location = new System.Drawing.Point(147, 118);
            this.btStrCvt.Name = "btStrCvt";
            this.btStrCvt.Size = new System.Drawing.Size(75, 23);
            this.btStrCvt.TabIndex = 13;
            this.btStrCvt.Text = "Convert";
            this.btStrCvt.UseVisualStyleBackColor = true;
            this.btStrCvt.Click += new System.EventHandler(this.btStrCvt_Click);
            // 
            // tbAttrGetCvt
            // 
            this.tbAttrGetCvt.Location = new System.Drawing.Point(147, 67);
            this.tbAttrGetCvt.Multiline = true;
            this.tbAttrGetCvt.Name = "tbAttrGetCvt";
            this.tbAttrGetCvt.ReadOnly = true;
            this.tbAttrGetCvt.Size = new System.Drawing.Size(87, 47);
            this.tbAttrGetCvt.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Format:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Endian:";
            // 
            // cmbGetType
            // 
            this.cmbGetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGetType.FormattingEnabled = true;
            this.cmbGetType.Items.AddRange(new object[] {
            "Hex",
            "Number",
            "String"});
            this.cmbGetType.Location = new System.Drawing.Point(54, 66);
            this.cmbGetType.Name = "cmbGetType";
            this.cmbGetType.Size = new System.Drawing.Size(73, 21);
            this.cmbGetType.TabIndex = 8;
            // 
            // cmbGetFormat
            // 
            this.cmbGetFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGetFormat.FormattingEnabled = true;
            this.cmbGetFormat.Items.AddRange(new object[] {
            "INT8",
            "UINT8",
            "INT16",
            "UINT16",
            "INT32",
            "UINT32",
            "FLOAT32",
            "MORE"});
            this.cmbGetFormat.Location = new System.Drawing.Point(54, 93);
            this.cmbGetFormat.Name = "cmbGetFormat";
            this.cmbGetFormat.Size = new System.Drawing.Size(73, 21);
            this.cmbGetFormat.TabIndex = 8;
            // 
            // cmbGetEndian
            // 
            this.cmbGetEndian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGetEndian.FormattingEnabled = true;
            this.cmbGetEndian.Items.AddRange(new object[] {
            "Little Endian",
            "Big Endian"});
            this.cmbGetEndian.Location = new System.Drawing.Point(54, 120);
            this.cmbGetEndian.Name = "cmbGetEndian";
            this.cmbGetEndian.Size = new System.Drawing.Size(73, 21);
            this.cmbGetEndian.TabIndex = 8;
            // 
            // tbAttrGet
            // 
            this.tbAttrGet.Location = new System.Drawing.Point(5, 19);
            this.tbAttrGet.Multiline = true;
            this.tbAttrGet.Name = "tbAttrGet";
            this.tbAttrGet.Size = new System.Drawing.Size(183, 41);
            this.tbAttrGet.TabIndex = 7;
            // 
            // btAttrGet
            // 
            this.btAttrGet.Location = new System.Drawing.Point(190, 19);
            this.btAttrGet.Name = "btAttrGet";
            this.btAttrGet.Size = new System.Drawing.Size(45, 41);
            this.btAttrGet.TabIndex = 6;
            this.btAttrGet.Text = "Read";
            this.btAttrGet.UseVisualStyleBackColor = true;
            this.btAttrGet.Click += new System.EventHandler(this.btAttrRead_Click);
            // 
            // tbAttrID
            // 
            this.tbAttrID.Location = new System.Drawing.Point(197, 12);
            this.tbAttrID.Name = "tbAttrID";
            this.tbAttrID.Size = new System.Drawing.Size(47, 20);
            this.tbAttrID.TabIndex = 7;
            this.tbAttrID.Text = "0";
            // 
            // tbConnID
            // 
            this.tbConnID.Location = new System.Drawing.Point(74, 13);
            this.tbConnID.Name = "tbConnID";
            this.tbConnID.Size = new System.Drawing.Size(46, 20);
            this.tbConnID.TabIndex = 7;
            this.tbConnID.Text = "0";
            // 
            // lbAttrHandle
            // 
            this.lbAttrHandle.AutoSize = true;
            this.lbAttrHandle.Location = new System.Drawing.Point(135, 16);
            this.lbAttrHandle.Name = "lbAttrHandle";
            this.lbAttrHandle.Size = new System.Drawing.Size(60, 13);
            this.lbAttrHandle.TabIndex = 5;
            this.lbAttrHandle.Text = "AttributeID:";
            // 
            // lbConnHandle
            // 
            this.lbConnHandle.AutoSize = true;
            this.lbConnHandle.Location = new System.Drawing.Point(9, 17);
            this.lbConnHandle.Name = "lbConnHandle";
            this.lbConnHandle.Size = new System.Drawing.Size(61, 13);
            this.lbConnHandle.TabIndex = 4;
            this.lbConnHandle.Text = "ConnectID:";
            // 
            // tabPgCalib
            // 
            this.tabPgCalib.Controls.Add(this.groupBox5);
            this.tabPgCalib.Controls.Add(this.groupBox4);
            this.tabPgCalib.Controls.Add(this.groupBox1);
            this.tabPgCalib.Location = new System.Drawing.Point(4, 22);
            this.tabPgCalib.Name = "tabPgCalib";
            this.tabPgCalib.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgCalib.Size = new System.Drawing.Size(272, 430);
            this.tabPgCalib.TabIndex = 1;
            this.tabPgCalib.Text = "MicCalibration";
            this.tabPgCalib.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btCalibMicConstRead);
            this.groupBox5.Controls.Add(this.tbCalibConstOR);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tbCalibConstOL);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.tbCalibConstIR);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbCalibConstIL);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(6, 268);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 129);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MicConstants";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Handle:";
            // 
            // btCalibMicConstRead
            // 
            this.btCalibMicConstRead.Location = new System.Drawing.Point(123, 21);
            this.btCalibMicConstRead.Name = "btCalibMicConstRead";
            this.btCalibMicConstRead.Size = new System.Drawing.Size(49, 23);
            this.btCalibMicConstRead.TabIndex = 2;
            this.btCalibMicConstRead.Text = "Read";
            this.btCalibMicConstRead.UseVisualStyleBackColor = true;
            // 
            // tbCalibConstOR
            // 
            this.tbCalibConstOR.Location = new System.Drawing.Point(55, 101);
            this.tbCalibConstOR.Name = "tbCalibConstOR";
            this.tbCalibConstOR.Size = new System.Drawing.Size(62, 20);
            this.tbCalibConstOR.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "OuterR:";
            // 
            // tbCalibConstOL
            // 
            this.tbCalibConstOL.Location = new System.Drawing.Point(55, 74);
            this.tbCalibConstOL.Name = "tbCalibConstOL";
            this.tbCalibConstOL.Size = new System.Drawing.Size(62, 20);
            this.tbCalibConstOL.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "OuterL:";
            // 
            // tbCalibConstIR
            // 
            this.tbCalibConstIR.Location = new System.Drawing.Point(55, 48);
            this.tbCalibConstIR.Name = "tbCalibConstIR";
            this.tbCalibConstIR.Size = new System.Drawing.Size(62, 20);
            this.tbCalibConstIR.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "InnerR:";
            // 
            // tbCalibConstIL
            // 
            this.tbCalibConstIL.Location = new System.Drawing.Point(55, 22);
            this.tbCalibConstIL.Name = "tbCalibConstIL";
            this.tbCalibConstIL.Size = new System.Drawing.Size(62, 20);
            this.tbCalibConstIL.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "InnerL:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btCalibStart);
            this.groupBox4.Controls.Add(this.btCalibSetDBSPL);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btCalibSetFreq);
            this.groupBox4.Controls.Add(this.tbCalibDBSPL);
            this.groupBox4.Controls.Add(this.tbCalibFreq);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frequency";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Handle:";
            // 
            // btCalibStart
            // 
            this.btCalibStart.Location = new System.Drawing.Point(6, 88);
            this.btCalibStart.Name = "btCalibStart";
            this.btCalibStart.Size = new System.Drawing.Size(65, 23);
            this.btCalibStart.TabIndex = 7;
            this.btCalibStart.Text = "StartCalib";
            this.btCalibStart.UseVisualStyleBackColor = true;
            // 
            // btCalibSetDBSPL
            // 
            this.btCalibSetDBSPL.Location = new System.Drawing.Point(114, 50);
            this.btCalibSetDBSPL.Name = "btCalibSetDBSPL";
            this.btCalibSetDBSPL.Size = new System.Drawing.Size(32, 23);
            this.btCalibSetDBSPL.TabIndex = 6;
            this.btCalibSetDBSPL.Text = "Set";
            this.btCalibSetDBSPL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "dBSPL:";
            // 
            // btCalibSetFreq
            // 
            this.btCalibSetFreq.Location = new System.Drawing.Point(113, 25);
            this.btCalibSetFreq.Name = "btCalibSetFreq";
            this.btCalibSetFreq.Size = new System.Drawing.Size(33, 23);
            this.btCalibSetFreq.TabIndex = 4;
            this.btCalibSetFreq.Text = "Set";
            this.btCalibSetFreq.UseVisualStyleBackColor = true;
            // 
            // tbCalibDBSPL
            // 
            this.tbCalibDBSPL.Location = new System.Drawing.Point(55, 52);
            this.tbCalibDBSPL.Name = "tbCalibDBSPL";
            this.tbCalibDBSPL.Size = new System.Drawing.Size(53, 20);
            this.tbCalibDBSPL.TabIndex = 1;
            // 
            // tbCalibFreq
            // 
            this.tbCalibFreq.Location = new System.Drawing.Point(55, 25);
            this.tbCalibFreq.Name = "tbCalibFreq";
            this.tbCalibFreq.Size = new System.Drawing.Size(53, 20);
            this.tbCalibFreq.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Freq:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMicMaskAttrID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCalibMicGet);
            this.groupBox1.Controls.Add(this.btCalibMicSet);
            this.groupBox1.Controls.Add(this.cbCalibMicIL);
            this.groupBox1.Controls.Add(this.cbCalibMicOR);
            this.groupBox1.Controls.Add(this.cbCalibMicIR);
            this.groupBox1.Controls.Add(this.cbCalibMicOL);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MIC Mask";
            // 
            // tbMicMaskAttrID
            // 
            this.tbMicMaskAttrID.Location = new System.Drawing.Point(52, 97);
            this.tbMicMaskAttrID.Name = "tbMicMaskAttrID";
            this.tbMicMaskAttrID.Size = new System.Drawing.Size(24, 20);
            this.tbMicMaskAttrID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Handle:";
            // 
            // tbCalibMicGet
            // 
            this.tbCalibMicGet.Location = new System.Drawing.Point(97, 65);
            this.tbCalibMicGet.Name = "tbCalibMicGet";
            this.tbCalibMicGet.ReadOnly = true;
            this.tbCalibMicGet.Size = new System.Drawing.Size(49, 20);
            this.tbCalibMicGet.TabIndex = 3;
            // 
            // btCalibMicSet
            // 
            this.btCalibMicSet.Location = new System.Drawing.Point(6, 62);
            this.btCalibMicSet.Name = "btCalibMicSet";
            this.btCalibMicSet.Size = new System.Drawing.Size(31, 23);
            this.btCalibMicSet.TabIndex = 2;
            this.btCalibMicSet.Text = "Set";
            this.btCalibMicSet.UseVisualStyleBackColor = true;
            this.btCalibMicSet.Click += new System.EventHandler(this.btCalibMicSet_Click);
            // 
            // cbCalibMicIL
            // 
            this.cbCalibMicIL.AutoSize = true;
            this.cbCalibMicIL.Location = new System.Drawing.Point(6, 19);
            this.cbCalibMicIL.Name = "cbCalibMicIL";
            this.cbCalibMicIL.Size = new System.Drawing.Size(68, 17);
            this.cbCalibMicIL.TabIndex = 0;
            this.cbCalibMicIL.Text = "InnerLeft";
            this.cbCalibMicIL.UseVisualStyleBackColor = true;
            // 
            // cbCalibMicOR
            // 
            this.cbCalibMicOR.AutoSize = true;
            this.cbCalibMicOR.Location = new System.Drawing.Point(82, 42);
            this.cbCalibMicOR.Name = "cbCalibMicOR";
            this.cbCalibMicOR.Size = new System.Drawing.Size(77, 17);
            this.cbCalibMicOR.TabIndex = 1;
            this.cbCalibMicOR.Text = "OuterRight";
            this.cbCalibMicOR.UseVisualStyleBackColor = true;
            // 
            // cbCalibMicIR
            // 
            this.cbCalibMicIR.AutoSize = true;
            this.cbCalibMicIR.Location = new System.Drawing.Point(80, 19);
            this.cbCalibMicIR.Name = "cbCalibMicIR";
            this.cbCalibMicIR.Size = new System.Drawing.Size(75, 17);
            this.cbCalibMicIR.TabIndex = 1;
            this.cbCalibMicIR.Text = "InnerRight";
            this.cbCalibMicIR.UseVisualStyleBackColor = true;
            // 
            // cbCalibMicOL
            // 
            this.cbCalibMicOL.AutoSize = true;
            this.cbCalibMicOL.Location = new System.Drawing.Point(6, 42);
            this.cbCalibMicOL.Name = "cbCalibMicOL";
            this.cbCalibMicOL.Size = new System.Drawing.Size(70, 17);
            this.cbCalibMicOL.TabIndex = 0;
            this.cbCalibMicOL.Text = "OuterLeft";
            this.cbCalibMicOL.UseVisualStyleBackColor = true;
            // 
            // tabTonePlay
            // 
            this.tabTonePlay.Controls.Add(this.tbTonePlayStartHandle);
            this.tabTonePlay.Controls.Add(this.tbTonePlayCfgHandle);
            this.tabTonePlay.Controls.Add(this.btTonePlayStop);
            this.tabTonePlay.Controls.Add(this.btTonePlayStart);
            this.tabTonePlay.Controls.Add(this.btTonePlaySet);
            this.tabTonePlay.Controls.Add(this.label16);
            this.tabTonePlay.Controls.Add(this.tbTonePlayAmp);
            this.tabTonePlay.Controls.Add(this.tbTonePlayFreq);
            this.tabTonePlay.Controls.Add(this.label15);
            this.tabTonePlay.Location = new System.Drawing.Point(4, 22);
            this.tabTonePlay.Name = "tabTonePlay";
            this.tabTonePlay.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonePlay.Size = new System.Drawing.Size(272, 430);
            this.tabTonePlay.TabIndex = 2;
            this.tabTonePlay.Text = "TonePlay";
            this.tabTonePlay.UseVisualStyleBackColor = true;
            // 
            // tbTonePlayStartHandle
            // 
            this.tbTonePlayStartHandle.Location = new System.Drawing.Point(103, 98);
            this.tbTonePlayStartHandle.Name = "tbTonePlayStartHandle";
            this.tbTonePlayStartHandle.Size = new System.Drawing.Size(60, 20);
            this.tbTonePlayStartHandle.TabIndex = 4;
            // 
            // tbTonePlayCfgHandle
            // 
            this.tbTonePlayCfgHandle.Location = new System.Drawing.Point(103, 54);
            this.tbTonePlayCfgHandle.Name = "tbTonePlayCfgHandle";
            this.tbTonePlayCfgHandle.Size = new System.Drawing.Size(60, 20);
            this.tbTonePlayCfgHandle.TabIndex = 4;
            // 
            // btTonePlayStop
            // 
            this.btTonePlayStop.Location = new System.Drawing.Point(36, 123);
            this.btTonePlayStop.Name = "btTonePlayStop";
            this.btTonePlayStop.Size = new System.Drawing.Size(61, 23);
            this.btTonePlayStop.TabIndex = 3;
            this.btTonePlayStop.Text = "Stop";
            this.btTonePlayStop.UseVisualStyleBackColor = true;
            this.btTonePlayStop.Click += new System.EventHandler(this.btTonePlayStop_Click);
            // 
            // btTonePlayStart
            // 
            this.btTonePlayStart.Location = new System.Drawing.Point(36, 96);
            this.btTonePlayStart.Name = "btTonePlayStart";
            this.btTonePlayStart.Size = new System.Drawing.Size(61, 23);
            this.btTonePlayStart.TabIndex = 3;
            this.btTonePlayStart.Text = "Start";
            this.btTonePlayStart.UseVisualStyleBackColor = true;
            this.btTonePlayStart.Click += new System.EventHandler(this.btTonePlayStart_Click);
            // 
            // btTonePlaySet
            // 
            this.btTonePlaySet.Location = new System.Drawing.Point(36, 51);
            this.btTonePlaySet.Name = "btTonePlaySet";
            this.btTonePlaySet.Size = new System.Drawing.Size(61, 23);
            this.btTonePlaySet.TabIndex = 3;
            this.btTonePlaySet.Text = "Set";
            this.btTonePlaySet.UseVisualStyleBackColor = true;
            this.btTonePlaySet.Click += new System.EventHandler(this.btTonePlaySet_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Amplitude(%):";
            // 
            // tbTonePlayAmp
            // 
            this.tbTonePlayAmp.Location = new System.Drawing.Point(91, 25);
            this.tbTonePlayAmp.Name = "tbTonePlayAmp";
            this.tbTonePlayAmp.Size = new System.Drawing.Size(61, 20);
            this.tbTonePlayAmp.TabIndex = 1;
            // 
            // tbTonePlayFreq
            // 
            this.tbTonePlayFreq.Location = new System.Drawing.Point(91, 0);
            this.tbTonePlayFreq.Name = "tbTonePlayFreq";
            this.tbTonePlayFreq.Size = new System.Drawing.Size(61, 20);
            this.tbTonePlayFreq.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Frequency(Hz):";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(908, 492);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(908, 517);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolCmbPort,
            this.toolStripLabel2,
            this.toolCmbBaudrate,
            this.toolBtOpenCom,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolBtDevPanel,
            this.toolBtPrimSrvPanel});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(908, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 5;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "Port:";
            // 
            // toolCmbPort
            // 
            this.toolCmbPort.AutoSize = false;
            this.toolCmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolCmbPort.DropDownWidth = 260;
            this.toolCmbPort.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolCmbPort.Name = "toolCmbPort";
            this.toolCmbPort.Size = new System.Drawing.Size(100, 23);
            this.toolCmbPort.DropDown += new System.EventHandler(this.toolCmbPort_DropDown);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel2.Text = "Baudrate:";
            // 
            // toolCmbBaudrate
            // 
            this.toolCmbBaudrate.AutoToolTip = true;
            this.toolCmbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolCmbBaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolCmbBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000",
            "512000"});
            this.toolCmbBaudrate.Name = "toolCmbBaudrate";
            this.toolCmbBaudrate.Size = new System.Drawing.Size(75, 25);
            this.toolCmbBaudrate.ToolTipText = "Baundrate";
            // 
            // toolBtOpenCom
            // 
            this.toolBtOpenCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolBtOpenCom.Image = global::ToolSet.Properties.Resources.BMP_GRAY;
            this.toolBtOpenCom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtOpenCom.Name = "toolBtOpenCom";
            this.toolBtOpenCom.Size = new System.Drawing.Size(56, 22);
            this.toolBtOpenCom.Text = "Open";
            this.toolBtOpenCom.Click += new System.EventHandler(this.toolBtOpenCom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtDevPanel
            // 
            this.toolBtDevPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtDevPanel.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.toolBtDevPanel.Image = ((System.Drawing.Image)(resources.GetObject("toolBtDevPanel.Image")));
            this.toolBtDevPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtDevPanel.Name = "toolBtDevPanel";
            this.toolBtDevPanel.Size = new System.Drawing.Size(29, 22);
            this.toolBtDevPanel.Text = "<-";
            this.toolBtDevPanel.Click += new System.EventHandler(this.toolBtDevPanel_Click);
            // 
            // toolBtPrimSrvPanel
            // 
            this.toolBtPrimSrvPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtPrimSrvPanel.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.toolBtPrimSrvPanel.Image = ((System.Drawing.Image)(resources.GetObject("toolBtPrimSrvPanel.Image")));
            this.toolBtPrimSrvPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtPrimSrvPanel.Name = "toolBtPrimSrvPanel";
            this.toolBtPrimSrvPanel.Size = new System.Drawing.Size(29, 22);
            this.toolBtPrimSrvPanel.Text = "->";
            this.toolBtPrimSrvPanel.Click += new System.EventHandler(this.toolBtPrimSrvPanel_Click);
            // 
            // timPeridic
            // 
            this.timPeridic.Tick += new System.EventHandler(this.timPeridic_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 566);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitTab1_Main.Panel1.ResumeLayout(false);
            this.splitTab1_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Main)).EndInit();
            this.splitTab1_Main.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitTab1_Attr.Panel1.ResumeLayout(false);
            this.splitTab1_Attr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Attr)).EndInit();
            this.splitTab1_Attr.ResumeLayout(false);
            this.tabCharacter.ResumeLayout(false);
            this.tabPgRW.ResumeLayout(false);
            this.tabPgRW.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPgCalib.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTonePlay.ResumeLayout(false);
            this.tabTonePlay.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_File;
        private System.Windows.Forms.ToolStripMenuItem m_Edit;
        private System.Windows.Forms.ToolStripMenuItem m_Tool;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripStatusLabel stsLb_ConnSts;
        private System.Windows.Forms.Button btScanStart;
        private System.Windows.Forms.ListView listScanDev;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cRssi;
        private System.Windows.Forms.ColumnHeader cMacAddr;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.IO.Ports.SerialPort comDev;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolCmbBaudrate;
        private System.Windows.Forms.ToolStripButton toolBtOpenCom;
        public System.Windows.Forms.ToolStripComboBox toolCmbPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitTab1_Main;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtDevPanel;
        private System.Windows.Forms.ToolStripButton toolBtPrimSrvPanel;
        private System.Windows.Forms.ToolStripStatusLabel stsLb_ConnMac;
        private System.Windows.Forms.ToolStripStatusLabel tslbRxMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitTab1_Attr;
        private System.Windows.Forms.TabControl tabCharacter;
        private System.Windows.Forms.TabPage tabPgRW;
        private System.Windows.Forms.TabPage tabPgCalib;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripProgressBar tsProBarScan;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelScan;
        private System.Windows.Forms.Timer timPeridic;
        private System.Windows.Forms.Label lbAttrHandle;
        private System.Windows.Forms.Label lbConnHandle;
        private System.Windows.Forms.Button btAttrGet;
        private System.Windows.Forms.TextBox tbAttrGet;
        private System.Windows.Forms.TextBox tbAttrID;
        private System.Windows.Forms.TextBox tbConnID;
        private System.Windows.Forms.ColumnHeader cAddrType;
        private System.Windows.Forms.CheckBox cbCalibMicOR;
        private System.Windows.Forms.CheckBox cbCalibMicOL;
        private System.Windows.Forms.CheckBox cbCalibMicIR;
        private System.Windows.Forms.CheckBox cbCalibMicIL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCalibMicSet;
        private System.Windows.Forms.TextBox tbCalibMicGet;
        private System.Windows.Forms.Button btAttrSet;
        private System.Windows.Forms.TextBox tbAttrSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMicMaskAttrID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbCalibFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalibSetFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalibSetDBSPL;
        private System.Windows.Forms.TextBox tbCalibDBSPL;
        private System.Windows.Forms.Button btCalibStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCalibConstOR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCalibConstOL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCalibConstIR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCalibConstIL;
        private System.Windows.Forms.Button btCalibMicConstRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGetEndian;
        private System.Windows.Forms.ComboBox cmbGetType;
        private System.Windows.Forms.ComboBox cmbGetFormat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSetType;
        private System.Windows.Forms.ComboBox cmbSetFormat;
        private System.Windows.Forms.TextBox tbAttrGetCvt;
        private System.Windows.Forms.Button btStrCvt;
        private System.Windows.Forms.TabPage tabTonePlay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTonePlayFreq;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTonePlayAmp;
        private System.Windows.Forms.Button btTonePlaySet;
        private System.Windows.Forms.Button btTonePlayStart;
        private System.Windows.Forms.TextBox tbTonePlayStartHandle;
        private System.Windows.Forms.TextBox tbTonePlayCfgHandle;
        private System.Windows.Forms.Button btTonePlayStop;
        private System.Windows.Forms.ToolStripMenuItem srvTreeToolStripMenuItem;
        private System.Windows.Forms.TreeView tvSrvTree;
        private System.Windows.Forms.ToolStripProgressBar tsProcessBar;
    }
}

