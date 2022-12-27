using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecryptedDesktop
{
    public partial class AFile : FileHead
    {
        public string Owner = null;
        public string Path = "";
        public AFile(string Name, string path, string owner)
        {
            InitializeComponent();

            TheName.Text = Name;
            Path = path;
            Owner = owner;
        }
    }
}
