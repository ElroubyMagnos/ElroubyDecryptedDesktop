namespace DecryptedDesktop
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
            this.Back = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_Folder = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiktokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeSpace = new System.Windows.Forms.FlowLayoutPanel();
            this.FileCon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.OP = new System.Windows.Forms.OpenFileDialog();
            this.FD = new System.Windows.Forms.FolderBrowserDialog();
            this.CurrentDIR = new System.Windows.Forms.TextBox();
            this.MenuStrip.SuspendLayout();
            this.FileCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.RefreshFiles,
            this.fileToolStripMenuItem,
            this.Menu_Edit,
            this.userToolStripMenuItem,
            this.programToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 2;
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
            this.Import_Folder.Click += new System.EventHandler(this.Import_Folder_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
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
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut,
            this.Copy,
            this.Paste,
            this.Delete,
            this.toolStripSeparator1,
            this.SelectAll});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(39, 20);
            this.Menu_Edit.Text = "Edit";
            this.Menu_Edit.Click += new System.EventHandler(this.Menu_Edit_Click);
            // 
            // Cut
            // 
            this.Cut.Image = global::DecryptedDesktop.Properties.Resources.cut;
            this.Cut.Name = "Cut";
            this.Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cut.Size = new System.Drawing.Size(164, 22);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Image = global::DecryptedDesktop.Properties.Resources.copy;
            this.Copy.Name = "Copy";
            this.Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copy.Size = new System.Drawing.Size(164, 22);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Image = global::DecryptedDesktop.Properties.Resources.past;
            this.Paste.Name = "Paste";
            this.Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Paste.Size = new System.Drawing.Size(164, 22);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Delete
            // 
            this.Delete.Image = global::DecryptedDesktop.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Delete.Size = new System.Drawing.Size(164, 22);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // SelectAll
            // 
            this.SelectAll.Image = global::DecryptedDesktop.Properties.Resources.selectall;
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAll.Size = new System.Drawing.Size(164, 22);
            this.SelectAll.Text = "Select All";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.userout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.mine;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.youtube;
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            // 
            // linkedInToolStripMenuItem
            // 
            this.linkedInToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.LinkedIn;
            this.linkedInToolStripMenuItem.Name = "linkedInToolStripMenuItem";
            this.linkedInToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.linkedInToolStripMenuItem.Text = "LinkedIn";
            // 
            // facebookPageToolStripMenuItem
            // 
            this.facebookPageToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.Facebook;
            this.facebookPageToolStripMenuItem.Name = "facebookPageToolStripMenuItem";
            this.facebookPageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.facebookPageToolStripMenuItem.Text = "Facebook Page";
            // 
            // facebookAccountToolStripMenuItem
            // 
            this.facebookAccountToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.Facebook;
            this.facebookAccountToolStripMenuItem.Name = "facebookAccountToolStripMenuItem";
            this.facebookAccountToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.facebookAccountToolStripMenuItem.Text = "Facebook Account";
            // 
            // tiktokToolStripMenuItem
            // 
            this.tiktokToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.tiktok;
            this.tiktokToolStripMenuItem.Name = "tiktokToolStripMenuItem";
            this.tiktokToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tiktokToolStripMenuItem.Text = "Tiktok";
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Image = global::DecryptedDesktop.Properties.Resources.Instagram;
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.instagramToolStripMenuItem.Text = "Instagram";
            // 
            // DeSpace
            // 
            this.DeSpace.AutoScroll = true;
            this.DeSpace.ContextMenuStrip = this.FileCon;
            this.DeSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeSpace.Location = new System.Drawing.Point(0, 50);
            this.DeSpace.Name = "DeSpace";
            this.DeSpace.Size = new System.Drawing.Size(800, 400);
            this.DeSpace.TabIndex = 1;
            // 
            // FileCon
            // 
            this.FileCon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Cut,
            this.MS_Copy,
            this.MS_Paste,
            this.MS_Delete,
            this.MS_SelectAll});
            this.FileCon.Name = "FileCon";
            this.FileCon.Size = new System.Drawing.Size(123, 114);
            this.FileCon.Opening += new System.ComponentModel.CancelEventHandler(this.FileCon_Opening);
            // 
            // MS_Cut
            // 
            this.MS_Cut.Name = "MS_Cut";
            this.MS_Cut.Size = new System.Drawing.Size(122, 22);
            this.MS_Cut.Text = "Cut";
            this.MS_Cut.Click += new System.EventHandler(this.MS_Cut_Click);
            // 
            // MS_Copy
            // 
            this.MS_Copy.Name = "MS_Copy";
            this.MS_Copy.Size = new System.Drawing.Size(122, 22);
            this.MS_Copy.Text = "Copy";
            this.MS_Copy.Click += new System.EventHandler(this.MS_Copy_Click);
            // 
            // MS_Paste
            // 
            this.MS_Paste.Name = "MS_Paste";
            this.MS_Paste.Size = new System.Drawing.Size(122, 22);
            this.MS_Paste.Text = "Paste";
            this.MS_Paste.Click += new System.EventHandler(this.MS_Paste_Click);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(122, 22);
            this.MS_Delete.Text = "Delete";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // MS_SelectAll
            // 
            this.MS_SelectAll.Name = "MS_SelectAll";
            this.MS_SelectAll.Size = new System.Drawing.Size(122, 22);
            this.MS_SelectAll.Text = "Select All";
            this.MS_SelectAll.Click += new System.EventHandler(this.MS_SelectAll_Click);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.FileCon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Import;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
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
        public System.Windows.Forms.TextBox CurrentDIR;
        private System.Windows.Forms.ToolStripMenuItem Back;
        private System.Windows.Forms.ToolStripMenuItem RefreshFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem NewFolder;
        private System.Windows.Forms.ContextMenuStrip FileCon;
        private System.Windows.Forms.ToolStripMenuItem MS_Cut;
        private System.Windows.Forms.ToolStripMenuItem MS_Copy;
        private System.Windows.Forms.ToolStripMenuItem MS_Paste;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.ToolStripMenuItem MS_SelectAll;
    }
}

