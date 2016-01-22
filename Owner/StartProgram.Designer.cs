namespace Owner
{
    partial class frmStartProgram
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
            this.lblStatusText = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.lblCurrentComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatusText
            // 
            this.lblStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusText.Location = new System.Drawing.Point(12, 26);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(73, 28);
            this.lblStatusText.TabIndex = 0;
            this.lblStatusText.Text = "Загрузка:";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(12, 57);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(338, 23);
            this.pbStatus.Step = 100;
            this.pbStatus.TabIndex = 1;
            // 
            // lblCurrentComp
            // 
            this.lblCurrentComp.AutoEllipsis = true;
            this.lblCurrentComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentComp.Location = new System.Drawing.Point(85, 26);
            this.lblCurrentComp.Name = "lblCurrentComp";
            this.lblCurrentComp.Size = new System.Drawing.Size(265, 28);
            this.lblCurrentComp.TabIndex = 0;
            // 
            // frmStartProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 95);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblCurrentComp);
            this.Controls.Add(this.lblStatusText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStartProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartProgram";
            this.Load += new System.EventHandler(this.StartProgram_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Label lblCurrentComp;
    }
}