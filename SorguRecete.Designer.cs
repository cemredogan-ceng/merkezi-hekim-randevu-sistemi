
namespace _210601048_Cemre_DOĞAN_FinalOdev
{
    partial class SorguRecete
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
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.dataGridViewSorguRecete = new System.Windows.Forms.DataGridView();
            this.buttonGörüntüle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorguRecete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçetesini görüntülemek istediğiniz hastanın Tc Kimlik numarasını giriniz";
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(419, 96);
            this.textBoxTc.Multiline = true;
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(157, 38);
            this.textBoxTc.TabIndex = 1;
            // 
            // dataGridViewSorguRecete
            // 
            this.dataGridViewSorguRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorguRecete.Location = new System.Drawing.Point(17, 149);
            this.dataGridViewSorguRecete.Name = "dataGridViewSorguRecete";
            this.dataGridViewSorguRecete.RowHeadersWidth = 62;
            this.dataGridViewSorguRecete.RowTemplate.Height = 28;
            this.dataGridViewSorguRecete.Size = new System.Drawing.Size(992, 302);
            this.dataGridViewSorguRecete.TabIndex = 2;
            // 
            // buttonGörüntüle
            // 
            this.buttonGörüntüle.Location = new System.Drawing.Point(874, 457);
            this.buttonGörüntüle.Name = "buttonGörüntüle";
            this.buttonGörüntüle.Size = new System.Drawing.Size(135, 39);
            this.buttonGörüntüle.TabIndex = 3;
            this.buttonGörüntüle.Text = "Görüntüle";
            this.buttonGörüntüle.UseVisualStyleBackColor = true;
            this.buttonGörüntüle.Click += new System.EventHandler(this.buttonGörüntüle_Click);
            // 
            // SorguRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 508);
            this.Controls.Add(this.buttonGörüntüle);
            this.Controls.Add(this.dataGridViewSorguRecete);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.label1);
            this.Name = "SorguRecete";
            this.Text = "SorguRecete";
            this.Load += new System.EventHandler(this.SorguRecete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorguRecete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.DataGridView dataGridViewSorguRecete;
        private System.Windows.Forms.Button buttonGörüntüle;
    }
}