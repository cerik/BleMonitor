namespace ToolSet
{
    partial class frmSrvFittest
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
            this.tbFitResultGet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFitAttenLeftGet = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFitAttenRightGet = new System.Windows.Forms.TextBox();
            this.btFitAttenGet = new System.Windows.Forms.Button();
            this.btFitResultGet = new System.Windows.Forms.Button();
            this.btFitStart = new System.Windows.Forms.Button();
            this.btFitStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btFitStsGet = new System.Windows.Forms.Button();
            this.tbFitStatusGet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result:";
            // 
            // tbFitResultGet
            // 
            this.tbFitResultGet.Location = new System.Drawing.Point(59, 94);
            this.tbFitResultGet.Name = "tbFitResultGet";
            this.tbFitResultGet.ReadOnly = true;
            this.tbFitResultGet.Size = new System.Drawing.Size(94, 20);
            this.tbFitResultGet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Left:";
            // 
            // tbFitAttenLeftGet
            // 
            this.tbFitAttenLeftGet.Location = new System.Drawing.Point(46, 19);
            this.tbFitAttenLeftGet.Name = "tbFitAttenLeftGet";
            this.tbFitAttenLeftGet.ReadOnly = true;
            this.tbFitAttenLeftGet.Size = new System.Drawing.Size(90, 20);
            this.tbFitAttenLeftGet.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFitAttenGet);
            this.groupBox1.Controls.Add(this.tbFitAttenRightGet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFitAttenLeftGet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attenuation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Right:";
            // 
            // tbFitAttenRightGet
            // 
            this.tbFitAttenRightGet.Location = new System.Drawing.Point(46, 45);
            this.tbFitAttenRightGet.Name = "tbFitAttenRightGet";
            this.tbFitAttenRightGet.ReadOnly = true;
            this.tbFitAttenRightGet.Size = new System.Drawing.Size(90, 20);
            this.tbFitAttenRightGet.TabIndex = 1;
            // 
            // btFitAttenGet
            // 
            this.btFitAttenGet.Location = new System.Drawing.Point(146, 18);
            this.btFitAttenGet.Name = "btFitAttenGet";
            this.btFitAttenGet.Size = new System.Drawing.Size(34, 47);
            this.btFitAttenGet.TabIndex = 2;
            this.btFitAttenGet.Text = "Get";
            this.btFitAttenGet.UseVisualStyleBackColor = true;
            this.btFitAttenGet.Click += new System.EventHandler(this.btFitAttenGet_Click);
            // 
            // btFitResultGet
            // 
            this.btFitResultGet.Location = new System.Drawing.Point(156, 94);
            this.btFitResultGet.Name = "btFitResultGet";
            this.btFitResultGet.Size = new System.Drawing.Size(34, 21);
            this.btFitResultGet.TabIndex = 3;
            this.btFitResultGet.Text = "Get";
            this.btFitResultGet.UseVisualStyleBackColor = true;
            this.btFitResultGet.Click += new System.EventHandler(this.btFitResultGet_Click);
            // 
            // btFitStart
            // 
            this.btFitStart.Location = new System.Drawing.Point(46, 19);
            this.btFitStart.Name = "btFitStart";
            this.btFitStart.Size = new System.Drawing.Size(40, 23);
            this.btFitStart.TabIndex = 4;
            this.btFitStart.Text = "Start";
            this.btFitStart.UseVisualStyleBackColor = true;
            this.btFitStart.Click += new System.EventHandler(this.btFitStart_Click);
            // 
            // btFitStop
            // 
            this.btFitStop.Location = new System.Drawing.Point(97, 19);
            this.btFitStop.Name = "btFitStop";
            this.btFitStop.Size = new System.Drawing.Size(40, 23);
            this.btFitStop.TabIndex = 4;
            this.btFitStop.Text = "Stop";
            this.btFitStop.UseVisualStyleBackColor = true;
            this.btFitStop.Click += new System.EventHandler(this.btFitStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btFitStsGet);
            this.groupBox2.Controls.Add(this.btFitStop);
            this.groupBox2.Controls.Add(this.tbFitStatusGet);
            this.groupBox2.Controls.Add(this.btFitStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activate";
            // 
            // btFitStsGet
            // 
            this.btFitStsGet.Location = new System.Drawing.Point(146, 48);
            this.btFitStsGet.Name = "btFitStsGet";
            this.btFitStsGet.Size = new System.Drawing.Size(34, 21);
            this.btFitStsGet.TabIndex = 2;
            this.btFitStsGet.Text = "Get";
            this.btFitStsGet.UseVisualStyleBackColor = true;
            this.btFitStsGet.Click += new System.EventHandler(this.btFitStsGet_Click);
            // 
            // tbFitStatusGet
            // 
            this.tbFitStatusGet.Location = new System.Drawing.Point(49, 48);
            this.tbFitStatusGet.Name = "tbFitStatusGet";
            this.tbFitStatusGet.ReadOnly = true;
            this.tbFitStatusGet.Size = new System.Drawing.Size(94, 20);
            this.tbFitStatusGet.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // frmSrvFittest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 204);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btFitResultGet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbFitResultGet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSrvFittest";
            this.Text = "frmSrvFittest";
            this.Load += new System.EventHandler(this.frmSrvFittest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFitResultGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFitAttenLeftGet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFitAttenRightGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btFitAttenGet;
        private System.Windows.Forms.Button btFitResultGet;
        private System.Windows.Forms.Button btFitStart;
        private System.Windows.Forms.Button btFitStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btFitStsGet;
        private System.Windows.Forms.TextBox tbFitStatusGet;
        private System.Windows.Forms.Label label5;
    }
}