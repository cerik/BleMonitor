namespace ToolSet
{
    partial class frmSrvTonePlay
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTonePlyStsGet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTonePlyFreqSet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTonePlySplSet = new System.Windows.Forms.TextBox();
            this.btTonePlyStsGet = new System.Windows.Forms.Button();
            this.btTonePlyCfgSet = new System.Windows.Forms.Button();
            this.btTonePlyCfgGet = new System.Windows.Forms.Button();
            this.tbTonePlyFreqGet = new System.Windows.Forms.TextBox();
            this.tbTonePlySplGet = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTonePlyStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTonePlyStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // tbTonePlyStsGet
            // 
            this.tbTonePlyStsGet.Location = new System.Drawing.Point(51, 74);
            this.tbTonePlyStsGet.Name = "tbTonePlyStsGet";
            this.tbTonePlyStsGet.ReadOnly = true;
            this.tbTonePlyStsGet.Size = new System.Drawing.Size(60, 20);
            this.tbTonePlyStsGet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Freq(Hz):";
            // 
            // tbTonePlyFreqSet
            // 
            this.tbTonePlyFreqSet.Location = new System.Drawing.Point(67, 33);
            this.tbTonePlyFreqSet.Name = "tbTonePlyFreqSet";
            this.tbTonePlyFreqSet.Size = new System.Drawing.Size(60, 20);
            this.tbTonePlyFreqSet.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SPL(%):";
            // 
            // tbTonePlySplSet
            // 
            this.tbTonePlySplSet.Location = new System.Drawing.Point(67, 59);
            this.tbTonePlySplSet.Name = "tbTonePlySplSet";
            this.tbTonePlySplSet.Size = new System.Drawing.Size(60, 20);
            this.tbTonePlySplSet.TabIndex = 1;
            // 
            // btTonePlyStsGet
            // 
            this.btTonePlyStsGet.Location = new System.Drawing.Point(117, 73);
            this.btTonePlyStsGet.Name = "btTonePlyStsGet";
            this.btTonePlyStsGet.Size = new System.Drawing.Size(40, 23);
            this.btTonePlyStsGet.TabIndex = 2;
            this.btTonePlyStsGet.Text = "Get";
            this.btTonePlyStsGet.UseVisualStyleBackColor = true;
            this.btTonePlyStsGet.Click += new System.EventHandler(this.btTonePlyStsGet_Click);
            // 
            // btTonePlyCfgSet
            // 
            this.btTonePlyCfgSet.Location = new System.Drawing.Point(87, 86);
            this.btTonePlyCfgSet.Name = "btTonePlyCfgSet";
            this.btTonePlyCfgSet.Size = new System.Drawing.Size(40, 23);
            this.btTonePlyCfgSet.TabIndex = 2;
            this.btTonePlyCfgSet.Text = "Set";
            this.btTonePlyCfgSet.UseVisualStyleBackColor = true;
            this.btTonePlyCfgSet.Click += new System.EventHandler(this.btTonePlyCfgSet_Click);
            // 
            // btTonePlyCfgGet
            // 
            this.btTonePlyCfgGet.Location = new System.Drawing.Point(133, 86);
            this.btTonePlyCfgGet.Name = "btTonePlyCfgGet";
            this.btTonePlyCfgGet.Size = new System.Drawing.Size(40, 23);
            this.btTonePlyCfgGet.TabIndex = 2;
            this.btTonePlyCfgGet.Text = "Get";
            this.btTonePlyCfgGet.UseVisualStyleBackColor = true;
            this.btTonePlyCfgGet.Click += new System.EventHandler(this.btTonePlyCfgGet_Click);
            // 
            // tbTonePlyFreqGet
            // 
            this.tbTonePlyFreqGet.Location = new System.Drawing.Point(133, 34);
            this.tbTonePlyFreqGet.Name = "tbTonePlyFreqGet";
            this.tbTonePlyFreqGet.ReadOnly = true;
            this.tbTonePlyFreqGet.Size = new System.Drawing.Size(60, 20);
            this.tbTonePlyFreqGet.TabIndex = 1;
            // 
            // tbTonePlySplGet
            // 
            this.tbTonePlySplGet.Location = new System.Drawing.Point(133, 60);
            this.tbTonePlySplGet.Name = "tbTonePlySplGet";
            this.tbTonePlySplGet.ReadOnly = true;
            this.tbTonePlySplGet.Size = new System.Drawing.Size(60, 20);
            this.tbTonePlySplGet.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTonePlyFreqSet);
            this.groupBox1.Controls.Add(this.btTonePlyCfgGet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btTonePlyCfgSet);
            this.groupBox1.Controls.Add(this.tbTonePlyFreqGet);
            this.groupBox1.Controls.Add(this.tbTonePlySplGet);
            this.groupBox1.Controls.Add(this.tbTonePlySplSet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure";
            // 
            // btTonePlyStart
            // 
            this.btTonePlyStart.Location = new System.Drawing.Point(38, 30);
            this.btTonePlyStart.Name = "btTonePlyStart";
            this.btTonePlyStart.Size = new System.Drawing.Size(37, 23);
            this.btTonePlyStart.TabIndex = 4;
            this.btTonePlyStart.Text = "Play";
            this.btTonePlyStart.UseVisualStyleBackColor = true;
            this.btTonePlyStart.Click += new System.EventHandler(this.btTonePlyStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTonePlyStsGet);
            this.groupBox2.Controls.Add(this.btTonePlyStop);
            this.groupBox2.Controls.Add(this.btTonePlyStart);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTonePlyStsGet);
            this.groupBox2.Location = new System.Drawing.Point(3, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // btTonePlyStop
            // 
            this.btTonePlyStop.Location = new System.Drawing.Point(97, 30);
            this.btTonePlyStop.Name = "btTonePlyStop";
            this.btTonePlyStop.Size = new System.Drawing.Size(37, 23);
            this.btTonePlyStop.TabIndex = 4;
            this.btTonePlyStop.Text = "Stop";
            this.btTonePlyStop.UseVisualStyleBackColor = true;
            this.btTonePlyStop.Click += new System.EventHandler(this.btTonePlyStop_Click);
            // 
            // frmSrvTonePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSrvTonePlay";
            this.Text = "frmService";
            this.Load += new System.EventHandler(this.frmSrvTonePlay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTonePlyStsGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTonePlyFreqSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTonePlySplSet;
        private System.Windows.Forms.Button btTonePlyStsGet;
        private System.Windows.Forms.Button btTonePlyCfgSet;
        private System.Windows.Forms.Button btTonePlyCfgGet;
        private System.Windows.Forms.TextBox tbTonePlyFreqGet;
        private System.Windows.Forms.TextBox tbTonePlySplGet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTonePlyStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTonePlyStop;
    }
}