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
        }

        private void LinkTaC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developer.android.com/studio/terms");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var version = "V6";
            lblProgVers.Text = version;


            var installed = @"C:\Program Files (x86)\platform-tools\adb.exe";
            if (File.Exists(installed))
            {
                var install_date = File.GetLastWriteTime(installed).Day + "-" + File.GetLastWriteTime(installed).Month + "-" + File.GetLastWriteTime(installed).Year;
                lblVersion.Text = "Installed: Yes (" + install_date + ")";
                btnDownload.Text = "Download and Update";
            }
            else
            {
                lblVersion.Text = "Installed: None";
                btnDownload.Text = "Download and Install";

            }
        }

        private void BtnDownload_Click_1(object sender, EventArgs e)
        {
            {
                var webCl = new WebClient();
                var instDir = @"C:\Program Files (x86)\platform-tools";
                var cDir = @"C:\Program Files (x86)";
                var zipName = "platform-tools.zip";

                btnDownload.Enabled = false;
                btnPackage.Enabled = false;
                checkStartMenu.Enabled = false;
                checkSystemWide.Enabled = false;


                lblStatus.Text = "Status: Downloading";
                progressBar1.Value = 20;
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
                    progressBar1.Value = 40;

                    System.IO.DirectoryInfo di = new DirectoryInfo(instDir);

                    delFiles:

                    if (File.Exists(instDir + @"\adb.exe"))
                    {
                        foreach (FileInfo file in di.GetFiles())
                        {
                            try
                            {
                                file.Delete();
                            }
                            catch (UnauthorizedAccessException)
                            {
                                MessageBox.Show("Error: ADB server running! Your Server will be stopped now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                                startInfo.FileName = "cmd.exe";
                                startInfo.WorkingDirectory = @"C:\Program Files (x86)\platform-tools";
                                startInfo.Arguments = "/C adb kill-server";
                                process.StartInfo = startInfo;
                                process.Start();
                                MessageBox.Show("ADB server stopped!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                goto delFiles;
                            }

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
                    progressBar1.Value = 60;
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
                    progressBar1.Value = 80;
                    webCl.DownloadFile("https://github.com/K08official/AdbInstaller/raw/master/Files/open.exe", path);

                    string commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                    string appStartMenuPath = commonStartMenuPath + @"\Programs\";
                    webCl.DownloadFile("https://github.com/K08official/AdbInstaller/raw/master/Files/ADB%20and%20Fastboot.lnk", appStartMenuPath + "ADB and Fastboot.lnk");


                }


                Finish:
                    progressBar1.Value = 100;
                    MessageBox.Show("Done, it's recommended to restart your PC now. Problems? Message me on TG, @K08germany.", "ADBInstaller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto Finish_Done;

                Finish_error:
                    MessageBox.Show("Installation failed!", "ADBInstaller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Value = 0;

            }


        Finish_Done:;
                lblStatus.Text = "Status: Idle";
                progressBar1.Value = 0;
                File.Delete("platform-tools.zip");
                btnDownload.Enabled = true;
                btnPackage.Enabled = true;
                checkStartMenu.Enabled = true;
                checkSystemWide.Enabled = true;

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/K08official/AdbInstaller-Releases/releases");

        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            var webCl = new WebClient();
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "zip file (*.zip)|*.zip";
            fileDialog.FilterIndex = 1;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = fileDialog.FileName;
                lblStatus.Text = "Status: Downloading";
                progressBar1.Value = 100;
                btnDownload.Enabled = false;
                btnPackage.Enabled = false;
                checkStartMenu.Enabled = false;
                checkSystemWide.Enabled = false;

                try
                {
                    webCl.DownloadFile("https://dl.google.com/android/repository/platform-tools-latest-windows.zip", filePath);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Error: " + System.Environment.NewLine + System.Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Status: Idle";
                    goto package_exit;
                }

            package_exit_success:;
                MessageBox.Show("Success: " + System.Environment.NewLine + "File location: " + filePath, "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                goto package_exit;


            package_exit:;
                lblStatus.Text = "Status: Idle";
                progressBar1.Value = 0;
                btnDownload.Enabled = true;
                btnPackage.Enabled = true;
                checkStartMenu.Enabled = true;
                checkSystemWide.Enabled = true;

            }
        }
    }
}