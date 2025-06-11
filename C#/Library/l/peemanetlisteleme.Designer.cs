namespace l
{
    partial class peemanetlisteleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pklBtnGeriKayit = new System.Windows.Forms.Button();
            this.btnPdfExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 457);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tüm Kitaplar",
            "Geciken Kitaplar",
            "Bekleyen Kitaplar"});
            this.comboBox1.Location = new System.Drawing.Point(464, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(413, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "filte :";
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
            // btnPdfExport
            // 
            this.btnPdfExport.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnPdfExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdfExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPdfExport.Location = new System.Drawing.Point(791, 55);
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Size = new System.Drawing.Size(154, 28);
            this.btnPdfExport.TabIndex = 73;
            this.btnPdfExport.Text = "bilgileri yazdır";
            this.btnPdfExport.UseVisualStyleBackColor = false;
            this.btnPdfExport.Click += new System.EventHandler(this.btnPdfExport_Click);
            // 
            // peemanetlisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.ControlBox = false;
            this.Controls.Add(this.btnPdfExport);
            this.Controls.Add(this.pklBtnGeriKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "peemanetlisteleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.peemanetlisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pklBtnGeriKayit;
        private System.Windows.Forms.Button btnPdfExport;
    }
}