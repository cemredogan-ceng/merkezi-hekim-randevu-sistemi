
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class muayeneBilgileriniGörüntüle
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
            this.dataGridViewMuayeneGörüntüle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuayeneGörüntüle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMuayeneGörüntüle
            // 
            this.dataGridViewMuayeneGörüntüle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuayeneGörüntüle.Location = new System.Drawing.Point(38, 46);
            this.dataGridViewMuayeneGörüntüle.Name = "dataGridViewMuayeneGörüntüle";
            this.dataGridViewMuayeneGörüntüle.RowHeadersWidth = 62;
            this.dataGridViewMuayeneGörüntüle.RowTemplate.Height = 28;
            this.dataGridViewMuayeneGörüntüle.Size = new System.Drawing.Size(979, 414);
            this.dataGridViewMuayeneGörüntüle.TabIndex = 0;
            this.dataGridViewMuayeneGörüntüle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // muayeneBilgileriniGörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 489);
            this.Controls.Add(this.dataGridViewMuayeneGörüntüle);
            this.Name = "muayeneBilgileriniGörüntüle";
            this.Text = "muayeneBilgileriniGörüntüle";
            this.Load += new System.EventHandler(this.muayeneBilgileriniGörüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuayeneGörüntüle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMuayeneGörüntüle;
    }
}