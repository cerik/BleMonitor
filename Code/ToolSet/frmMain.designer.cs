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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_File = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitTab1_Main = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btScanStart = new System.Windows.Forms.Button();
            this.listScanDev = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRssi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPacketType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMacAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mAdrTye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBond = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitTab1_Sub = new System.Windows.Forms.SplitContainer();
            this.listPrimSrv = new System.Windows.Forms.ListView();
            this.psrvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psrvStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psrvEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psrvUUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psrvCharCnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAttribute = new System.Windows.Forms.ListView();
            this.attrConnHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attrHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attrValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLog = new System.Windows.Forms.TextBox();
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
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Main)).BeginInit();
            this.splitTab1_Main.Panel1.SuspendLayout();
            this.splitTab1_Main.Panel2.SuspendLayout();
            this.splitTab1_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Sub)).BeginInit();
            this.splitTab1_Sub.Panel1.SuspendLayout();
            this.splitTab1_Sub.Panel2.SuspendLayout();
            this.splitTab1_Sub.SuspendLayout();
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
            this.tslbRxMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 25);
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
            this.stsLb_ConnSts.Size = new System.Drawing.Size(67, 20);
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(15, 20);
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
            this.tslbRxMsg.Size = new System.Drawing.Size(60, 20);
            this.tslbRxMsg.Text = "tslbRxMsg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_File,
            this.m_Edit,
            this.m_Tool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_File
            // 
            this.m_File.Name = "m_File";
            this.m_File.Size = new System.Drawing.Size(35, 20);
            this.m_File.Text = "&File";
            // 
            // m_Edit
            // 
            this.m_Edit.Name = "m_Edit";
            this.m_Edit.Size = new System.Drawing.Size(37, 20);
            this.m_Edit.Text = "&Edit";
            // 
            // m_Tool
            // 
            this.m_Tool.Name = "m_Tool";
            this.m_Tool.Size = new System.Drawing.Size(39, 20);
            this.m_Tool.Text = "&Tool";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(891, 469);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.splitTab1_Main);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 443);
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
            this.splitTab1_Main.Panel1.Controls.Add(this.panel1);
            this.splitTab1_Main.Panel1.Controls.Add(this.listScanDev);
            // 
            // splitTab1_Main.Panel2
            // 
            this.splitTab1_Main.Panel2.Controls.Add(this.splitTab1_Sub);
            this.splitTab1_Main.Size = new System.Drawing.Size(877, 437);
            this.splitTab1_Main.SplitterDistance = 276;
            this.splitTab1_Main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDisconnect);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Controls.Add(this.btScanStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 23);
            this.panel1.TabIndex = 4;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(178, 0);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btDisconnect.TabIndex = 4;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Image = global::ToolSet.Properties.Resources.BMP_GRAY;
            this.btConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConnect.Location = new System.Drawing.Point(88, 0);
            this.btConnect.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
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
            this.btScanStart.Name = "btScanStart";
            this.btScanStart.Size = new System.Drawing.Size(75, 23);
            this.btScanStart.TabIndex = 1;
            this.btScanStart.Text = "StartScan";
            this.btScanStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btScanStart.UseVisualStyleBackColor = true;
            this.btScanStart.Click += new System.EventHandler(this.btScanStart_Click);
            // 
            // listScanDev
            // 
            this.listScanDev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cRssi,
            this.cPacketType,
            this.cMacAddr,
            this.mAdrTye,
            this.cBond});
            this.listScanDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScanDev.FullRowSelect = true;
            this.listScanDev.GridLines = true;
            this.listScanDev.HideSelection = false;
            this.listScanDev.Location = new System.Drawing.Point(0, 0);
            this.listScanDev.MultiSelect = false;
            this.listScanDev.Name = "listScanDev";
            this.listScanDev.ShowGroups = false;
            this.listScanDev.Size = new System.Drawing.Size(274, 435);
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
            // splitTab1_Sub
            // 
            this.splitTab1_Sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitTab1_Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTab1_Sub.Location = new System.Drawing.Point(0, 0);
            this.splitTab1_Sub.Name = "splitTab1_Sub";
            // 
            // splitTab1_Sub.Panel1
            // 
            this.splitTab1_Sub.Panel1.Controls.Add(this.listPrimSrv);
            // 
            // splitTab1_Sub.Panel2
            // 
            this.splitTab1_Sub.Panel2.Controls.Add(this.listAttribute);
            this.splitTab1_Sub.Panel2.Controls.Add(this.txtLog);
            this.splitTab1_Sub.Size = new System.Drawing.Size(597, 437);
            this.splitTab1_Sub.SplitterDistance = 251;
            this.splitTab1_Sub.TabIndex = 5;
            // 
            // listPrimSrv
            // 
            this.listPrimSrv.AllowColumnReorder = true;
            this.listPrimSrv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.psrvName,
            this.psrvStart,
            this.psrvEnd,
            this.psrvUUID,
            this.psrvCharCnt});
            this.listPrimSrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPrimSrv.FullRowSelect = true;
            this.listPrimSrv.GridLines = true;
            this.listPrimSrv.HideSelection = false;
            this.listPrimSrv.Location = new System.Drawing.Point(0, 0);
            this.listPrimSrv.MultiSelect = false;
            this.listPrimSrv.Name = "listPrimSrv";
            this.listPrimSrv.ShowGroups = false;
            this.listPrimSrv.Size = new System.Drawing.Size(249, 435);
            this.listPrimSrv.TabIndex = 0;
            this.listPrimSrv.UseCompatibleStateImageBehavior = false;
            this.listPrimSrv.View = System.Windows.Forms.View.Details;
            this.listPrimSrv.DoubleClick += new System.EventHandler(this.listPrimSrv_DoubleClick);
            // 
            // psrvName
            // 
            this.psrvName.Text = "Name";
            // 
            // psrvStart
            // 
            this.psrvStart.Text = "Start";
            // 
            // psrvEnd
            // 
            this.psrvEnd.Text = "End";
            // 
            // psrvUUID
            // 
            this.psrvUUID.Text = "UUID";
            // 
            // psrvCharCnt
            // 
            this.psrvCharCnt.Text = "CharacterCount";
            // 
            // listAttribute
            // 
            this.listAttribute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attrConnHandle,
            this.attrHandle,
            this.attrType,
            this.attrValue});
            this.listAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAttribute.FullRowSelect = true;
            this.listAttribute.GridLines = true;
            this.listAttribute.HideSelection = false;
            this.listAttribute.Location = new System.Drawing.Point(0, 0);
            this.listAttribute.Name = "listAttribute";
            this.listAttribute.ShowGroups = false;
            this.listAttribute.Size = new System.Drawing.Size(340, 328);
            this.listAttribute.TabIndex = 1;
            this.listAttribute.UseCompatibleStateImageBehavior = false;
            this.listAttribute.View = System.Windows.Forms.View.Details;
            // 
            // attrConnHandle
            // 
            this.attrConnHandle.Text = "ConnHandle";
            // 
            // attrHandle
            // 
            this.attrHandle.Text = "Handle";
            // 
            // attrType
            // 
            this.attrType.Text = "Type";
            // 
            // attrValue
            // 
            this.attrValue.Text = "Value";
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 328);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(340, 107);
            this.txtLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 490);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(891, 469);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(891, 494);
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
            this.toolStripTop.Size = new System.Drawing.Size(891, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 5;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "Port:";
            // 
            // toolCmbPort
            // 
            this.toolCmbPort.AutoSize = false;
            this.toolCmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolCmbPort.DropDownWidth = 260;
            this.toolCmbPort.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolCmbPort.Name = "toolCmbPort";
            this.toolCmbPort.Size = new System.Drawing.Size(100, 21);
            this.toolCmbPort.DropDown += new System.EventHandler(this.toolCmbPort_DropDown);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 22);
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
            this.toolBtOpenCom.Size = new System.Drawing.Size(53, 22);
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
            this.toolBtDevPanel.Image = ((System.Drawing.Image)(resources.GetObject("toolBtDevPanel.Image")));
            this.toolBtDevPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtDevPanel.Name = "toolBtDevPanel";
            this.toolBtDevPanel.Size = new System.Drawing.Size(23, 22);
            this.toolBtDevPanel.Text = "<-";
            this.toolBtDevPanel.Click += new System.EventHandler(this.toolBtDevPanel_Click);
            // 
            // toolBtPrimSrvPanel
            // 
            this.toolBtPrimSrvPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtPrimSrvPanel.Image = ((System.Drawing.Image)(resources.GetObject("toolBtPrimSrvPanel.Image")));
            this.toolBtPrimSrvPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtPrimSrvPanel.Name = "toolBtPrimSrvPanel";
            this.toolBtPrimSrvPanel.Size = new System.Drawing.Size(23, 22);
            this.toolBtPrimSrvPanel.Text = "->";
            this.toolBtPrimSrvPanel.Click += new System.EventHandler(this.toolBtPrimSrvPanel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 543);
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
            this.panel1.ResumeLayout(false);
            this.splitTab1_Sub.Panel1.ResumeLayout(false);
            this.splitTab1_Sub.Panel2.ResumeLayout(false);
            this.splitTab1_Sub.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Sub)).EndInit();
            this.splitTab1_Sub.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader cPacketType;
        private System.Windows.Forms.ColumnHeader cMacAddr;
        private System.Windows.Forms.ColumnHeader cBond;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ColumnHeader mAdrTye;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.SplitContainer splitTab1_Sub;
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
        private System.Windows.Forms.ListView listPrimSrv;
        private System.Windows.Forms.ColumnHeader psrvName;
        private System.Windows.Forms.ColumnHeader psrvUUID;
        private System.Windows.Forms.ColumnHeader psrvCharCnt;
        private System.Windows.Forms.ColumnHeader psrvStart;
        private System.Windows.Forms.ColumnHeader psrvEnd;
        private System.Windows.Forms.ListView listAttribute;
        private System.Windows.Forms.ColumnHeader attrHandle;
        private System.Windows.Forms.ColumnHeader attrType;
        private System.Windows.Forms.ColumnHeader attrValue;
        private System.Windows.Forms.ColumnHeader attrConnHandle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtDevPanel;
        private System.Windows.Forms.ToolStripButton toolBtPrimSrvPanel;
        private System.Windows.Forms.ToolStripStatusLabel stsLb_ConnMac;
        private System.Windows.Forms.ToolStripStatusLabel tslbRxMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

