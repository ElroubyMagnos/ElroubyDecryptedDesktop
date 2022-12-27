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
        public string Path = "";
        public FileHead() 
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FileHead
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FileHead";
            this.ResumeLayout(false);

        }
    }
}
