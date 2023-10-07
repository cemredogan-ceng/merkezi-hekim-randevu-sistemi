
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class doktorAnasayfa
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.muayeneListesiGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıHastaMuayeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneBilgileriniGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receteGirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receteleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilacaGöreHastaListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muayeneListesiGörüntüleToolStripMenuItem,
            this.kayıtlıHastaMuayeneToolStripMenuItem,
            this.muayeneBilgileriniGörüntüleToolStripMenuItem,
            this.receteGirToolStripMenuItem,
            this.receteleriListeleToolStripMenuItem,
            this.ilacaGöreHastaListeleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1366, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // muayeneListesiGörüntüleToolStripMenuItem
            // 
            this.muayeneListesiGörüntüleToolStripMenuItem.Name = "muayeneListesiGörüntüleToolStripMenuItem";
            this.muayeneListesiGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.muayeneListesiGörüntüleToolStripMenuItem.Text = "Muayene Bilgilerini Gir";
            this.muayeneListesiGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.muayeneListesiGörüntüleToolStripMenuItem_Click);
            // 
            // kayıtlıHastaMuayeneToolStripMenuItem
            // 
            this.kayıtlıHastaMuayeneToolStripMenuItem.Name = "kayıtlıHastaMuayeneToolStripMenuItem";
            this.kayıtlıHastaMuayeneToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.kayıtlıHastaMuayeneToolStripMenuItem.Text = "Kayıtlı Hasta Muayene";
            this.kayıtlıHastaMuayeneToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıHastaMuayeneToolStripMenuItem_Click);
            // 
            // muayeneBilgileriniGörüntüleToolStripMenuItem
            // 
            this.muayeneBilgileriniGörüntüleToolStripMenuItem.Name = "muayeneBilgileriniGörüntüleToolStripMenuItem";
            this.muayeneBilgileriniGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(258, 29);
            this.muayeneBilgileriniGörüntüleToolStripMenuItem.Text = "Muayene Bilgilerini Görüntüle";
            this.muayeneBilgileriniGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.muayeneBilgileriniGörüntüleToolStripMenuItem_Click);
            // 
            // receteGirToolStripMenuItem
            // 
            this.receteGirToolStripMenuItem.Name = "receteGirToolStripMenuItem";
            this.receteGirToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.receteGirToolStripMenuItem.Text = "Recete Girişi";
            this.receteGirToolStripMenuItem.Click += new System.EventHandler(this.receteGirToolStripMenuItem_Click);
            // 
            // receteleriListeleToolStripMenuItem
            // 
            this.receteleriListeleToolStripMenuItem.Name = "receteleriListeleToolStripMenuItem";
            this.receteleriListeleToolStripMenuItem.Size = new System.Drawing.Size(155, 29);
            this.receteleriListeleToolStripMenuItem.Text = "Receteleri Listele";
            this.receteleriListeleToolStripMenuItem.Click += new System.EventHandler(this.receteleriListeleToolStripMenuItem_Click);
            // 
            // ilacaGöreHastaListeleToolStripMenuItem
            // 
            this.ilacaGöreHastaListeleToolStripMenuItem.Name = "ilacaGöreHastaListeleToolStripMenuItem";
            this.ilacaGöreHastaListeleToolStripMenuItem.Size = new System.Drawing.Size(246, 29);
            this.ilacaGöreHastaListeleToolStripMenuItem.Text = "Sorguya Göre Reçete Listele";
            this.ilacaGöreHastaListeleToolStripMenuItem.Click += new System.EventHandler(this.ilacaGöreHastaListeleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // doktorAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1366, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "doktorAnasayfa";
            this.Text = "doktorAnasayfa";
            this.Load += new System.EventHandler(this.doktorAnasayfa_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem muayeneListesiGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receteGirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receteleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilacaGöreHastaListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneBilgileriniGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıHastaMuayeneToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}