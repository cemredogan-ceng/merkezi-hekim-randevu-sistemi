
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class Receteleri_Listele
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
            this.dataGridViewReceteleriListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceteleriListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReceteleriListele
            // 
            this.dataGridViewReceteleriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceteleriListele.Location = new System.Drawing.Point(37, 42);
            this.dataGridViewReceteleriListele.Name = "dataGridViewReceteleriListele";
            this.dataGridViewReceteleriListele.RowHeadersWidth = 62;
            this.dataGridViewReceteleriListele.RowTemplate.Height = 28;
            this.dataGridViewReceteleriListele.Size = new System.Drawing.Size(1022, 424);
            this.dataGridViewReceteleriListele.TabIndex = 0;
            // 
            // Receteleri_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 478);
            this.Controls.Add(this.dataGridViewReceteleriListele);
            this.Name = "Receteleri_Listele";
            this.Text = "Receteleri_Listele";
            this.Load += new System.EventHandler(this.Receteleri_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceteleriListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReceteleriListele;
    }
}