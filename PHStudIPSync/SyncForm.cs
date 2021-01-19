using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHStudIPSync
{
    public partial class SyncForm : Form
    {
        private Process process;

        public SyncForm()
        {
            InitializeComponent();

            InitializeBackgroundWorker();
        }

        private void SyncForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker1_ProgressChanged);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null) {
                outputTextBox.AppendText(e.UserState as String);
                outputTextBox.AppendText(Environment.NewLine);
            }
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @".\scripts\sync\phstudipsync.exe",
                    Arguments = "",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            process.OutputDataReceived += OutputDataReceived;
            process.ErrorDataReceived += ErrorDataReceived;
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();

        }

        private void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string line = e.Data;
            backgroundWorker1.ReportProgress(0, line);
        }

        private void ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string line = e.Data;
            backgroundWorker1.ReportProgress(0, line);
        }


    }
}
