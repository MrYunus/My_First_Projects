namespace l
{
    partial class uye
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
            this.enail = new System.Windows.Forms.Label();
            this.pulTxtEmail = new System.Windows.Forms.TextBox();
            this.pulOgrenciNumarasi = new System.Windows.Forms.TextBox();
            this.pulTxtSoyadi = new System.Windows.Forms.TextBox();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblSoyadi = new System.Windows.Forms.Label();
            this.LblAdi = new System.Windows.Forms.Label();
            this.pulTxtAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pulOgrenciAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pulBtnGeriKayit = new System.Windows.Forms.Button();
            this.pulSil = new System.Windows.Forms.Button();
            this.pulGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // enail
            // 
            this.enail.AutoSize = true;
            this.enail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enail.Location = new System.Drawing.Point(59, 373);
            this.enail.Name = "enail";
            this.enail.Size = new System.Drawing.Size(75, 20);
            this.enail.TabIndex = 65;
            this.enail.Text = "E-Mail :";
            // 
            // pulTxtEmail
            // 
            this.pulTxtEmail.BackColor = System.Drawing.Color.White;
            this.pulTxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pulTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pulTxtEmail.Location = new System.Drawing.Point(150, 363);
            this.pulTxtEmail.Multiline = true;
            this.pulTxtEmail.Name = "pulTxtEmail";
            this.pulTxtEmail.Size = new System.Drawing.Size(275, 37);
            this.pulTxtEmail.TabIndex = 64;
            // 
            // pulOgrenciNumarasi
            // 
            this.pulOgrenciNumarasi.BackColor = System.Drawing.Color.White;
            this.pulOgrenciNumarasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pulOgrenciNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pulOgrenciNumarasi.Location = new System.Drawing.Point(150, 128);
            this.pulOgrenciNumarasi.Multiline = true;
            this.pulOgrenciNumarasi.Name = "pulOgrenciNumarasi";
            this.pulOgrenciNumarasi.Size = new System.Drawing.Size(275, 37);
            this.pulOgrenciNumarasi.TabIndex = 63;
            this.pulOgrenciNumarasi.TextChanged += new System.EventHandler(this.pulOgrenciNumarasi_TextChanged);
            // 
            // pulTxtSoyadi
            // 
            this.pulTxtSoyadi.BackColor = System.Drawing.Color.White;
            this.pulTxtSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pulTxtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pulTxtSoyadi.Location = new System.Drawing.Point(150, 283);
            this.pulTxtSoyadi.Multiline = true;
            this.pulTxtSoyadi.Name = "pulTxtSoyadi";
            this.pulTxtSoyadi.Size = new System.Drawing.Size(275, 37);
            this.pulTxtSoyadi.TabIndex = 62;
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(18, 135);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(116, 20);
            this.LblTc.TabIndex = 61;
            this.LblTc.Text = "Öğrenci No :";
            // 
            // LblSoyadi
            // 
            this.LblSoyadi.AutoSize = true;
            this.LblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyadi.Location = new System.Drawing.Point(57, 292);
            this.LblSoyadi.Name = "LblSoyadi";
            this.LblSoyadi.Size = new System.Drawing.Size(77, 20);
            this.LblSoyadi.TabIndex = 60;
            this.LblSoyadi.Text = "Soyadı :";
            // 
            // LblAdi
            // 
            this.LblAdi.AutoSize = true;
            this.LblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdi.Location = new System.Drawing.Point(86, 214);
            this.LblAdi.Name = "LblAdi";
            this.LblAdi.Size = new System.Drawing.Size(48, 20);
            this.LblAdi.TabIndex = 59;
            this.LblAdi.Text = "Adı :";
            // 
            // pulTxtAdi
            // 
            this.pulTxtAdi.BackColor = System.Drawing.Color.White;
            this.pulTxtAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pulTxtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pulTxtAdi.Location = new System.Drawing.Point(150, 205);
            this.pulTxtAdi.Multiline = true;
            this.pulTxtAdi.Name = "pulTxtAdi";
            this.pulTxtAdi.Size = new System.Drawing.Size(275, 37);
            this.pulTxtAdi.TabIndex = 58;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(458, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 431);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pulOgrenciAra
            // 
            this.pulOgrenciAra.BackColor = System.Drawing.Color.White;
            this.pulOgrenciAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pulOgrenciAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pulOgrenciAra.Location = new System.Drawing.Point(628, 42);
            this.pulOgrenciAra.Multiline = true;
            this.pulOgrenciAra.Name = "pulOgrenciAra";
            this.pulOgrenciAra.Size = new System.Drawing.Size(275, 37);
            this.pulOgrenciAra.TabIndex = 68;
            this.pulOgrenciAra.TextChanged += new System.EventHandler(this.pulOgrenciAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(451, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Öğrenci No ARA :";
            // 
            // pulBtnGeriKayit
            // 
            this.pulBtnGeriKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.pulBtnGeriKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pulBtnGeriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulBtnGeriKayit.Location = new System.Drawing.Point(21, 21);
            this.pulBtnGeriKayit.Name = "pulBtnGeriKayit";
            this.pulBtnGeriKayit.Size = new System.Drawing.Size(126, 33);
            this.pulBtnGeriKayit.TabIndex = 69;
            this.pulBtnGeriKayit.Text = "geri";
            this.pulBtnGeriKayit.UseVisualStyleBackColor = false;
            this.pulBtnGeriKayit.Click += new System.EventHandler(this.pulBtnGeriKayit_Click);
            // 
            // pulSil
            // 
            this.pulSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.pulSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pulSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pulSil.Location = new System.Drawing.Point(81, 466);
            this.pulSil.Name = "pulSil";
            this.pulSil.Size = new System.Drawing.Size(97, 45);
            this.pulSil.TabIndex = 70;
            this.pulSil.Text = "SİL";
            this.pulSil.UseVisualStyleBackColor = false;
            this.pulSil.Click += new System.EventHandler(this.pulSil_Click);
            // 
            // pulGuncelle
            // 
            this.pulGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.pulGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pulGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pulGuncelle.Location = new System.Drawing.Point(211, 466);
            this.pulGuncelle.Name = "pulGuncelle";
            this.pulGuncelle.Size = new System.Drawing.Size(211, 45);
            this.pulGuncelle.TabIndex = 71;
            this.pulGuncelle.Text = "GÜNCELLE";
            this.pulGuncelle.UseVisualStyleBackColor = false;
            this.pulGuncelle.Click += new System.EventHandler(this.pulGuncelle_Click);
            // 
            // uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1218, 578);
            this.ControlBox = false;
            this.Controls.Add(this.pulGuncelle);
            this.Controls.Add(this.pulSil);
            this.Controls.Add(this.pulBtnGeriKayit);
            this.Controls.Add(this.pulOgrenciAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.enail);
            this.Controls.Add(this.pulTxtEmail);
            this.Controls.Add(this.pulOgrenciNumarasi);
            this.Controls.Add(this.pulTxtSoyadi);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblSoyadi);
            this.Controls.Add(this.LblAdi);
            this.Controls.Add(this.pulTxtAdi);
            this.Name = "uye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.puyelisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enail;
        private System.Windows.Forms.TextBox pulTxtEmail;
        private System.Windows.Forms.TextBox pulOgrenciNumarasi;
        private System.Windows.Forms.TextBox pulTxtSoyadi;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblSoyadi;
        private System.Windows.Forms.Label LblAdi;
        private System.Windows.Forms.TextBox pulTxtAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pulOgrenciAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pulBtnGeriKayit;
        private System.Windows.Forms.Button pulSil;
        private System.Windows.Forms.Button pulGuncelle;
    }
}