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
            this.btnDownload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDesc = new System.Windows.Forms.Label();
            this.linkTaC = new System.Windows.Forms.LinkLabel();
            this.checkSystemWide = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkStartMenu = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(12, 79);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 18);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "lblVersion";
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Depth = 0;
            this.btnDownload.Icon = null;
            this.btnDownload.Location = new System.Drawing.Point(12, 286);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Primary = true;
            this.btnDownload.Size = new System.Drawing.Size(185, 36);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download and install";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(12, 105);
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
            this.linkTaC.Location = new System.Drawing.Point(12, 187);
            this.linkTaC.Name = "linkTaC";
            this.linkTaC.Size = new System.Drawing.Size(174, 16);
            this.linkTaC.TabIndex = 3;
            this.linkTaC.TabStop = true;
            this.linkTaC.Text = "Google\'s Terms and Conditions";
            this.linkTaC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkTaC_LinkClicked);
            // 
            // checkSystemWide
            // 
            this.checkSystemWide.AutoSize = true;
            this.checkSystemWide.Depth = 0;
            this.checkSystemWide.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkSystemWide.Location = new System.Drawing.Point(12, 212);
            this.checkSystemWide.Margin = new System.Windows.Forms.Padding(0);
            this.checkSystemWide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkSystemWide.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkSystemWide.Name = "checkSystemWide";
            this.checkSystemWide.Ripple = true;
            this.checkSystemWide.Size = new System.Drawing.Size(149, 30);
            this.checkSystemWide.TabIndex = 5;
            this.checkSystemWide.Text = "Install system-wide";
            this.checkSystemWide.UseVisualStyleBackColor = true;
            // 
            // checkStartMenu
            // 
            this.checkStartMenu.AutoSize = true;
            this.checkStartMenu.Checked = true;
            this.checkStartMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkStartMenu.Depth = 0;
            this.checkStartMenu.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkStartMenu.Location = new System.Drawing.Point(12, 242);
            this.checkStartMenu.Margin = new System.Windows.Forms.Padding(0);
            this.checkStartMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkStartMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkStartMenu.Name = "checkStartMenu";
            this.checkStartMenu.Ripple = true;
            this.checkStartMenu.Size = new System.Drawing.Size(140, 30);
            this.checkStartMenu.TabIndex = 6;
            this.checkStartMenu.Text = "Add to start menu";
            this.checkStartMenu.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(203, 297);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: Idle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(350, 337);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.checkStartMenu);
            this.Controls.Add(this.checkSystemWide);
            this.Controls.Add(this.linkTaC);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblVersion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 337);
            this.MinimumSize = new System.Drawing.Size(350, 337);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB Installer by @K08germany (TG)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.LinkLabel linkTaC;
        private MaterialSkin.Controls.MaterialCheckBox checkSystemWide;
        private MaterialSkin.Controls.MaterialCheckBox checkStartMenu;
        private MaterialSkin.Controls.MaterialRaisedButton btnDownload;
        private System.Windows.Forms.Label lblStatus;
    }
}

