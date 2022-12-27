using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Crypto;

namespace DecryptedDesktop
{
    public partial class Main : Form
    {
        public static User User = null;
        public static AFile CurrentSelected { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void Import_File_Click(object sender, EventArgs e)
        {
            if (OP.ShowDialog() == DialogResult.OK)
            {
                string Extension = Path.GetExtension(OP.FileName).Replace(".", "");
                if (Extension == "jpg" || Extension == "png" || Extension == "bmp" || Extension == "gif" || Extension == "tga" || Extension == "pic" || Extension == "tiff")
                {
                    Image I = Image.FromFile(OP.FileName);
                    string TheImage = I.ImageToString().StringToByte().EncFile();
                    File.WriteAllText(Application.StartupPath + "\\Desktop\\" + OP.FileName.Split('\\').Last() + ".roby", TheImage);

                    AFile F = new AFile(OP.FileName.Split('\\').Last(), Application.StartupPath + "\\Desktop\\" + OP.FileName.Split('\\').Last(), User.Username);
                    DeSpace.Controls.Add(F);
                } 
                else File.WriteAllText(Application.StartupPath + "\\Desktop\\" + OP.FileName.Split('\\').Last() + ".roby", File.ReadAllBytes(OP.FileName).EncFile());
            }
        }
    }
}
