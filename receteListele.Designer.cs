
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class receteListele
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
            this.dataGridViewrReceteListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrReceteListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(435, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete Listesi";
            // 
            // dataGridViewrReceteListele
            // 
            this.dataGridViewrReceteListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrReceteListele.Location = new System.Drawing.Point(31, 117);
            this.dataGridViewrReceteListele.Name = "dataGridViewrReceteListele";
            this.dataGridViewrReceteListele.RowHeadersWidth = 62;
            this.dataGridViewrReceteListele.RowTemplate.Height = 28;
            this.dataGridViewrReceteListele.Size = new System.Drawing.Size(1120, 364);
            this.dataGridViewrReceteListele.TabIndex = 1;
            // 
            // receteListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 493);
            this.Controls.Add(this.dataGridViewrReceteListele);
            this.Controls.Add(this.label1);
            this.Name = "receteListele";
            this.Text = "receteListele";
            this.Load += new System.EventHandler(this.receteListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrReceteListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewrReceteListele;
    }
}