using Microsoft.WindowsAPICodePack.Dialogs;
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

            syncCommand.SetData(new SyncCommandData
            {
                user = new SyncCommandUser()
                {
                    login = userNameTextBox.Text,
                    password = passwordTextBox.Text
                },
                files_destination = dataFolderTextBox.Text,
                media_destination = mediaFolderTextBox.Text
            });
            syncCommand.Execute();
        }


        private void browseDataFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new CommonOpenFileDialog())
            {
                fbd.IsFolderPicker = true;
                var result = fbd.ShowDialog();

                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    dataFolderTextBox.Text = fbd.FileName;
                }
            }
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
            using (var fbd = new CommonOpenFileDialog())
            {
                fbd.IsFolderPicker = true;
                var result = fbd.ShowDialog();

                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    mediaFolderTextBox.Text = fbd.FileName;
                }
            }
        }

    }
}
