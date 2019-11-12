namespace ADBinstaller
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.linkTaC = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.checkSystemWide = new System.Windows.Forms.CheckBox();
            this.checkStartMenu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblVersion.Location = new System.Drawing.Point(12, 50);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 18);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "lblVersion";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblDesc.Location = new System.Drawing.Point(12, 78);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(325, 75);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "This tool is made to install the latest Android \r\nplatform-tools containing ADB a" +
    "nd Fastboot.\r\nThe files are downloaded from the official Android Servers. \r\n\r\nBy" +
    " downloading, you accept \r\n";
            // 
            // linkTaC
            // 
            this.linkTaC.AutoSize = true;
            this.linkTaC.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.linkTaC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.linkTaC.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkTaC.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.linkTaC.Location = new System.Drawing.Point(12, 157);
            this.linkTaC.Name = "linkTaC";
            this.linkTaC.Size = new System.Drawing.Size(174, 16);
            this.linkTaC.TabIndex = 3;
            this.linkTaC.TabStop = true;
            this.linkTaC.Text = "Google\'s Terms and Conditions";
            this.linkTaC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkTaC_LinkClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblStatus.Location = new System.Drawing.Point(9, 289);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: Idle";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 231);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(320, 55);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click_1);
            // 
            // checkSystemWide
            // 
            this.checkSystemWide.AutoSize = true;
            this.checkSystemWide.Location = new System.Drawing.Point(15, 184);
            this.checkSystemWide.Name = "checkSystemWide";
            this.checkSystemWide.Size = new System.Drawing.Size(85, 17);
            this.checkSystemWide.TabIndex = 9;
            this.checkSystemWide.Text = "System-wide";
            this.checkSystemWide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkSystemWide.UseVisualStyleBackColor = true;
            // 
            // checkStartMenu
            // 
            this.checkStartMenu.AutoSize = true;
            this.checkStartMenu.Checked = true;
            this.checkStartMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkStartMenu.Location = new System.Drawing.Point(15, 208);
            this.checkStartMenu.Name = "checkStartMenu";
            this.checkStartMenu.Size = new System.Drawing.Size(109, 17);
            this.checkStartMenu.TabIndex = 10;
            this.checkStartMenu.Text = "Add to start menu";
            this.checkStartMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Convenient ADB Installer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "by Dyrex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkStartMenu);
            this.Controls.Add(this.checkSystemWide);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.linkTaC);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cADBi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.LinkLabel linkTaC;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.CheckBox checkSystemWide;
        private System.Windows.Forms.CheckBox checkStartMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

