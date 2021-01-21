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

        private const string CloseString = "Schließen";
        private const string CancelString = "Abbrechen";
        private const string ExecutablePath = @".\scripts\sync\phstudipsync.exe";

        private delegate void SafeCallDelegate(string text);
        private Process process;
        private CancellationTokenSource cancellationTokenSource;

        public SyncMessageBox()
        {
            InitializeComponent();
        }


        public void SetOutputText(String str)
        {
            if (outputTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetOutputText);
                outputTextBox.Invoke(d, new object[] { str });
            }
            else
            {
                outputTextBox.Text = str;
            }
        }

        public void AppendOutputText(String str)
        {
            if (outputTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(AppendOutputText);
                outputTextBox.Invoke(d, new object[] { str });
            }
            else
            {
                outputTextBox.AppendText(str);
            }
        }

        private void SyncMessageBox_Shown(object sender, EventArgs e)
        {
            process = new Process
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
            ReadProcessOutput();
        }

        private void ReadProcessOutput()
        {

            cancellationTokenSource = new CancellationTokenSource();

            CancellationToken ct = cancellationTokenSource.Token;

            Task.Factory.StartNew(() =>
            {
                char[] buffer = new char[256];
                string output = "";
                Task<int> read = null;

                while (true)
                {
                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }

                    if (read == null)
                        read = process.StandardOutput.ReadAsync(buffer, 0, buffer.Length);

                    read.Wait(100);

                    if (read.IsCompleted)
                    {
                        if (read.Result > 0)
                        {
                            output += new string(buffer, 0, read.Result);
                            read = null;
                            SetOutputText(output);
                            Thread.Sleep(10);

                            continue;
                        }

                        // got -1, process ended
                        HandleOutput(output);
                        AppendOutputText("Fertig.");
                        SetCancelButtonText(CloseString);
                        break;
                    }
                }
            });
        }

        private void HandleOutput(string output)
        {
            if (output.Contains("Wrong credentials, cannot login")) {
                AppendOutputText("Fehler beim Login: bitte Username und Passwort überprüfen." + Environment.NewLine);
            }
        }

        public void SetCancelButtonText(String str)
        {
            if (outputTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetCancelButtonText);
                cancelButton.Invoke(d, new object[] { str });
            }
            else
            {
                cancelButton.Text = str;
            }
        }

        private void cancelButton_click(object sender, EventArgs e)
        {
            if (cancelButton.Text == CancelString)
            {
                if (!process.HasExited)
                {
                    cancellationTokenSource.Cancel();
                    process.Close();
                    process.Dispose();
                }
                AppendOutputText("Abgebrochen.");
                SetCancelButtonText(CloseString);
            }
            else
            {
                this.Close();
            }
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            var config = (new SyncCommand()).GetConfig();
            Process.Start(config.files_destination);
        }

    }
}
