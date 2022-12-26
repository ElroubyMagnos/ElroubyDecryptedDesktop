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
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Users"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Users");
            }
            DirectoryInfo DI = new DirectoryInfo(Application.StartupPath + "\\Users");
            FileInfo[] FI = DI.GetFiles();

            bool Found = false;

            foreach (FileInfo fi in FI)
            {
                if (fi.Name == Username.Text)
                {
                    Found = true;
                    break;
                }
            }

            if (Found)
            {

            }
        }
    }
}
