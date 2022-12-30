using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecryptedDesktop
{
    public class FileHead : UserControl
    {
        public string Owner = null;
        public PictureBox PB = new PictureBox();
        public Label TheName;
        public string Path = "";
        public FileHead() 
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.PB = new System.Windows.Forms.PictureBox();
            this.TheName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(0, 0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(143, 94);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            // 
            // TheName
            // 
            this.TheName.AutoSize = true;
            this.TheName.Location = new System.Drawing.Point(3, 97);
            this.TheName.Name = "TheName";
            this.TheName.Size = new System.Drawing.Size(35, 13);
            this.TheName.TabIndex = 2;
            this.TheName.Text = "Name";
            // 
            // FileHead
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.TheName);
            this.Controls.Add(this.PB);
            this.Name = "FileHead";
            this.Size = new System.Drawing.Size(143, 117);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
