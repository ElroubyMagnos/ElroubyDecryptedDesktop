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
using System.Reflection.Emit;

namespace DecryptedDesktop
{
    public partial class Main : Form
    {
        public static User User { get; set; }
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
                    File.WriteAllText(Application.StartupPath + $"\\Desktop\\{User.Username}\\{CurrentDIR.Text}" + OP.FileName.Split('\\').Last() + ".roby", Image.FromFile(OP.FileName).EncryptImage());

                    AFile F = new AFile(OP.FileName.Split('\\').Last(), Application.StartupPath + $"\\Desktop\\{User.Username}\\" + OP.FileName.Split('\\').Last(), User.Username);
                    DeSpace.Controls.Add(F);
                } 
                else File.WriteAllText(Application.StartupPath + $"\\Desktop\\{User.Username}\\{CurrentDIR.Text}" + OP.FileName.Split('\\').Last() + ".roby", File.ReadAllBytes(OP.FileName).EncFile());
            }

            CurrentDIR_TextChanged(sender, e);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            string TheDIR = CurrentDIR.Text;
            if (TheDIR.Last() == '\\')
            {
                TheDIR = TheDIR.Remove(TheDIR.Length - 1, 1);
            }

            string BackDIR = "";

            string[] TheDirX = TheDIR.Split('\\');

            int SlashCount = 0;

            for (int i = 0; i < TheDIR.Length; i++)
            {
                if (TheDIR[i] == '\\') SlashCount++;
                if (TheDirX.Length - 1 == SlashCount)
                    break;
                BackDIR += TheDIR[i];
            }

            CurrentDIR.Text = BackDIR;
        }

        private void CurrentDIR_TextChanged(object sender, EventArgs e)
        {
            DirectoryInfo DI = new DirectoryInfo(Application.StartupPath + $"\\Desktop\\{User.Username}\\" + CurrentDIR.Text + "\\");
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
                            TheFile.PB.BackgroundImage = File.ReadAllText(Finfo.FullName).DecryptImage();
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

        private void NewFolder_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Desktop\\" + User.Username + "\\" + CurrentDIR.Text + "\\New Folder"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Desktop\\" + User.Username + "\\" + CurrentDIR.Text + "\\New Folder");
                CurrentDIR_TextChanged(sender, e);
            }
            else MessageBox.Show("Folder already exist", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                foreach (FileHead FH in CurrentSelected)
                {
                    if (FH is AFile)
                    {
                        string[] RN = FH.TheName.Text.Split('.');
                        string RealName = RN[0] + "." + RN[1];
                        string Extension = FH.TheName.Text.Substring(FH.TheName.Text.IndexOf(".")).Split('.')[1];
                        if (Extension.IsImage())
                        {
                            File.ReadAllText(FH.Path).DecryptImage().Save(FBD.SelectedPath + "\\" + RealName);
                        }
                        else
                        {
                            File.WriteAllBytes(FBD.SelectedPath + "\\" + RealName, File.ReadAllText(FH.Path).DecFile());
                        }
                    }
                    else
                    {
                        string FullBasket = FH.Path.Terminator(FBD.SelectedPath, User.Username);
                        Directory.CreateDirectory(FullBasket);
                        foreach (string dirPath in Directory.GetDirectories(FH.Path, "*", SearchOption.AllDirectories))
                        {
                            Directory.CreateDirectory(dirPath.Replace(FH.Path, FullBasket));
                        }

                        foreach (string newPath in Directory.GetFiles(FH.Path, "*.roby", SearchOption.AllDirectories))
                        {
                            if (Path.GetExtension(newPath.Replace(".roby", "")).Replace(".", "").IsImage())
                            {
                                File.ReadAllText(newPath).DecryptImage().Save(newPath.Terminator(FBD.SelectedPath, User.Username).Replace(".roby\\", ""));
                            }
                            else File.WriteAllBytes(newPath.Terminator(FBD.SelectedPath, User.Username).Replace(".roby\\", ""), File.ReadAllText(newPath).DecFile()); 
                        }
                    }
                }
            }
        }

        private void Import_Folder_Click(object sender, EventArgs e)
        {
            if (FD.ShowDialog() == DialogResult.OK)
            {
                string FullBasket = Application.StartupPath + "\\Desktop\\" + User.Username + "\\" + CurrentDIR.Text + "\\" + FD.SelectedPath.Split('\\').Last();
                Directory.CreateDirectory(FullBasket);

                string MainDIR = FullBasket.Split('\\').Last();
                foreach (string DIR in Directory.GetDirectories(FD.SelectedPath, "*", SearchOption.AllDirectories))
                {
                    string TheDIR = DIR.Substring(DIR.LastIndexOf(MainDIR));
                    TheDIR = Application.StartupPath + "\\Desktop\\" + User.Username + "\\" + CurrentDIR.Text + "\\" + TheDIR;
                    Directory.CreateDirectory(TheDIR);
                }

                foreach (string FileDIR in Directory.GetFiles(FD.SelectedPath, "*.*", SearchOption.AllDirectories))
                {
                    string TheDIR = FileDIR.Substring(FileDIR.LastIndexOf(MainDIR));
                    TheDIR = Application.StartupPath + "\\Desktop\\" + User.Username + "\\" + CurrentDIR.Text + "\\" + TheDIR;

                    if (Path.GetExtension(FileDIR).Replace(".", "").IsImage())
                        File.WriteAllText(TheDIR + ".roby", Image.FromFile(FileDIR).EncryptImage());
                    else File.WriteAllText(TheDIR + ".roby", File.ReadAllBytes(FileDIR).EncFile());
                }
            }

            CurrentDIR_TextChanged(sender, e);
        }

        private void FileCon_Opening(object sender, CancelEventArgs e)
        {
            MS_Paste.Enabled = MyClipBoard.All.Count > 0;
        }

        private void Menu_Edit_Click(object sender, EventArgs e)
        {
            Paste.Enabled = MyClipBoard.All.Count > 0;
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            if (CurrentSelected.Count == 1)
            {
                MyClipBoard.All.Add(CurrentSelected[0], MyClipBoard.OperationType.Cut);
            }
            else if (CurrentSelected.Count != 0)
            {
                MyClipBoard.All.GroupAdd(MyClipBoard.OperationType.Cut, CurrentSelected.ToArray());
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (CurrentSelected.Count == 1)
            {
                MyClipBoard.All.Add(CurrentSelected[0], MyClipBoard.OperationType.Copy);
            }
            else if (CurrentSelected.Count != 0)
            {
                MyClipBoard.All.GroupAdd(MyClipBoard.OperationType.Copy, CurrentSelected.ToArray());
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyClipBoard.All.Clear();
        }

        private void MS_Cut_Click(object sender, EventArgs e)
        {
            Cut_Click(sender, e);
        }

        private void MS_Copy_Click(object sender, EventArgs e)
        {
            Copy_Click(sender, e);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<FileHead, MyClipBoard.OperationType> OP in MyClipBoard.All)
            {
                string PastePath = Application.StartupPath + $"\\Desktop\\{User.Username}\\{CurrentDIR.Text}\\{OP.Key.TheName.Text}";
                if (OP.Key is AFile)
                {
                    if (File.Exists(PastePath))
                    {
                        DialogResult Result = MessageBox.Show("The File is already exist with the same path, Do you want to replace it?", "Wait", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Result == DialogResult.Cancel) return;
                    }
                    File.WriteAllBytes(PastePath, File.ReadAllBytes(OP.Key.Path));

                    if (OP.Value == MyClipBoard.OperationType.Cut)
                    {
                        File.Delete(OP.Key.Path);
                    }
                }
                else
                {
                    CopyFilesRecursively(OP.Key.Path, PastePath);

                    void CopyFilesRecursively(string sourcePath, string targetPath)
                    {
                        //Now Create all of the directories
                        foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                        {
                            Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                        }

                        //Copy all the files & Replaces any files with the same name
                        foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                        {
                            File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                        }

                        if (OP.Value == MyClipBoard.OperationType.Cut)
                            Directory.Delete(OP.Key.Path, true);
                    }
                }
            }

            MyClipBoard.All.Clear();
            CurrentDIR_TextChanged(sender, e);
        }

        private void MS_Paste_Click(object sender, EventArgs e)
        {
            Paste_Click(sender, e);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (FileHead FH in CurrentSelected)
            {
                if (FH is AFile)
                    File.Delete(FH.Path);
                else DeleteDirectory(FH.Path);
            }

            CurrentDIR_TextChanged(sender, e);
        }

        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        private void MS_Delete_Click(object sender, EventArgs e)
        {
            Delete_Click(sender, e);
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            foreach (AFile AF in DeSpace.Controls.OfType<AFile>())
            {
                CurrentSelected.Add(AF);
            }
        }

        private void MS_SelectAll_Click(object sender, EventArgs e)
        {
            SelectAll_Click(sender, e);
        }
    }

    public class ListVoid<T> : List<T>
    {
        public ListVoid() : base()
        {

        }

        public new void Add(T FH)
        {
            base.Add(FH);
            (FH as FileHead).PB.Image = Properties.Resources.Selected;
        }

        public new void Remove(T FH)
        {
            base.Remove(FH);
            (FH as FileHead).PB.Image = null;
        }

        public new void Clear()
        {
            List<T> Removed = new List<T>();
            foreach (T FH in this)
            {
                Removed.Add(FH);
            }
            foreach (T FH in Removed)
            {
                Remove(FH);
            }
        }
    }
}
