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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_File = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Tool = new System.Windows.Forms.ToolStripMenuItem();
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
            this.splitTab1_Sub = new System.Windows.Forms.SplitContainer();
            this.listPrimSrv = new System.Windows.Forms.ListView();
            this.psrvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psrvStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psrvEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psrvUUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitTab1_Attr = new System.Windows.Forms.SplitContainer();
            this.listAttribute = new System.Windows.Forms.ListView();
            this.attrDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attrHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCharacter = new System.Windows.Forms.TabControl();
            this.tabPgBat = new System.Windows.Forms.TabPage();
            this.rbChar = new System.Windows.Forms.RadioButton();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAttrData = new System.Windows.Forms.TextBox();
            this.tbAttrID = new System.Windows.Forms.TextBox();
            this.tbConnID = new System.Windows.Forms.TextBox();
            this.btAttrRead = new System.Windows.Forms.Button();
            this.lbAttrHandle = new System.Windows.Forms.Label();
            this.lbConnHandle = new System.Windows.Forms.Label();
            this.cbBatLevNotify = new System.Windows.Forms.CheckBox();
            this.tbBatLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Sub)).BeginInit();
            this.splitTab1_Sub.Panel1.SuspendLayout();
            this.splitTab1_Sub.Panel2.SuspendLayout();
            this.splitTab1_Sub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Attr)).BeginInit();
            this.splitTab1_Attr.Panel1.SuspendLayout();
            this.splitTab1_Attr.Panel2.SuspendLayout();
            this.splitTab1_Attr.SuspendLayout();
            this.tabCharacter.SuspendLayout();
            this.tabPgBat.SuspendLayout();
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
            this.tsLabelScan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(998, 25);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_File,
            this.m_Edit,
            this.m_Tool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
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
            this.m_Tool.Name = "m_Tool";
            this.m_Tool.Size = new System.Drawing.Size(42, 20);
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
            this.tabMain.Size = new System.Drawing.Size(998, 492);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.splitTab1_Main);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 466);
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
            this.splitTab1_Main.Panel2.Controls.Add(this.splitTab1_Sub);
            this.splitTab1_Main.Size = new System.Drawing.Size(984, 460);
            this.splitTab1_Main.SplitterDistance = 268;
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
            this.splitContainer1.Size = new System.Drawing.Size(266, 458);
            this.splitContainer1.SplitterDistance = 229;
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
            this.listScanDev.Size = new System.Drawing.Size(266, 229);
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
            this.txtLog.Size = new System.Drawing.Size(266, 202);
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
            this.panel1.Size = new System.Drawing.Size(266, 23);
            this.panel1.TabIndex = 4;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(179, 0);
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
            this.splitTab1_Sub.Panel2.Controls.Add(this.splitTab1_Attr);
            this.splitTab1_Sub.Size = new System.Drawing.Size(712, 460);
            this.splitTab1_Sub.SplitterDistance = 250;
            this.splitTab1_Sub.TabIndex = 5;
            // 
            // listPrimSrv
            // 
            this.listPrimSrv.AllowColumnReorder = true;
            this.listPrimSrv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.psrvName,
            this.psrvStart,
            this.psrvEnd,
            this.psrvUUID});
            this.listPrimSrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPrimSrv.FullRowSelect = true;
            this.listPrimSrv.GridLines = true;
            this.listPrimSrv.HideSelection = false;
            this.listPrimSrv.Location = new System.Drawing.Point(0, 0);
            this.listPrimSrv.MultiSelect = false;
            this.listPrimSrv.Name = "listPrimSrv";
            this.listPrimSrv.ShowGroups = false;
            this.listPrimSrv.Size = new System.Drawing.Size(248, 458);
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
            // splitTab1_Attr
            // 
            this.splitTab1_Attr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTab1_Attr.Location = new System.Drawing.Point(0, 0);
            this.splitTab1_Attr.Name = "splitTab1_Attr";
            // 
            // splitTab1_Attr.Panel1
            // 
            this.splitTab1_Attr.Panel1.Controls.Add(this.listAttribute);
            // 
            // splitTab1_Attr.Panel2
            // 
            this.splitTab1_Attr.Panel2.Controls.Add(this.tabCharacter);
            this.splitTab1_Attr.Size = new System.Drawing.Size(456, 458);
            this.splitTab1_Attr.SplitterDistance = 214;
            this.splitTab1_Attr.TabIndex = 2;
            // 
            // listAttribute
            // 
            this.listAttribute.AutoArrange = false;
            this.listAttribute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attrDesc,
            this.ConnHandle,
            this.attrHandle,
            this.attrType});
            this.listAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAttribute.FullRowSelect = true;
            this.listAttribute.GridLines = true;
            this.listAttribute.HideSelection = false;
            this.listAttribute.Location = new System.Drawing.Point(0, 0);
            this.listAttribute.Name = "listAttribute";
            this.listAttribute.ShowGroups = false;
            this.listAttribute.Size = new System.Drawing.Size(214, 458);
            this.listAttribute.TabIndex = 1;
            this.listAttribute.UseCompatibleStateImageBehavior = false;
            this.listAttribute.View = System.Windows.Forms.View.Details;
            this.listAttribute.SelectedIndexChanged += new System.EventHandler(this.listAttribute_SelectedIndexChanged);
            // 
            // attrDesc
            // 
            this.attrDesc.Text = "UserDesc";
            // 
            // ConnHandle
            // 
            this.ConnHandle.Text = "ConnHandle";
            // 
            // attrHandle
            // 
            this.attrHandle.Text = "AttrHandle";
            // 
            // attrType
            // 
            this.attrType.Text = "Type";
            // 
            // tabCharacter
            // 
            this.tabCharacter.Controls.Add(this.tabPgBat);
            this.tabCharacter.Controls.Add(this.tabPage4);
            this.tabCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCharacter.Location = new System.Drawing.Point(0, 0);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.SelectedIndex = 0;
            this.tabCharacter.Size = new System.Drawing.Size(238, 458);
            this.tabCharacter.TabIndex = 0;
            // 
            // tabPgBat
            // 
            this.tabPgBat.Controls.Add(this.rbChar);
            this.tabPgBat.Controls.Add(this.rbDec);
            this.tabPgBat.Controls.Add(this.rbHex);
            this.tabPgBat.Controls.Add(this.label2);
            this.tabPgBat.Controls.Add(this.tbAttrData);
            this.tabPgBat.Controls.Add(this.tbAttrID);
            this.tabPgBat.Controls.Add(this.tbConnID);
            this.tabPgBat.Controls.Add(this.btAttrRead);
            this.tabPgBat.Controls.Add(this.lbAttrHandle);
            this.tabPgBat.Controls.Add(this.lbConnHandle);
            this.tabPgBat.Controls.Add(this.cbBatLevNotify);
            this.tabPgBat.Controls.Add(this.tbBatLevel);
            this.tabPgBat.Controls.Add(this.label1);
            this.tabPgBat.Location = new System.Drawing.Point(4, 22);
            this.tabPgBat.Name = "tabPgBat";
            this.tabPgBat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgBat.Size = new System.Drawing.Size(230, 432);
            this.tabPgBat.TabIndex = 0;
            this.tabPgBat.Text = "Battery";
            this.tabPgBat.UseVisualStyleBackColor = true;
            // 
            // rbChar
            // 
            this.rbChar.AutoSize = true;
            this.rbChar.Location = new System.Drawing.Point(140, 247);
            this.rbChar.Name = "rbChar";
            this.rbChar.Size = new System.Drawing.Size(47, 17);
            this.rbChar.TabIndex = 11;
            this.rbChar.TabStop = true;
            this.rbChar.Text = "Char";
            this.rbChar.UseVisualStyleBackColor = true;
            // 
            // rbDec
            // 
            this.rbDec.AutoSize = true;
            this.rbDec.Location = new System.Drawing.Point(89, 247);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(45, 17);
            this.rbDec.TabIndex = 10;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "Dec";
            this.rbDec.UseVisualStyleBackColor = true;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Checked = true;
            this.rbHex.Location = new System.Drawing.Point(37, 247);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(44, 17);
            this.rbHex.TabIndex = 9;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "AttributeDat:";
            // 
            // tbAttrData
            // 
            this.tbAttrData.Location = new System.Drawing.Point(87, 194);
            this.tbAttrData.Multiline = true;
            this.tbAttrData.Name = "tbAttrData";
            this.tbAttrData.Size = new System.Drawing.Size(100, 47);
            this.tbAttrData.TabIndex = 7;
            // 
            // tbAttrID
            // 
            this.tbAttrID.Location = new System.Drawing.Point(87, 166);
            this.tbAttrID.Name = "tbAttrID";
            this.tbAttrID.Size = new System.Drawing.Size(49, 20);
            this.tbAttrID.TabIndex = 7;
            // 
            // tbConnID
            // 
            this.tbConnID.Location = new System.Drawing.Point(87, 138);
            this.tbConnID.Name = "tbConnID";
            this.tbConnID.Size = new System.Drawing.Size(49, 20);
            this.tbConnID.TabIndex = 7;
            // 
            // btAttrRead
            // 
            this.btAttrRead.Location = new System.Drawing.Point(32, 218);
            this.btAttrRead.Name = "btAttrRead";
            this.btAttrRead.Size = new System.Drawing.Size(49, 23);
            this.btAttrRead.TabIndex = 6;
            this.btAttrRead.Text = "Read";
            this.btAttrRead.UseVisualStyleBackColor = true;
            this.btAttrRead.Click += new System.EventHandler(this.btAttrRead_Click);
            // 
            // lbAttrHandle
            // 
            this.lbAttrHandle.AutoSize = true;
            this.lbAttrHandle.Location = new System.Drawing.Point(21, 173);
            this.lbAttrHandle.Name = "lbAttrHandle";
            this.lbAttrHandle.Size = new System.Drawing.Size(60, 13);
            this.lbAttrHandle.TabIndex = 5;
            this.lbAttrHandle.Text = "AttributeID:";
            // 
            // lbConnHandle
            // 
            this.lbConnHandle.AutoSize = true;
            this.lbConnHandle.Location = new System.Drawing.Point(20, 145);
            this.lbConnHandle.Name = "lbConnHandle";
            this.lbConnHandle.Size = new System.Drawing.Size(61, 13);
            this.lbConnHandle.TabIndex = 4;
            this.lbConnHandle.Text = "ConnectID:";
            // 
            // cbBatLevNotify
            // 
            this.cbBatLevNotify.AutoSize = true;
            this.cbBatLevNotify.Location = new System.Drawing.Point(52, 25);
            this.cbBatLevNotify.Name = "cbBatLevNotify";
            this.cbBatLevNotify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbBatLevNotify.Size = new System.Drawing.Size(53, 17);
            this.cbBatLevNotify.TabIndex = 3;
            this.cbBatLevNotify.Text = "Notify";
            this.cbBatLevNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbBatLevNotify.UseVisualStyleBackColor = true;
            // 
            // tbBatLevel
            // 
            this.tbBatLevel.Location = new System.Drawing.Point(92, 48);
            this.tbBatLevel.Name = "tbBatLevel";
            this.tbBatLevel.ReadOnly = true;
            this.tbBatLevel.Size = new System.Drawing.Size(74, 20);
            this.tbBatLevel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BatteryLevel:";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(230, 430);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 464);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(998, 492);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(998, 517);
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
            this.toolStripTop.Size = new System.Drawing.Size(998, 25);
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
            this.ClientSize = new System.Drawing.Size(998, 566);
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
            this.splitTab1_Sub.Panel1.ResumeLayout(false);
            this.splitTab1_Sub.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Sub)).EndInit();
            this.splitTab1_Sub.ResumeLayout(false);
            this.splitTab1_Attr.Panel1.ResumeLayout(false);
            this.splitTab1_Attr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTab1_Attr)).EndInit();
            this.splitTab1_Attr.ResumeLayout(false);
            this.tabCharacter.ResumeLayout(false);
            this.tabPgBat.ResumeLayout(false);
            this.tabPgBat.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader psrvStart;
        private System.Windows.Forms.ColumnHeader psrvEnd;
        private System.Windows.Forms.ListView listAttribute;
        private System.Windows.Forms.ColumnHeader attrHandle;
        private System.Windows.Forms.ColumnHeader attrType;
        private System.Windows.Forms.ColumnHeader ConnHandle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtDevPanel;
        private System.Windows.Forms.ToolStripButton toolBtPrimSrvPanel;
        private System.Windows.Forms.ToolStripStatusLabel stsLb_ConnMac;
        private System.Windows.Forms.ToolStripStatusLabel tslbRxMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitTab1_Attr;
        private System.Windows.Forms.TabControl tabCharacter;
        private System.Windows.Forms.TabPage tabPgBat;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cbBatLevNotify;
        private System.Windows.Forms.TextBox tbBatLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripProgressBar tsProBarScan;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelScan;
        private System.Windows.Forms.Timer timPeridic;
        private System.Windows.Forms.Label lbAttrHandle;
        private System.Windows.Forms.Label lbConnHandle;
        private System.Windows.Forms.Button btAttrRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAttrData;
        private System.Windows.Forms.TextBox tbAttrID;
        private System.Windows.Forms.TextBox tbConnID;
        private System.Windows.Forms.RadioButton rbChar;
        private System.Windows.Forms.RadioButton rbDec;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.ColumnHeader cAddrType;
        private System.Windows.Forms.ColumnHeader attrDesc;
    }
}

