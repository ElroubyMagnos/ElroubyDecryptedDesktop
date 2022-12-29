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
using System.Threading;

namespace DecryptedDesktop
{
    public partial class Main : Form
    {
        public static User User { get; set; }
        static FileHead _CS;
        public static ListVoid<FileHead> CurrentSelected = new ListVoid<FileHead>();
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
                    File.WriteAllText(Application.StartupPath + $"\\Desktop\\{User.Username}\\" + OP.FileName.Split('\\').Last() + ".roby", Image.FromFile(OP.FileName).EncryptImage());

                    AFile F = new AFile(OP.FileName.Split('\\').Last(), Application.StartupPath + $"\\Desktop\\{User.Username}\\" + OP.FileName.Split('\\').Last(), User.Username);
                    DeSpace.Controls.Add(F);
                } 
                else File.WriteAllText(Application.StartupPath + $"\\Desktop\\{User.Username}\\" + OP.FileName.Split('\\').Last() + ".roby", File.ReadAllBytes(OP.FileName).EncFile());
            }

            CurrentDIR_TextChanged(sender, e);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            TextBox CD = Login.MainForm.CurrentDIR;
            string[] CDText = CD.Text.Split('\\');
            if (!CD.Text.Contains("\\")) 
                CD.Text = "";
            else if (CDText.Last().Length == 0)
            {
                CD.Text = CD.Text.Replace(CDText[CDText.Count() - 2] + "\\", "");
            }
        }

        private void CurrentDIR_TextChanged(object sender, EventArgs e)
        {
            DirectoryInfo DI = new DirectoryInfo(Application.StartupPath + $"\\Desktop\\{User.Username}\\" + CurrentDIR.Text);
            FileInfo[] AllFiles = DI.GetFiles();
            DirectoryInfo[] AllFolders = DI.GetDirectories();

            List<FileInfo> AllrobyFiles = new List<FileInfo>();

            foreach (FileInfo Filei in AllFiles)
            {
                if (Path.GetExtension(Filei.Name) == ".roby")
                    AllrobyFiles.Add(Filei);
            }

            DeSpace.Controls.Clear();

            foreach (DirectoryInfo Dinfo in AllFolders)
            {
                DeSpace.Controls.Add(new AFolder(Dinfo.Name, Dinfo.FullName, User.Username));
            }

            foreach (FileInfo Finfo in AllrobyFiles)
            {
                if (Path.GetExtension(Finfo.Name) == ".roby")
                {
                    if (Finfo.Name.Split('.')[1].IsImage())
                    {
                        if (Finfo.FullName.ReadImageOwner() == User.Username && Finfo.FullName.ReadImageOwnerPassword() == User.Password)
                        {
                            AFile TheFile = new AFile(Finfo.Name, Finfo.FullName, User.Username);
                            DeSpace.Controls.Add(TheFile);
                            TheFile.Pic.BackgroundImage = File.ReadAllText(Finfo.FullName).DecryptImage();
                        }
                    }
                    else if (Finfo.FullName.ReadOwner() == User.Username && Finfo.FullName.ReadOwnerPassword() == User.Password)
                    {
                        DeSpace.Controls.Add(new AFile(Finfo.Name, Finfo.FullName, User.Username));
                    }
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + $"\\Desktop\\{User.Username}"))
                Directory.CreateDirectory(Application.StartupPath + $"\\Desktop\\{User.Username}");
            CurrentDIR_TextChanged(sender, e);
        }

        private void RefreshFiles_Click(object sender, EventArgs e)
        {
            CurrentDIR_TextChanged(sender, e);
        }

        private void Import_Click(object sender, EventArgs e)
        {

        }
    }

    public class ListVoid<FileHead> : List<FileHead>
    {
        public ListVoid() : base()
        {

        }

        public new void Add(FileHead FH)
        {
            base.Add(FH);
            FH.Pic.Image = Properties.Resources.Selected;
        }

        public new void Remove(FileHead FH)
        {
            base.Remove(FH);
            FH.Pic.Image = null;
        }
    }
}
