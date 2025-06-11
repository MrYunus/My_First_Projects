namespace Otopark
{
    partial class frmSatış
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
            this.pueBtnGeriKayit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerildi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 444);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pueBtnGeriKayit
            // 
            this.pueBtnGeriKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.pueBtnGeriKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pueBtnGeriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pueBtnGeriKayit.Location = new System.Drawing.Point(22, 34);
            this.pueBtnGeriKayit.Name = "pueBtnGeriKayit";
            this.pueBtnGeriKayit.Size = new System.Drawing.Size(84, 28);
            this.pueBtnGeriKayit.TabIndex = 67;
            this.pueBtnGeriKayit.Text = "geri";
            this.pueBtnGeriKayit.UseVisualStyleBackColor = false;
            this.pueBtnGeriKayit.Click += new System.EventHandler(this.pueBtnGeriKayit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 69;
            // 
            // btnVerildi
            // 
            this.btnVerildi.BackColor = System.Drawing.Color.Beige;
            this.btnVerildi.Location = new System.Drawing.Point(862, 100);
            this.btnVerildi.Name = "btnVerildi";
            this.btnVerildi.Size = new System.Drawing.Size(237, 49);
            this.btnVerildi.TabIndex = 70;
            this.btnVerildi.Text = "ARAÇ GERİ VERİLDİ";
            this.btnVerildi.UseVisualStyleBackColor = false;
            this.btnVerildi.Click += new System.EventHandler(this.btnVerildi_Click);
            // 
            // frmSatış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1157, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerildi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pueBtnGeriKayit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.frmSatış_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pueBtnGeriKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerildi;
    }
}