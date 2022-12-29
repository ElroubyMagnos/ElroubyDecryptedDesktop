namespace DecryptedDesktop
{
    partial class AFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TheName = new System.Windows.Forms.Label();
            this.Exporter = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic
            // 
            this.Pic.BackgroundImage = global::DecryptedDesktop.Properties.Resources.File;
            this.Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic.Size = new System.Drawing.Size(100, 78);
            this.Pic.Click += new System.EventHandler(this.All_Click);
            this.Pic.DoubleClick += new System.EventHandler(this.All_DoubleClick);
            // 
            // TheName
            // 
            this.TheName.AutoSize = true;
            this.TheName.Location = new System.Drawing.Point(3, 81);
            this.TheName.Name = "TheName";
            this.TheName.Size = new System.Drawing.Size(35, 13);
            this.TheName.TabIndex = 1;
            this.TheName.Text = "Name";
            this.TheName.Click += new System.EventHandler(this.All_Click);
            this.TheName.DoubleClick += new System.EventHandler(this.All_DoubleClick);
            // 
            // AFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.TheName);
            this.Name = "AFile";
            this.Size = new System.Drawing.Size(100, 100);
            this.Click += new System.EventHandler(this.All_Click);
            this.DoubleClick += new System.EventHandler(this.All_DoubleClick);
            this.Controls.SetChildIndex(this.TheName, 0);
            this.Controls.SetChildIndex(this.Pic, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label TheName;
        private System.Windows.Forms.SaveFileDialog Exporter;
    }
}
