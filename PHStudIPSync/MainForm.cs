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
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                userNameTextBox.Focus();
                errorProvider.SetError(userNameTextBox, "Benutzer angeben.");
                return;
            }
            else
            {
                errorProvider.SetError(userNameTextBox, null);
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                userNameTextBox.Focus();
                errorProvider.SetError(passwordTextBox, "Passwort angeben.");
                return;
            }
            else
            {
                errorProvider.SetError(passwordTextBox, null);
            }

            if (string.IsNullOrEmpty(dataFolderTextBox.Text))
            {
                userNameTextBox.Focus();
                errorProvider.SetError(dataFolderTextBox, "Ordner angeben.");
                return;
            }
            else
            {
                errorProvider.SetError(dataFolderTextBox, null);
            }

            var syncCommand = new SyncCommand();

            syncCommand.SetData(new SyncCommandData
            {
                user = new SyncCommandUser()
                {
                    login = userNameTextBox.Text,
                    password = passwordTextBox.Text
                },
                files_destination = dataFolderTextBox.Text,
                media_destination = mediaFolderTextBox.Text,
                savePassword = savePasswordCheckBox.Checked
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
            var syncCommand = new SyncCommand();
            if (syncCommand.HasConfig())
            {
                var config = syncCommand.GetConfig();
                userNameTextBox.Text = config.user.login;
                passwordTextBox.Text = config.user.password;
                dataFolderTextBox.Text = config.files_destination;
                mediaFolderTextBox.Text = config.media_destination;
                savePasswordCheckBox.Checked = config.savePassword;
            }
            else
            {
                userNameTextBox.Text = "Username";
                passwordTextBox.Text = "";
                dataFolderTextBox.Text = "Data Folder";
                mediaFolderTextBox.Text = "Media Folder";
                savePasswordCheckBox.Checked = false;
            }
           
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var syncCommand = new SyncCommand();

            syncCommand.SetData(new SyncCommandData
            {
                user = new SyncCommandUser()
                {
                    login = userNameTextBox.Text,
                    password = savePasswordCheckBox.Checked ? passwordTextBox.Text : ""
                },
                files_destination = dataFolderTextBox.Text,
                media_destination = mediaFolderTextBox.Text,
                savePassword = savePasswordCheckBox.Checked
            });
            syncCommand.SaveConfig();
        }

        
    }
}
