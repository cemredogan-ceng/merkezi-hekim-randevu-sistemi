
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class kayıtlıHastaMuayene
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.textBoxMuayeneTarihi = new System.Windows.Forms.TextBox();
            this.textBoxsıraNo = new System.Windows.Forms.TextBox();
            this.textBoxReceteNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Muayene Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sıra No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recete No:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(545, 369);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(126, 40);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(178, 32);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(100, 26);
            this.textBoxTc.TabIndex = 5;
            // 
            // textBoxMuayeneTarihi
            // 
            this.textBoxMuayeneTarihi.Location = new System.Drawing.Point(178, 89);
            this.textBoxMuayeneTarihi.Name = "textBoxMuayeneTarihi";
            this.textBoxMuayeneTarihi.Size = new System.Drawing.Size(100, 26);
            this.textBoxMuayeneTarihi.TabIndex = 6;
            // 
            // textBoxsıraNo
            // 
            this.textBoxsıraNo.Location = new System.Drawing.Point(178, 209);
            this.textBoxsıraNo.Name = "textBoxsıraNo";
            this.textBoxsıraNo.Size = new System.Drawing.Size(100, 26);
            this.textBoxsıraNo.TabIndex = 7;
            // 
            // textBoxReceteNo
            // 
            this.textBoxReceteNo.Location = new System.Drawing.Point(178, 145);
            this.textBoxReceteNo.Name = "textBoxReceteNo";
            this.textBoxReceteNo.Size = new System.Drawing.Size(100, 26);
            this.textBoxReceteNo.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.textBoxTc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxsıraNo);
            this.panel1.Controls.Add(this.textBoxReceteNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxMuayeneTarihi);
            this.panel1.Location = new System.Drawing.Point(182, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 279);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(161, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 46);
            this.label5.TabIndex = 11;
            this.label5.Text = "Muyene Bilgileri Girişi";
            // 
            // kayıtlıHastaMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonKaydet);
            this.Name = "kayıtlıHastaMuayene";
            this.Text = "kayıtlıHastaMuayene";
            this.Load += new System.EventHandler(this.kayıtlıHastaMuayene_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.TextBox textBoxMuayeneTarihi;
        private System.Windows.Forms.TextBox textBoxsıraNo;
        private System.Windows.Forms.TextBox textBoxReceteNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}