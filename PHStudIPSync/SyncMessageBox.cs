using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHStudIPSync
{
    public partial class SyncMessageBox : Form
    {
        private delegate void SafeCallDelegate(string text);
        private readonly string ExecutablePath = @".\scripts\sync\phstudipsync.exe";

        public SyncMessageBox()
        {
            InitializeComponent();
        }

        private void SyncMessageBox_Load(object sender, EventArgs e)
        {
            
        }

        public void SetText(String str)
        {
            if (outputTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetText);
                outputTextBox.Invoke(d, new object[] { str });
            }
            else
            {
                outputTextBox.Text = str;
            }
        }

        private void SyncMessageBox_Shown(object sender, EventArgs e)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ExecutablePath,
                    Arguments = "",
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };


            process.Start();
            Task.Factory.StartNew(() =>
            {
                char[] buffer = new char[256];
                string output = "";
                Task<int> read = null;

                while (true)
                {
                    if (read == null)
                        read = process.StandardOutput.ReadAsync(buffer, 0, buffer.Length);

                    read.Wait(100);

                    if (read.IsCompleted)
                    {
                        if (read.Result > 0)
                        {
                            output += new string(buffer, 0, read.Result);
                            read = null; 
                            SetText(output);
                            Thread.Sleep(10);

                            continue;
                        }

                        // got -1, process ended
                        break;
                    }
                }
            });
            
        }
    }
}
