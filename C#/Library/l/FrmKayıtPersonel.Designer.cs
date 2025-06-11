namespace l
{
    partial class FrmKayıtPersonel
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
            this.LblPersonel = new System.Windows.Forms.Label();
            this.CBoxSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.fkpTxtAdi = new System.Windows.Forms.TextBox();
            this.LblAdi = new System.Windows.Forms.Label();
            this.LblSoyadi = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblSifre = new System.Windows.Forms.Label();
            this.fkpTxtSoyadi = new System.Windows.Forms.TextBox();
            this.fkpTxtTc = new System.Windows.Forms.TextBox();
            this.fkpTxtSifre = new System.Windows.Forms.TextBox();
            this.fkoBtnKayit = new System.Windows.Forms.Button();
            this.BtnGeriKayit = new System.Windows.Forms.Button();
            this.fkpTxtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fkpTxtEmail = new System.Windows.Forms.TextBox();
            this.enail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPersonel
            // 
            this.LblPersonel.AutoSize = true;
            this.LblPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonel.Location = new System.Drawing.Point(74, 49);
            this.LblPersonel.Name = "LblPersonel";
            this.LblPersonel.Size = new System.Drawing.Size(263, 29);
            this.LblPersonel.TabIndex = 5;
            this.LblPersonel.Text = "Personel Kayıt Ekranı";
            this.LblPersonel.Click += new System.EventHandler(this.label3_Click);
            // 
            // CBoxSifreyiGoster
            // 
            this.CBoxSifreyiGoster.AutoSize = true;
            this.CBoxSifreyiGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBoxSifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBoxSifreyiGoster.Location = new System.Drawing.Point(273, 416);
            this.CBoxSifreyiGoster.Name = "CBoxSifreyiGoster";
            this.CBoxSifreyiGoster.Size = new System.Drawing.Size(101, 20);
            this.CBoxSifreyiGoster.TabIndex = 8;
            this.CBoxSifreyiGoster.Text = "şifreyi göster";
            this.CBoxSifreyiGoster.UseVisualStyleBackColor = true;
            this.CBoxSifreyiGoster.CheckedChanged += new System.EventHandler(this.CBoxSifreyiGoster_CheckedChanged);
            // 
            // fkpTxtAdi
            // 
            this.fkpTxtAdi.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtAdi.Location = new System.Drawing.Point(124, 107);
            this.fkpTxtAdi.Multiline = true;
            this.fkpTxtAdi.Name = "fkpTxtAdi";
            this.fkpTxtAdi.Size = new System.Drawing.Size(245, 33);
            this.fkpTxtAdi.TabIndex = 10;
            this.fkpTxtAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LblAdi
            // 
            this.LblAdi.AutoSize = true;
            this.LblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdi.Location = new System.Drawing.Point(71, 115);
            this.LblAdi.Name = "LblAdi";
            this.LblAdi.Size = new System.Drawing.Size(38, 16);
            this.LblAdi.TabIndex = 13;
            this.LblAdi.Text = "Adı :";
            this.LblAdi.Click += new System.EventHandler(this.LblPersonelNo_Click);
            // 
            // LblSoyadi
            // 
            this.LblSoyadi.AutoSize = true;
            this.LblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyadi.Location = new System.Drawing.Point(45, 169);
            this.LblSoyadi.Name = "LblSoyadi";
            this.LblSoyadi.Size = new System.Drawing.Size(64, 16);
            this.LblSoyadi.TabIndex = 14;
            this.LblSoyadi.Text = "Soyadı :";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(54, 276);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(55, 16);
            this.LblTc.TabIndex = 15;
            this.LblTc.Text = "TCKN :";
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(62, 328);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(47, 16);
            this.LblSifre.TabIndex = 16;
            this.LblSifre.Text = "Şifre :";
            // 
            // fkpTxtSoyadi
            // 
            this.fkpTxtSoyadi.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtSoyadi.Location = new System.Drawing.Point(124, 161);
            this.fkpTxtSoyadi.Multiline = true;
            this.fkpTxtSoyadi.Name = "fkpTxtSoyadi";
            this.fkpTxtSoyadi.Size = new System.Drawing.Size(245, 33);
            this.fkpTxtSoyadi.TabIndex = 17;
            // 
            // fkpTxtTc
            // 
            this.fkpTxtTc.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtTc.Location = new System.Drawing.Point(124, 266);
            this.fkpTxtTc.Multiline = true;
            this.fkpTxtTc.Name = "fkpTxtTc";
            this.fkpTxtTc.Size = new System.Drawing.Size(245, 33);
            this.fkpTxtTc.TabIndex = 18;
            // 
            // fkpTxtSifre
            // 
            this.fkpTxtSifre.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtSifre.Location = new System.Drawing.Point(124, 319);
            this.fkpTxtSifre.Multiline = true;
            this.fkpTxtSifre.Name = "fkpTxtSifre";
            this.fkpTxtSifre.PasswordChar = '*';
            this.fkpTxtSifre.Size = new System.Drawing.Size(245, 33);
            this.fkpTxtSifre.TabIndex = 19;
            this.fkpTxtSifre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // fkoBtnKayit
            // 
            this.fkoBtnKayit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fkoBtnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fkoBtnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fkoBtnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoBtnKayit.Location = new System.Drawing.Point(114, 445);
            this.fkoBtnKayit.Name = "fkoBtnKayit";
            this.fkoBtnKayit.Size = new System.Drawing.Size(187, 37);
            this.fkoBtnKayit.TabIndex = 20;
            this.fkoBtnKayit.Text = "KAYIT";
            this.fkoBtnKayit.UseVisualStyleBackColor = false;
            this.fkoBtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // BtnGeriKayit
            // 
            this.BtnGeriKayit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnGeriKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeriKayit.Location = new System.Drawing.Point(14, 11);
            this.BtnGeriKayit.Name = "BtnGeriKayit";
            this.BtnGeriKayit.Size = new System.Drawing.Size(84, 28);
            this.BtnGeriKayit.TabIndex = 21;
            this.BtnGeriKayit.Text = "geri";
            this.BtnGeriKayit.UseVisualStyleBackColor = false;
            this.BtnGeriKayit.Click += new System.EventHandler(this.BtnGeriKayit_Click);
            // 
            // fkpTxtSifreTekrar
            // 
            this.fkpTxtSifreTekrar.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtSifreTekrar.Location = new System.Drawing.Point(124, 374);
            this.fkpTxtSifreTekrar.Multiline = true;
            this.fkpTxtSifreTekrar.Name = "fkpTxtSifreTekrar";
            this.fkpTxtSifreTekrar.PasswordChar = '*';
            this.fkpTxtSifreTekrar.Size = new System.Drawing.Size(245, 33);
            this.fkpTxtSifreTekrar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Şifre(tekrar) :";
            // 
            // fkpTxtEmail
            // 
            this.fkpTxtEmail.BackColor = System.Drawing.Color.LightGray;
            this.fkpTxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkpTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkpTxtEmail.Location = new System.Drawing.Point(124, 214);
            this.fkpTxtEmail.Multiline = true;
            this.fkpTxtEmail.Name = "fkpTxtEmail";
            this.fkpTxtEmail.Size = new System.Drawing.Size(245, 33);
            this.fkpTxtEmail.TabIndex = 24;
            // 
            // enail
            // 
            this.enail.AutoSize = true;
            this.enail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enail.Location = new System.Drawing.Point(50, 223);
            this.enail.Name = "enail";
            this.enail.Size = new System.Drawing.Size(59, 16);
            this.enail.TabIndex = 25;
            this.enail.Text = "E-Mail :";
            // 
            // FrmKayıtPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 533);
            this.ControlBox = false;
            this.Controls.Add(this.enail);
            this.Controls.Add(this.fkpTxtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fkpTxtSifreTekrar);
            this.Controls.Add(this.BtnGeriKayit);
            this.Controls.Add(this.fkoBtnKayit);
            this.Controls.Add(this.fkpTxtSifre);
            this.Controls.Add(this.fkpTxtTc);
            this.Controls.Add(this.fkpTxtSoyadi);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblSoyadi);
            this.Controls.Add(this.LblAdi);
            this.Controls.Add(this.fkpTxtAdi);
            this.Controls.Add(this.CBoxSifreyiGoster);
            this.Controls.Add(this.LblPersonel);
            this.Name = "FrmKayıtPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT";
            this.Load += new System.EventHandler(this.FrmKayıtPersonel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPersonel;
        private System.Windows.Forms.CheckBox CBoxSifreyiGoster;
        private System.Windows.Forms.TextBox fkpTxtAdi;
        private System.Windows.Forms.Label LblAdi;
        private System.Windows.Forms.Label LblSoyadi;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.TextBox fkpTxtSoyadi;
        private System.Windows.Forms.TextBox fkpTxtTc;
        private System.Windows.Forms.TextBox fkpTxtSifre;
        private System.Windows.Forms.Button fkoBtnKayit;
        private System.Windows.Forms.Button BtnGeriKayit;
        private System.Windows.Forms.TextBox fkpTxtSifreTekrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fkpTxtEmail;
        private System.Windows.Forms.Label enail;
    }
}