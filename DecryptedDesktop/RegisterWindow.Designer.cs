namespace DecryptedDesktop
{
    partial class RegisterWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterWindow));
            this.CPassword = new ElroubyLibrary.TextBoxes.PasswordBox();
            this.Password = new ElroubyLibrary.TextBoxes.PasswordBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterButton = new ElroubyLibrary.Buttons.FlatButton();
            this.SuspendLayout();
            // 
            // CPassword
            // 
            this.CPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPassword.Location = new System.Drawing.Point(115, 89);
            this.CPassword.MaxLength = 1000;
            this.CPassword.Name = "CPassword";
            this.CPassword.NumericOnly = false;
            this.CPassword.PasswordChar = '✦';
            this.CPassword.ShortcutsEnabled = false;
            this.CPassword.ShowButtonLeft = false;
            this.CPassword.Size = new System.Drawing.Size(100, 22);
            this.CPassword.TabIndex = 2;
            this.CPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPassword_KeyDown);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(115, 52);
            this.Password.MaxLength = 1000;
            this.Password.Name = "Password";
            this.Password.NumericOnly = false;
            this.Password.PasswordChar = '✦';
            this.Password.ShortcutsEnabled = false;
            this.Password.ShowButtonLeft = false;
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 1;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPassword_KeyDown);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(115, 17);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 0;
            this.Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password:";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Location = new System.Drawing.Point(140, 127);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 160);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.CPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elrouby DD: Register";
            this.Load += new System.EventHandler(this.RegisterWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElroubyLibrary.TextBoxes.PasswordBox CPassword;
        private ElroubyLibrary.TextBoxes.PasswordBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ElroubyLibrary.Buttons.FlatButton RegisterButton;
    }
}