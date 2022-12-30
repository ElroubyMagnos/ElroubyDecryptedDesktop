using Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecryptedDesktop
{
    public partial class AFile : FileHead
    {
        public AFile(string Name, string path, string owner)
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
                Main.CurrentSelected.Add(this);

                List<FileHead> Removed = new List<FileHead>();

                foreach (FileHead FH in Main.CurrentSelected)
                {
                    if (FH is AFolder)
                        Removed.Add(FH);
                }

                foreach (FileHead FH in Removed)
                {
                    Main.CurrentSelected.Remove(FH);
                }
            }
            else Main.CurrentSelected.Remove(this);
        }

        private void All_DoubleClick(object sender, EventArgs e)
        {
            string Extension = TheName.Text.Substring(TheName.Text.IndexOf(".")).Split('.')[1];
            if (Extension.IsImage())
            {
                Exporter.FileName = TheName.Text.Split('.')[0] + "." + TheName.Text.Split('.')[1];
                if (Exporter.ShowDialog() == DialogResult.OK)
                {
                    File.ReadAllText(Path).DecryptImage().Save(Exporter.FileName);
                }
            }
            else
            {
                Exporter.FileName = TheName.Text.Split('.')[0] + "." + TheName.Text.Split('.')[1];
                if (Exporter.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(Exporter.FileName, File.ReadAllText(Path).DecFile());
                }
            }
        }
    }
}
