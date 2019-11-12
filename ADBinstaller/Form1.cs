using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
// using MaterialSkin;
// using MaterialSkin.Animations;
// using MaterialSkin.Controls;


namespace ADBinstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Init MaterialSkin
            // var materialSkinManager = MaterialSkinManager.Instance;
            // materialSkinManager.AddFormToManage(this);
            // materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);

        }

        private void LinkTaC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developer.android.com/studio/terms");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var installed = @"C:\Program Files (x86)\platform-tools\adb.exe";
            if (File.Exists(installed))
            {
                lblVersion.Text = "Installed: Yes (" + File.GetLastWriteTime(installed) + ")";
            }
            else
            {
                lblVersion.Text = "Installed: None";
            }
        }

        private void BtnDownload_Click_1(object sender, EventArgs e)
        {
            {
                var webCl = new WebClient();
                var instDir = @"C:\Program Files (x86)\platform-tools";
                var cDir = @"C:\Program Files (x86)";
                var zipName = "platform-tools.zip";
                lblStatus.Text = "Status: Downloading";

                try
                {
                    webCl.DownloadFile("https://dl.google.com/android/repository/platform-tools-latest-windows.zip", zipName);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Error: " + System.Environment.NewLine + System.Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Status: Idle";
                    goto Finish_error;
                }

                if (System.IO.File.Exists(zipName))
                {
                    lblStatus.Text = "Status: Extracting...";
                    System.IO.DirectoryInfo di = new DirectoryInfo(instDir);

                    if (File.Exists(instDir + @"\adb.exe"))
                    {
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }
                    }

                    ZipFile.ExtractToDirectory(zipName, cDir);
                }

                if (System.Environment.GetEnvironmentVariable("path").Contains(instDir))
                {
                    goto skipSystemWide;
                }
                else if (checkSystemWide.Checked == true)
                {
                    lblStatus.Text = "Status: Adding EnvVars...";
                    const string name = "PATH";
                    string pathvar = System.Environment.GetEnvironmentVariable(name);
                    var value = pathvar + @";C:\Program Files (x86)\platform-tools";
                    var target = EnvironmentVariableTarget.Machine;
                    System.Environment.SetEnvironmentVariable(name, value, target);
                }
                skipSystemWide:

                if (checkStartMenu.Checked == true)
                {
                    string path = instDir + @"\open.exe";
                    lblStatus.Text = "Status: Add to Start";
                    webCl.DownloadFile("https://github.com/K08official/AdbInstaller/raw/master/Files/open.exe", path);

                    string commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                    string appStartMenuPath = commonStartMenuPath + @"\Programs\";
                    webCl.DownloadFile("https://github.com/K08official/AdbInstaller/raw/master/Files/ADB%20and%20Fastboot.lnk", appStartMenuPath + "ADB and Fastboot.lnk");


                }
            Finish:
                MessageBox.Show("Done, it's recommended to restart your PC now. Problems? Message me on TG, @K08germany.", "ADBInstaller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goto Finish_Done;
            Finish_error:
                MessageBox.Show("Installation failed!", "ADBInstaller", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        Finish_Done:;
            lblStatus.Text = "Status: Idle";



        }

    }
}
