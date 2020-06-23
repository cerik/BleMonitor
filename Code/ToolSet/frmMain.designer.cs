﻿namespace ToolSet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btScanStart = new System.Windows.Forms.Button();
            this.splitTab1_Attr = new System.Windows.Forms.SplitContainer();
            this.tvSrvTree = new System.Windows.Forms.TreeView();
            this.tabAttr = new System.Windows.Forms.TabControl();
            this.pgRW = new System.Windows.Forms.TabPage();
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
            this.pgCalib = new System.Windows.Forms.TabPage();
            this.pgTonePlay = new System.Windows.Forms.TabPage();
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
            this.tbtDirectLeft = new System.Windows.Forms.ToolStripButton();
            this.tbtDirectRight = new System.Windows.Forms.ToolStripButton();
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
            this.tabAttr.SuspendLayout();
            this.pgRW.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pgTonePlay.SuspendLayout();
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
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(239, 458);
            this.splitContainer1.SplitterDistance = 425;
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
            this.listScanDev.Size = new System.Drawing.Size(239, 425);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btDisconnect);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Controls.Add(this.btScanStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 23);
            this.panel1.TabIndex = 4;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(170, -1);
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
            this.btConnect.Location = new System.Drawing.Point(91, 0);
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
            this.splitTab1_Attr.Panel2.Controls.Add(this.tabAttr);
            this.splitTab1_Attr.Size = new System.Drawing.Size(647, 458);
            this.splitTab1_Attr.SplitterDistance = 232;
            this.splitTab1_Attr.TabIndex = 2;
            // 
            // tvSrvTree
            // 
            this.tvSrvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSrvTree.Location = new System.Drawing.Point(0, 0);
            this.tvSrvTree.Name = "tvSrvTree";
            this.tvSrvTree.ShowNodeToolTips = true;
            this.tvSrvTree.Size = new System.Drawing.Size(232, 458);
            this.tvSrvTree.TabIndex = 0;
            this.tvSrvTree.DoubleClick += new System.EventHandler(this.tvSrvTree_DoubleClick);
            // 
            // tabAttr
            // 
            this.tabAttr.Controls.Add(this.pgRW);
            this.tabAttr.Controls.Add(this.pgCalib);
            this.tabAttr.Controls.Add(this.pgTonePlay);
            this.tabAttr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAttr.Location = new System.Drawing.Point(0, 0);
            this.tabAttr.Name = "tabAttr";
            this.tabAttr.SelectedIndex = 0;
            this.tabAttr.Size = new System.Drawing.Size(411, 458);
            this.tabAttr.TabIndex = 0;
            // 
            // pgRW
            // 
            this.pgRW.Controls.Add(this.groupBox3);
            this.pgRW.Controls.Add(this.groupBox2);
            this.pgRW.Controls.Add(this.tbAttrID);
            this.pgRW.Controls.Add(this.tbConnID);
            this.pgRW.Controls.Add(this.lbAttrHandle);
            this.pgRW.Controls.Add(this.lbConnHandle);
            this.pgRW.Location = new System.Drawing.Point(4, 22);
            this.pgRW.Name = "pgRW";
            this.pgRW.Padding = new System.Windows.Forms.Padding(3);
            this.pgRW.Size = new System.Drawing.Size(403, 432);
            this.pgRW.TabIndex = 0;
            this.pgRW.Text = "Read&Write";
            this.pgRW.UseVisualStyleBackColor = true;
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
            // pgCalib
            // 
            this.pgCalib.Location = new System.Drawing.Point(4, 22);
            this.pgCalib.Name = "pgCalib";
            this.pgCalib.Padding = new System.Windows.Forms.Padding(3);
            this.pgCalib.Size = new System.Drawing.Size(403, 432);
            this.pgCalib.TabIndex = 1;
            this.pgCalib.Text = "MicCalibration";
            this.pgCalib.UseVisualStyleBackColor = true;
            // 
            // pgTonePlay
            // 
            this.pgTonePlay.Controls.Add(this.tbTonePlayStartHandle);
            this.pgTonePlay.Controls.Add(this.tbTonePlayCfgHandle);
            this.pgTonePlay.Controls.Add(this.btTonePlayStop);
            this.pgTonePlay.Controls.Add(this.btTonePlayStart);
            this.pgTonePlay.Controls.Add(this.btTonePlaySet);
            this.pgTonePlay.Controls.Add(this.label16);
            this.pgTonePlay.Controls.Add(this.tbTonePlayAmp);
            this.pgTonePlay.Controls.Add(this.tbTonePlayFreq);
            this.pgTonePlay.Controls.Add(this.label15);
            this.pgTonePlay.Location = new System.Drawing.Point(4, 22);
            this.pgTonePlay.Name = "pgTonePlay";
            this.pgTonePlay.Padding = new System.Windows.Forms.Padding(3);
            this.pgTonePlay.Size = new System.Drawing.Size(403, 430);
            this.pgTonePlay.TabIndex = 2;
            this.pgTonePlay.Text = "TonePlay";
            this.pgTonePlay.UseVisualStyleBackColor = true;
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
            this.tbtDirectLeft,
            this.tbtDirectRight});
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
            // tbtDirectLeft
            // 
            this.tbtDirectLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtDirectLeft.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.tbtDirectLeft.Image = ((System.Drawing.Image)(resources.GetObject("tbtDirectLeft.Image")));
            this.tbtDirectLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtDirectLeft.Name = "tbtDirectLeft";
            this.tbtDirectLeft.Size = new System.Drawing.Size(29, 22);
            this.tbtDirectLeft.Tag = "0";
            this.tbtDirectLeft.Text = "<-";
            this.tbtDirectLeft.Click += new System.EventHandler(this.tbtDirectLeft_Click);
            // 
            // tbtDirectRight
            // 
            this.tbtDirectRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtDirectRight.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.tbtDirectRight.Image = ((System.Drawing.Image)(resources.GetObject("tbtDirectRight.Image")));
            this.tbtDirectRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtDirectRight.Name = "tbtDirectRight";
            this.tbtDirectRight.Size = new System.Drawing.Size(29, 22);
            this.tbtDirectRight.Tag = "0";
            this.tbtDirectRight.Text = "->";
            this.tbtDirectRight.Click += new System.EventHandler(this.tbtDirectRight_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitTab1_Attr.Panel1.ResumeLayout(false);
            this.splitTab1_Attr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Attr)).EndInit();
            this.splitTab1_Attr.ResumeLayout(false);
            this.tabAttr.ResumeLayout(false);
            this.pgRW.ResumeLayout(false);
            this.pgRW.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pgTonePlay.ResumeLayout(false);
            this.pgTonePlay.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tbtDirectLeft;
        private System.Windows.Forms.ToolStripButton tbtDirectRight;
        private System.Windows.Forms.ToolStripStatusLabel stsLb_ConnMac;
        private System.Windows.Forms.ToolStripStatusLabel tslbRxMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitTab1_Attr;
        private System.Windows.Forms.TabControl tabAttr;
        private System.Windows.Forms.TabPage pgRW;
        private System.Windows.Forms.TabPage pgCalib;
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
        private System.Windows.Forms.Button btAttrSet;
        private System.Windows.Forms.TextBox tbAttrSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TabPage pgTonePlay;
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

