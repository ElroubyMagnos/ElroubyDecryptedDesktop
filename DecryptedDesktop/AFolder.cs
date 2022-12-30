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
    public partial class AFolder : FileHead
    {
        public AFolder(string Name, string path, string owner) : base()
        {
            InitializeComponent();

            TheName.Text = Name;
            Path = path;
            Owner = owner;
        }

        private void All_Click(object sender, EventArgs e)
        {
            if (!Main.CurrentSelected.Contains(this))
            {
                Main.CurrentSelected.Clear();
                Main.CurrentSelected.Add(this);
            }
            else Main.CurrentSelected.Remove(this);
        }

        private void AFolder_DoubleClick(object sender, EventArgs e)
        {
            Login.MainForm.CurrentDIR.Text += TheName.Text + "\\";
        }
    }
}
