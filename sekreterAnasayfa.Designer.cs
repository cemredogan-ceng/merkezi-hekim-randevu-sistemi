
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class sekreterAnasayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçBilgileriniGirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receteleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.ilaçBilgileriniGirToolStripMenuItem,
            this.receteleriListeleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.hastaKayıtToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayıtToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtToolStripMenuItem_Click);
            // 
            // ilaçBilgileriniGirToolStripMenuItem
            // 
            this.ilaçBilgileriniGirToolStripMenuItem.Name = "ilaçBilgileriniGirToolStripMenuItem";
            this.ilaçBilgileriniGirToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.ilaçBilgileriniGirToolStripMenuItem.Text = "İlaç Bilgilerini Gir";
            this.ilaçBilgileriniGirToolStripMenuItem.Click += new System.EventHandler(this.ilaçBilgileriniGirToolStripMenuItem_Click);
            // 
            // receteleriListeleToolStripMenuItem
            // 
            this.receteleriListeleToolStripMenuItem.Name = "receteleriListeleToolStripMenuItem";
            this.receteleriListeleToolStripMenuItem.Size = new System.Drawing.Size(155, 32);
            this.receteleriListeleToolStripMenuItem.Text = "Receteleri Listele";
            this.receteleriListeleToolStripMenuItem.Click += new System.EventHandler(this.receteleriListeleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(64, 32);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // sekreterAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sekreterAnasayfa";
            this.Text = "sekreterAnasayfa";
            this.Load += new System.EventHandler(this.sekreterAnasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçBilgileriniGirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receteleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}