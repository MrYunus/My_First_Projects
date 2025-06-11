namespace Otopark
{
    partial class müsterilisteleme
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
            this.pueBtnGeriKayit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fkoBtnKayit = new System.Windows.Forms.Button();
            this.enail = new System.Windows.Forms.Label();
            this.fkpTxtEmail = new System.Windows.Forms.TextBox();
            this.fkpTxtTc = new System.Windows.Forms.TextBox();
            this.fkpTxtSoyadi = new System.Windows.Forms.TextBox();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblSoyadi = new System.Windows.Forms.Label();
            this.LblAdi = new System.Windows.Forms.Label();
            this.fkpTxtAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pueBtnGeriKayit
            // 
            this.pueBtnGeriKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.pueBtnGeriKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pueBtnGeriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pueBtnGeriKayit.Location = new System.Drawing.Point(28, 35);
            this.pueBtnGeriKayit.Name = "pueBtnGeriKayit";
            this.pueBtnGeriKayit.Size = new System.Drawing.Size(84, 28);
            this.pueBtnGeriKayit.TabIndex = 54;
            this.pueBtnGeriKayit.Text = "geri";
            this.pueBtnGeriKayit.UseVisualStyleBackColor = false;
            this.pueBtnGeriKayit.Click += new System.EventHandler(this.pueBtnGeriKayit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 426);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(135, 426);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 33);
            this.textBox1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "E-Mail:";
            // 
            // fkoBtnKayit
            // 
            this.fkoBtnKayit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fkoBtnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fkoBtnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fkoBtnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoBtnKayit.Location = new System.Drawing.Point(238, 499);
            this.fkoBtnKayit.Name = "fkoBtnKayit";
            this.fkoBtnKayit.Size = new System.Drawing.Size(158, 37);
            this.fkoBtnKayit.TabIndex = 64;
            this.fkoBtnKayit.Text = "GÜNCELLE";
            this.fkoBtnKayit.UseVisualStyleBackColor = false;
            this.fkoBtnKayit.Click += new System.EventHandler(this.fkoBtnKayit_Click);
            // 
            // enail
            // 
            this.enail.AutoSize = true;
            this.enail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enail.Location = new System.Drawing.Point(58, 292);
            this.enail.Name = "enail";
            this.enail.Size = new System.Drawing.Size(62, 16);
            this.enail.TabIndex = 63;
            this.enail.Text = "telefon :";
            // 
            // fkpTxtEmail
            // 
            this.fkpTxtEmail.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtEmail.Location = new System.Drawing.Point(135, 283);
            this.fkpTxtEmail.Multiline = true;
            this.fkpTxtEmail.Name = "fkpTxtEmail";
            this.fkpTxtEmail.Size = new System.Drawing.Size(253, 33);
            this.fkpTxtEmail.TabIndex = 62;
            // 
            // fkpTxtTc
            // 
            this.fkpTxtTc.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtTc.Location = new System.Drawing.Point(135, 356);
            this.fkpTxtTc.Multiline = true;
            this.fkpTxtTc.Name = "fkpTxtTc";
            this.fkpTxtTc.Size = new System.Drawing.Size(253, 33);
            this.fkpTxtTc.TabIndex = 61;
            // 
            // fkpTxtSoyadi
            // 
            this.fkpTxtSoyadi.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtSoyadi.Location = new System.Drawing.Point(135, 216);
            this.fkpTxtSoyadi.Multiline = true;
            this.fkpTxtSoyadi.Name = "fkpTxtSoyadi";
            this.fkpTxtSoyadi.Size = new System.Drawing.Size(253, 33);
            this.fkpTxtSoyadi.TabIndex = 60;
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(65, 366);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(55, 16);
            this.LblTc.TabIndex = 59;
            this.LblTc.Text = "adres :";
            // 
            // LblSoyadi
            // 
            this.LblSoyadi.AutoSize = true;
            this.LblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyadi.Location = new System.Drawing.Point(33, 224);
            this.LblSoyadi.Name = "LblSoyadi";
            this.LblSoyadi.Size = new System.Drawing.Size(87, 16);
            this.LblSoyadi.TabIndex = 58;
            this.LblSoyadi.Text = "Ad Soyad  :";
            // 
            // LblAdi
            // 
            this.LblAdi.AutoSize = true;
            this.LblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdi.Location = new System.Drawing.Point(85, 155);
            this.LblAdi.Name = "LblAdi";
            this.LblAdi.Size = new System.Drawing.Size(35, 16);
            this.LblAdi.TabIndex = 57;
            this.LblAdi.Text = "TC :";
            // 
            // fkpTxtAdi
            // 
            this.fkpTxtAdi.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtAdi.Location = new System.Drawing.Point(135, 147);
            this.fkpTxtAdi.Multiline = true;
            this.fkpTxtAdi.Name = "fkpTxtAdi";
            this.fkpTxtAdi.Size = new System.Drawing.Size(253, 33);
            this.fkpTxtAdi.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(81, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 67;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(825, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "TC ARA:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(904, 68);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 33);
            this.textBox2.TabIndex = 68;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // müsterilisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1211, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fkoBtnKayit);
            this.Controls.Add(this.enail);
            this.Controls.Add(this.fkpTxtEmail);
            this.Controls.Add(this.fkpTxtTc);
            this.Controls.Add(this.fkpTxtSoyadi);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblSoyadi);
            this.Controls.Add(this.LblAdi);
            this.Controls.Add(this.fkpTxtAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pueBtnGeriKayit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "müsterilisteleme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LİSTELEME";
            this.Load += new System.EventHandler(this.müsterilisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pueBtnGeriKayit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fkoBtnKayit;
        private System.Windows.Forms.Label enail;
        private System.Windows.Forms.TextBox fkpTxtEmail;
        private System.Windows.Forms.TextBox fkpTxtTc;
        private System.Windows.Forms.TextBox fkpTxtSoyadi;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblSoyadi;
        private System.Windows.Forms.Label LblAdi;
        private System.Windows.Forms.TextBox fkpTxtAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}