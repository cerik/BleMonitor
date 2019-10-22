namespace ToolSet
{
    partial class frmService
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
            this.lsvSrv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvSrv
            // 
            this.lsvSrv.HideSelection = false;
            this.lsvSrv.Location = new System.Drawing.Point(2, 2);
            this.lsvSrv.Name = "lsvSrv";
            this.lsvSrv.Size = new System.Drawing.Size(608, 404);
            this.lsvSrv.TabIndex = 0;
            this.lsvSrv.UseCompatibleStateImageBehavior = false;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvSrv);
            this.Name = "frmService";
            this.Text = "frmService";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvSrv;
    }
}