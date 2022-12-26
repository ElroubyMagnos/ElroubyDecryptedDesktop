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
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterWindow_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Username.Text.Length > 3)
            {
                if (Password.Text == CPassword.Text)
                {
                    if (!File.Exists(Application.StartupPath + $"\\Users\\{Username.Text}.usr"))
                    {
                        string Data = $"UN={Username.Text}\n" +
                                                $"PSS={Password.Text}";

                        File.WriteAllText(Application.StartupPath + $"\\Users\\{Username.Text}.usr", Data.Encrypt());

                        Close();

                        MessageBox.Show("Account created successfully", "Congratualation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Username already exists!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Password is not matching the two fields", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username must be more than 3 characters", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterButton_Click(sender, e);
            }
        }
    }
}
