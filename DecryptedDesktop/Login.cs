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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + "\\Users"))
                Directory.CreateDirectory(Application.StartupPath + "\\Users");

            if (!Directory.Exists(Application.StartupPath + "\\Desktop"))
                Directory.CreateDirectory(Application.StartupPath + "\\Desktop");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static Main MainForm = null;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo DI = new DirectoryInfo(Application.StartupPath + "\\Users");
            FileInfo[] FI = DI.GetFiles();

            bool Found = false;

            foreach (FileInfo fi in FI)
            {
                if (fi.Name.Split('.')[0] == Username.Text)
                {
                    Found = true;
                    break;
                }
            }

            if (Found)
            {
                string Data = File.ReadAllText(Application.StartupPath + $"\\Users\\{Username.Text}.usr").Decrypt();

                string UN = Data.GETLine("UN");

                if (UN != Username.Text)
                {
                    Show();
                    MessageBox.Show("User file Corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string PSS = Data.GETLine("PSS");

                if (Password.Text == PSS)
                {
                    Hide();
                    MainForm = new Main();
                    Main.User = new User(Username.Text, Password.Text);
                    MainForm.ShowDialog();
                    Show();
                }
            }
            else
            {
                MessageBox.Show("User not found", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        RegisterWindow RW = null;
        private void Register_Click(object sender, EventArgs e)
        {
            Hide();
            RW = new RegisterWindow();
            RW.ShowDialog();
            Show();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
