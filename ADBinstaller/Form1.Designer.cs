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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.linkTaC = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.checkSystemWide = new System.Windows.Forms.CheckBox();
            this.checkStartMenu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblProgVers = new System.Windows.Forms.Label();
            this.btnPackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(9, 38);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(68, 16);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "lblVersion";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(6, 63);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(287, 65);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = " This tool is made to install the latest Android \r\n platform-tools containing ADB" +
    " and Fastboot.\r\n The files are downloaded from the official Android Servers. \r\n\r" +
    "\n By downloading, you accept \r\n";
            // 
            // linkTaC
            // 
            this.linkTaC.AutoSize = true;
            this.linkTaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTaC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.linkTaC.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkTaC.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.linkTaC.Location = new System.Drawing.Point(6, 135);
            this.linkTaC.Name = "linkTaC";
            this.linkTaC.Size = new System.Drawing.Size(179, 15);
            this.linkTaC.TabIndex = 3;
            this.linkTaC.TabStop = true;
            this.linkTaC.Text = "Google\'s Terms and Conditions";
            this.linkTaC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkTaC_LinkClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(5, 277);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: Idle";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(9, 207);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(185, 41);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download and Install";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click_1);
            // 
            // checkSystemWide
            // 
            this.checkSystemWide.AutoSize = true;
            this.checkSystemWide.Location = new System.Drawing.Point(12, 161);
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
            this.checkStartMenu.Location = new System.Drawing.Point(12, 184);
            this.checkStartMenu.Name = "checkStartMenu";
            this.checkStartMenu.Size = new System.Drawing.Size(109, 17);
            this.checkStartMenu.TabIndex = 10;
            this.checkStartMenu.Text = "Add to start menu";
            this.checkStartMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "AdbInstaller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "by @Dyrex2004";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 254);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 19);
            this.progressBar1.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(243, 278);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check for update";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // lblProgVers
            // 
            this.lblProgVers.AutoSize = true;
            this.lblProgVers.Location = new System.Drawing.Point(219, 278);
            this.lblProgVers.Name = "lblProgVers";
            this.lblProgVers.Size = new System.Drawing.Size(25, 13);
            this.lblProgVers.TabIndex = 16;
            this.lblProgVers.Text = "v12";
            // 
            // btnPackage
            // 
            this.btnPackage.Location = new System.Drawing.Point(200, 207);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(129, 41);
            this.btnPackage.TabIndex = 17;
            this.btnPackage.Text = "Download Package";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 298);
            this.Controls.Add(this.btnPackage);
            this.Controls.Add(this.lblProgVers);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkStartMenu);
            this.Controls.Add(this.checkSystemWide);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.linkTaC);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdbInstaller";
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblProgVers;
        private System.Windows.Forms.Button btnPackage;
    }
}

