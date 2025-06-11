namespace l
{
    partial class Sıralamafrm
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
            this.pklBtnGeriKayit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sa1 = new System.Windows.Forms.Label();
            this.saaa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pklBtnGeriKayit
            // 
            this.pklBtnGeriKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.pklBtnGeriKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pklBtnGeriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pklBtnGeriKayit.Location = new System.Drawing.Point(21, 21);
            this.pklBtnGeriKayit.Name = "pklBtnGeriKayit";
            this.pklBtnGeriKayit.Size = new System.Drawing.Size(126, 33);
            this.pklBtnGeriKayit.TabIndex = 72;
            this.pklBtnGeriKayit.Text = "geri";
            this.pklBtnGeriKayit.UseVisualStyleBackColor = false;
            this.pklBtnGeriKayit.Click += new System.EventHandler(this.pklBtnGeriKayit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 463);
            this.dataGridView1.TabIndex = 73;
            // 
            // sa1
            // 
            this.sa1.AutoSize = true;
            this.sa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sa1.Location = new System.Drawing.Point(71, 280);
            this.sa1.Name = "sa1";
            this.sa1.Size = new System.Drawing.Size(225, 22);
            this.sa1.TabIndex = 74;
            this.sa1.Text = "En Fazla Okuyan Öğrenci :";
            // 
            // saaa
            // 
            this.saaa.AutoSize = true;
            this.saaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saaa.Location = new System.Drawing.Point(94, 344);
            this.saaa.Name = "saaa";
            this.saaa.Size = new System.Drawing.Size(202, 22);
            this.saaa.TabIndex = 75;
            this.saaa.Text = "En Az Okuyan Öğrenci :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(329, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(326, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 77;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Location = new System.Drawing.Point(1040, 60);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 28);
            this.btnPrint.TabIndex = 78;
            this.btnPrint.Text = "bilgileri yazdır";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // Sıralamafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1265, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saaa);
            this.Controls.Add(this.sa1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pklBtnGeriKayit);
            this.Name = "Sıralamafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.Sıralamafrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pklBtnGeriKayit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sa1;
        private System.Windows.Forms.Label saaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
    }
}