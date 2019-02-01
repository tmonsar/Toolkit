using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Toolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Hide();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;

            ToolboxTextBox.Focus();
        }
        //----------------Toolbox Panel-----------------
        //Enter Button
        private void ToolboxEnterButton_Click(object sender, EventArgs e)
        {
            RunFunction();
        }

        //Enter Keypress
        private void ToolboxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                RunFunction();
            }
        }

        //Checks what number is in the text box when Enter Button or Enter Keypress 
        private void RunFunction()
        {
            if (ToolboxTextBox.Text == "1")
            {
                //Shows the Map Network Drive panel
                panel1.Hide();
                panel2.Show();
                MapDriveTextBox.Focus();
                ToolboxErrorLabel.Visible = false;
            }
            else if (ToolboxTextBox.Text == "2")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "3")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "4")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "5")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "6")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "7")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "8")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "9")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else if (ToolboxTextBox.Text == "10")
            {
                ToolboxErrorLabel.Text = "Number not yet programmed.";
                ToolboxErrorLabel.Visible = true;
            }
            else
            {
                ToolboxErrorLabel.Text = "Invalid number";
                ToolboxErrorLabel.Visible = true;
            }
        }


        //--------------------Map Network Drive Panel----------------------

        private string RunCommand(string Command)
        {
            //Process.Start("cmd.exe", "/K" + Command);
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = " /C" + Command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            string line = "";
            List<string> crappyoutput = new List<string>();
            while (!proc.StandardError.EndOfStream)
            {
                crappyoutput.Add(proc.StandardError.ReadLine());
                // do something with line
            }
            string combinedlines = "";
            foreach (var item in crappyoutput)
            {
                combinedlines = combinedlines + " " + item;
            }
            return combinedlines;
        }
        private void RunCommand(string Command, string Arguements)
        {
            RunCommand(Command + Arguements);
        }

        //Back Button
        private void MapDriveBackButton_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            MapDriveErrorLabel.Text = "You'll usually only need to enter your credentials from administrator account.";
        }

        //Enter Button
        private async void MapDriveEnterButton_Click_1(object sender, EventArgs e)
        {
            await RunMapDriveInit();
        }

        //Enter Keypress
        private async void MapDriveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                await RunMapDriveInit();
            }
        }

        //Initiates thread syncing and changes error message
        private async Task RunMapDriveInit()
        {
            MapDriveErrorLabel.Text = "Connecting...";
            string msg = await RunMapDriveThread();
            MapDriveErrorLabel.Visible = true;
            MapDriveErrorLabel.Text = msg;
            Console.WriteLine(msg);
        }

        //Dunno what this shit does
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        //Maps Network drive asynchronously to interacting with the ui
        public async Task<string> RunMapDriveThread()
        {

            string message = "You'll usually only need to enter your credentials from administrator account.";
            return await Task.Run<string>(() => 
            {

                int error = 0;

                if (MapDriveTextBox.Text == "1")
                {
                    if (MapPasswordTextBox.Text == string.Empty && MapUserNameTextBox.Text == string.Empty)
                    {
                            message = RunCommand(@"net use Z: \\jdnet\jdmedia /persistent:no");
                    }
                    else
                    {
                        error = MapNetworkDrive.NetworkDrive.MapNetworkDrive("Z", @"\\jdnet\jdmedia", MapPasswordTextBox.Text, MapUserNameTextBox.Text);
                        message = WinErrors.GetSystemMessage((uint)error);
                    }
                    
                }
                else if (MapDriveTextBox.Text == "2")
                {
                    if (MapPasswordTextBox.Text == string.Empty && MapUserNameTextBox.Text == string.Empty)
                    {
                        message = RunCommand(@"net use Z: \\wdx0000041205a\tier2share /persistent:no");
                    }
                    else
                    {
                        error = MapNetworkDrive.NetworkDrive.MapNetworkDrive("Z", @"\\wdx0000041205a\tier2share", MapPasswordTextBox.Text, MapUserNameTextBox.Text);
                        message = WinErrors.GetSystemMessage((uint)error);
                    }
                }
                
                else if (MapDriveTextBox.Text == "3")
                {

                    if (UNCPathTextBox.Visible)
                    {
                        if (MapPasswordTextBox.Text == string.Empty && MapUserNameTextBox.Text == string.Empty)
                        {
                            message = RunCommand($@"net use {MapLetterTextBox.Text}: {UNCPathTextBox.Text} /persistent:no");
                        }
                        else
                        {
                            try
                            {
                                error = MapNetworkDrive.NetworkDrive.MapNetworkDrive(MapLetterTextBox.Text, UNCPathTextBox.Text, MapPasswordTextBox.Text, MapUserNameTextBox.Text);
                                message = WinErrors.GetSystemMessage((uint)error);
                            }
                            catch (Exception)
                            {
                                message = "Invalid path";
                            }
                        }
                        
                    }
                    else
                    {
                        //Turns on Visability of the UNC Drive letter and path
                        //Runs it as a dummy delegate outside of the async thread
                        this.Invoke((MethodInvoker)(() =>
                       {
                           UNCPathTextBox.Visible = true;
                           MapLetterTextBox.Visible = true;
                           DriveLetterLabel.Visible = true;
                       }));
                    }
                    

                }

                else if (MapDriveTextBox.Text == "4")
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        panel1.Show();
                        panel2.Hide();
                        MapDriveErrorLabel.Text = "You'll usually only need to enter your credentials from administrator account.";
                    }));
                }

                else if (MapDriveTextBox.Text == "5")
                {
                    System.Environment.Exit(1);
                }

                else
                {
                    message = "Invalid number";
                }

                
                
                return message;

            });
        }



        public static class WinErrors
        {
            /// <summary>
            /// Gets a user friendly string message for a system error code
            /// </summary>
            /// <param name="errorCode">System error code</param>
            /// <returns>Error string</returns>
            public static string GetSystemMessage(uint errorCode)
            {
                var exception = new Win32Exception((int)errorCode);
                return exception.Message;
            }
        }

        
    }
}
