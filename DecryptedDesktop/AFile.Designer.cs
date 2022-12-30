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
            this.Exporter = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackgroundImage = global::DecryptedDesktop.Properties.Resources.File;
            this.PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB.Size = new System.Drawing.Size(100, 78);
            this.PB.Click += new System.EventHandler(this.All_Click);
            this.PB.DoubleClick += new System.EventHandler(this.All_DoubleClick);
            // 
            // TheName
            // 
            this.TheName.Location = new System.Drawing.Point(3, 81);
            // 
            // AFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Name = "AFile";
            this.Size = new System.Drawing.Size(100, 100);
            this.Click += new System.EventHandler(this.All_Click);
            this.DoubleClick += new System.EventHandler(this.All_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog Exporter;
    }
}
