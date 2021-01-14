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

namespace PHStudIPSync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void syncButton_Click(object sender, EventArgs e)
        {
            var syncCommand = new SyncCommand();
            syncCommand.Execute();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void browseDataFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a folder";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dataFolderTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void phBackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = "Username";
            passwordTextBox.Text = "Password";
            dataFolderTextBox.Text = "Data Folder";
            mediaFolderTextBox.Text = "Media Folder";
        }

        private void mediaFolderBrowseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a folder";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    mediaFolderTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void syncToolTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
