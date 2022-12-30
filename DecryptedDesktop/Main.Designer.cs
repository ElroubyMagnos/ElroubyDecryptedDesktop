﻿namespace DecryptedDesktop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeSpace = new System.Windows.Forms.FlowLayoutPanel();
            this.OP = new System.Windows.Forms.OpenFileDialog();
            this.FD = new System.Windows.Forms.FolderBrowserDialog();
            this.CurrentDIR = new System.Windows.Forms.TextBox();
            this.FileLoad = new System.Windows.Forms.Timer(this.components);
            this.Back = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_Folder = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiktokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.RefreshFiles,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.userToolStripMenuItem,
            this.programToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import,
            this.Export,
            this.toolStripSeparator2,
            this.NewFolder});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.youtubeToolStripMenuItem,
            this.linkedInToolStripMenuItem,
            this.facebookPageToolStripMenuItem,
            this.facebookAccountToolStripMenuItem,
            this.tiktokToolStripMenuItem,
            this.instagramToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.Instagram;
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instagramToolStripMenuItem.Text = "Instagram";
            // 
            // DeSpace
            // 
            this.DeSpace.AutoScroll = true;
            this.DeSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeSpace.Location = new System.Drawing.Point(0, 50);
            this.DeSpace.Name = "DeSpace";
            this.DeSpace.Size = new System.Drawing.Size(800, 400);
            this.DeSpace.TabIndex = 1;
            // 
            // CurrentDIR
            // 
            this.CurrentDIR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CurrentDIR.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentDIR.Location = new System.Drawing.Point(0, 24);
            this.CurrentDIR.Name = "CurrentDIR";
            this.CurrentDIR.ReadOnly = true;
            this.CurrentDIR.Size = new System.Drawing.Size(800, 20);
            this.CurrentDIR.TabIndex = 0;
            this.CurrentDIR.TextChanged += new System.EventHandler(this.CurrentDIR_TextChanged);
            // 
            // FileLoad
            // 
            this.FileLoad.Enabled = true;
            this.FileLoad.Interval = 500;
            // 
            // Back
            // 
            this.Back.Image = global::DecryptedDesktop.Properties.Resources.back;
            this.Back.Name = "Back";
            this.Back.ShortcutKeyDisplayString = "";
            this.Back.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.Back.Size = new System.Drawing.Size(28, 20);
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RefreshFiles
            // 
            this.RefreshFiles.Image = global::DecryptedDesktop.Properties.Resources.refresh;
            this.RefreshFiles.Name = "RefreshFiles";
            this.RefreshFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.RefreshFiles.Size = new System.Drawing.Size(28, 20);
            this.RefreshFiles.Click += new System.EventHandler(this.RefreshFiles_Click);
            // 
            // Import
            // 
            this.Import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import_File,
            this.Import_Folder});
            this.Import.Image = global::DecryptedDesktop.Properties.Resources.import;
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(177, 22);
            this.Import.Text = "Import";
            // 
            // Import_File
            // 
            this.Import_File.Image = global::DecryptedDesktop.Properties.Resources.File;
            this.Import_File.Name = "Import_File";
            this.Import_File.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Import_File.Size = new System.Drawing.Size(149, 22);
            this.Import_File.Text = "File";
            this.Import_File.Click += new System.EventHandler(this.Import_File_Click);
            // 
            // Import_Folder
            // 
            this.Import_Folder.Image = global::DecryptedDesktop.Properties.Resources.Folder;
            this.Import_Folder.Name = "Import_Folder";
            this.Import_Folder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Import_Folder.Size = new System.Drawing.Size(149, 22);
            this.Import_Folder.Text = "Folder";
            // 
            // Export
            // 
            this.Export.Image = global::DecryptedDesktop.Properties.Resources.export;
            this.Export.Name = "Export";
            this.Export.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Export.Size = new System.Drawing.Size(177, 22);
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // NewFolder
            // 
            this.NewFolder.Image = global::DecryptedDesktop.Properties.Resources.New_Folder;
            this.NewFolder.Name = "NewFolder";
            this.NewFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewFolder.Size = new System.Drawing.Size(177, 22);
            this.NewFolder.Text = "New Folder";
            this.NewFolder.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.past;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.selectall;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.userout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.mine;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.youtube;
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            // 
            // linkedInToolStripMenuItem
            // 
            this.linkedInToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.LinkedIn;
            this.linkedInToolStripMenuItem.Name = "linkedInToolStripMenuItem";
            this.linkedInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkedInToolStripMenuItem.Text = "LinkedIn";
            // 
            // facebookPageToolStripMenuItem
            // 
            this.facebookPageToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.Facebook;
            this.facebookPageToolStripMenuItem.Name = "facebookPageToolStripMenuItem";
            this.facebookPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facebookPageToolStripMenuItem.Text = "Facebook Page";
            // 
            // facebookAccountToolStripMenuItem
            // 
            this.facebookAccountToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.Facebook;
            this.facebookAccountToolStripMenuItem.Name = "facebookAccountToolStripMenuItem";
            this.facebookAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facebookAccountToolStripMenuItem.Text = "Facebook Account";
            // 
            // tiktokToolStripMenuItem
            // 
            this.tiktokToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.tiktok;
            this.tiktokToolStripMenuItem.Name = "tiktokToolStripMenuItem";
            this.tiktokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiktokToolStripMenuItem.Text = "Tiktok";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentDIR);
            this.Controls.Add(this.DeSpace);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elrouby: Decrypted Desktop";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Import;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiktokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel DeSpace;
        private System.Windows.Forms.ToolStripMenuItem Import_File;
        private System.Windows.Forms.ToolStripMenuItem Import_Folder;
        private System.Windows.Forms.OpenFileDialog OP;
        private System.Windows.Forms.FolderBrowserDialog FD;
        private System.Windows.Forms.Timer FileLoad;
        public System.Windows.Forms.TextBox CurrentDIR;
        private System.Windows.Forms.ToolStripMenuItem Back;
        private System.Windows.Forms.ToolStripMenuItem RefreshFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem NewFolder;
    }
}

