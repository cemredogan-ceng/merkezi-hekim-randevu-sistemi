
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class IlacBilgisiGir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxilacTip = new System.Windows.Forms.TextBox();
            this.textBoxilacAd = new System.Windows.Forms.TextBox();
            this.textBoxilacBarkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewIlacListesi = new System.Windows.Forms.DataGridView();
            this.bttnIlacEkle = new System.Windows.Forms.Button();
            this.bttnIlacListele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlacListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.textBoxilacTip);
            this.panel1.Controls.Add(this.textBoxilacAd);
            this.panel1.Controls.Add(this.textBoxilacBarkod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 275);
            this.panel1.TabIndex = 0;
            // 
            // textBoxilacTip
            // 
            this.textBoxilacTip.Location = new System.Drawing.Point(219, 177);
            this.textBoxilacTip.Name = "textBoxilacTip";
            this.textBoxilacTip.Size = new System.Drawing.Size(100, 26);
            this.textBoxilacTip.TabIndex = 5;
            // 
            // textBoxilacAd
            // 
            this.textBoxilacAd.Location = new System.Drawing.Point(219, 108);
            this.textBoxilacAd.Name = "textBoxilacAd";
            this.textBoxilacAd.Size = new System.Drawing.Size(100, 26);
            this.textBoxilacAd.TabIndex = 4;
            // 
            // textBoxilacBarkod
            // 
            this.textBoxilacBarkod.Location = new System.Drawing.Point(219, 50);
            this.textBoxilacBarkod.Name = "textBoxilacBarkod";
            this.textBoxilacBarkod.Size = new System.Drawing.Size(100, 26);
            this.textBoxilacBarkod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlaç Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlaç Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlaç Barkod No:";
            // 
            // dataGridViewIlacListesi
            // 
            this.dataGridViewIlacListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIlacListesi.Location = new System.Drawing.Point(679, 73);
            this.dataGridViewIlacListesi.Name = "dataGridViewIlacListesi";
            this.dataGridViewIlacListesi.RowHeadersWidth = 62;
            this.dataGridViewIlacListesi.RowTemplate.Height = 28;
            this.dataGridViewIlacListesi.Size = new System.Drawing.Size(409, 275);
            this.dataGridViewIlacListesi.TabIndex = 1;
            // 
            // bttnIlacEkle
            // 
            this.bttnIlacEkle.Location = new System.Drawing.Point(333, 380);
            this.bttnIlacEkle.Name = "bttnIlacEkle";
            this.bttnIlacEkle.Size = new System.Drawing.Size(125, 40);
            this.bttnIlacEkle.TabIndex = 2;
            this.bttnIlacEkle.Text = "İlaç Ekle";
            this.bttnIlacEkle.UseVisualStyleBackColor = true;
            this.bttnIlacEkle.Click += new System.EventHandler(this.bttnIlacEkle_Click);
            // 
            // bttnIlacListele
            // 
            this.bttnIlacListele.Location = new System.Drawing.Point(964, 380);
            this.bttnIlacListele.Name = "bttnIlacListele";
            this.bttnIlacListele.Size = new System.Drawing.Size(124, 40);
            this.bttnIlacListele.TabIndex = 3;
            this.bttnIlacListele.Text = "İlaçları Listele";
            this.bttnIlacListele.UseVisualStyleBackColor = true;
            this.bttnIlacListele.Click += new System.EventHandler(this.bttnIlacListele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(392, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "İlaç Kayıt Ekranı";
            // 
            // IlacBilgisiGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnIlacListele);
            this.Controls.Add(this.bttnIlacEkle);
            this.Controls.Add(this.dataGridViewIlacListesi);
            this.Controls.Add(this.panel1);
            this.Name = "IlacBilgisiGir";
            this.Text = "IlacBilgisiGir";
            this.Load += new System.EventHandler(this.IlacBilgisiGir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlacListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewIlacListesi;
        private System.Windows.Forms.TextBox textBoxilacTip;
        private System.Windows.Forms.TextBox textBoxilacAd;
        private System.Windows.Forms.TextBox textBoxilacBarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnIlacEkle;
        private System.Windows.Forms.Button bttnIlacListele;
        private System.Windows.Forms.Label label4;
    }
}