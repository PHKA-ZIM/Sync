namespace PHStudIPSync
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.syncButton = new System.Windows.Forms.Button();
            this.dataFolderTextBox = new System.Windows.Forms.TextBox();
            this.browseDataFolderButton = new System.Windows.Forms.Button();
            this.saveSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.mediaFolderBrowseButton = new System.Windows.Forms.Button();
            this.mediaFolderTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.White;
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(47, 238);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(308, 28);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(47, 281);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(308, 28);
            this.passwordTextBox.TabIndex = 2;
            // 
            // syncButton
            // 
            this.syncButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(188)))), ((int)(((byte)(59)))));
            this.syncButton.FlatAppearance.BorderSize = 0;
            this.syncButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(150)))), ((int)(((byte)(47)))));
            this.syncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syncButton.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.syncButton.Location = new System.Drawing.Point(47, 436);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(308, 41);
            this.syncButton.TabIndex = 5;
            this.syncButton.Text = "Sync";
            this.syncButton.UseVisualStyleBackColor = false;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // dataFolderTextBox
            // 
            this.dataFolderTextBox.BackColor = System.Drawing.Color.White;
            this.dataFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataFolderTextBox.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.dataFolderTextBox.Location = new System.Drawing.Point(47, 332);
            this.dataFolderTextBox.Name = "dataFolderTextBox";
            this.dataFolderTextBox.Size = new System.Drawing.Size(246, 28);
            this.dataFolderTextBox.TabIndex = 3;
            // 
            // browseDataFolderButton
            // 
            this.browseDataFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(188)))), ((int)(((byte)(59)))));
            this.browseDataFolderButton.FlatAppearance.BorderSize = 0;
            this.browseDataFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(150)))), ((int)(((byte)(47)))));
            this.browseDataFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseDataFolderButton.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.browseDataFolderButton.Location = new System.Drawing.Point(299, 332);
            this.browseDataFolderButton.Name = "browseDataFolderButton";
            this.browseDataFolderButton.Size = new System.Drawing.Size(56, 28);
            this.browseDataFolderButton.TabIndex = 7;
            this.browseDataFolderButton.Text = "Browse";
            this.browseDataFolderButton.UseVisualStyleBackColor = false;
            this.browseDataFolderButton.Click += new System.EventHandler(this.browseDataFolderButton_Click);
            // 
            // saveSettingsCheckBox
            // 
            this.saveSettingsCheckBox.AutoSize = true;
            this.saveSettingsCheckBox.Location = new System.Drawing.Point(47, 413);
            this.saveSettingsCheckBox.Name = "saveSettingsCheckBox";
            this.saveSettingsCheckBox.Size = new System.Drawing.Size(92, 17);
            this.saveSettingsCheckBox.TabIndex = 8;
            this.saveSettingsCheckBox.Text = "Save Settings";
            this.saveSettingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // mediaFolderBrowseButton
            // 
            this.mediaFolderBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(188)))), ((int)(((byte)(59)))));
            this.mediaFolderBrowseButton.FlatAppearance.BorderSize = 0;
            this.mediaFolderBrowseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(150)))), ((int)(((byte)(47)))));
            this.mediaFolderBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaFolderBrowseButton.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.mediaFolderBrowseButton.Location = new System.Drawing.Point(299, 379);
            this.mediaFolderBrowseButton.Name = "mediaFolderBrowseButton";
            this.mediaFolderBrowseButton.Size = new System.Drawing.Size(56, 28);
            this.mediaFolderBrowseButton.TabIndex = 14;
            this.mediaFolderBrowseButton.Text = "Browse";
            this.mediaFolderBrowseButton.UseVisualStyleBackColor = false;
            this.mediaFolderBrowseButton.Click += new System.EventHandler(this.mediaFolderBrowseButton_Click);
            // 
            // mediaFolderTextBox
            // 
            this.mediaFolderTextBox.BackColor = System.Drawing.Color.White;
            this.mediaFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediaFolderTextBox.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.mediaFolderTextBox.Location = new System.Drawing.Point(47, 379);
            this.mediaFolderTextBox.Name = "mediaFolderTextBox";
            this.mediaFolderTextBox.Size = new System.Drawing.Size(246, 28);
            this.mediaFolderTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(188)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 203);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PHStudIPSync.Properties.Resources.sync;
            this.pictureBox3.Location = new System.Drawing.Point(131, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PHStudIPSync.Properties.Resources.studip4_logo;
            this.pictureBox2.Location = new System.Drawing.Point(229, 516);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PHStudIPSync.Properties.Resources.ph_logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 516);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mediaFolderBrowseButton);
            this.Controls.Add(this.mediaFolderTextBox);
            this.Controls.Add(this.saveSettingsCheckBox);
            this.Controls.Add(this.browseDataFolderButton);
            this.Controls.Add(this.dataFolderTextBox);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PH KA StudIP Sync";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.TextBox dataFolderTextBox;
        private System.Windows.Forms.Button browseDataFolderButton;
        private System.Windows.Forms.CheckBox saveSettingsCheckBox;
        private System.Windows.Forms.Button mediaFolderBrowseButton;
        private System.Windows.Forms.TextBox mediaFolderTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

