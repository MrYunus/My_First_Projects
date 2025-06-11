namespace l
{
    partial class FrmKayıtOgrenci
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayıtOgrenci));
            this.enail = new System.Windows.Forms.Label();
            this.fkoTxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fkoTxtSifreTekrar = new System.Windows.Forms.TextBox();
            this.BtnGeriKayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fkoBtnKayit = new System.Windows.Forms.Button();
            this.fkoTxtSifre = new System.Windows.Forms.TextBox();
            this.fkoOgrenciNumarasi = new System.Windows.Forms.TextBox();
            this.fkoTxtSoyadi = new System.Windows.Forms.TextBox();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblSoyadi = new System.Windows.Forms.Label();
            this.LblAdi = new System.Windows.Forms.Label();
            this.fkoTxtAdi = new System.Windows.Forms.TextBox();
            this.fkoCBoxSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.LblPersonel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enail
            // 
            this.enail.AutoSize = true;
            this.enail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enail.Location = new System.Drawing.Point(53, 223);
            this.enail.Name = "enail";
            this.enail.Size = new System.Drawing.Size(59, 16);
            this.enail.TabIndex = 41;
            this.enail.Text = "E-Mail :";
            // 
            // fkoTxtEmail
            // 
            this.fkoTxtEmail.BackColor = System.Drawing.Color.LightGray;
            this.fkoTxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkoTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoTxtEmail.Location = new System.Drawing.Point(128, 214);
            this.fkoTxtEmail.Multiline = true;
            this.fkoTxtEmail.Name = "fkoTxtEmail";
            this.fkoTxtEmail.Size = new System.Drawing.Size(245, 33);
            this.fkoTxtEmail.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Şifre(tekrar) :";
            // 
            // fkoTxtSifreTekrar
            // 
            this.fkoTxtSifreTekrar.BackColor = System.Drawing.Color.LightGray;
            this.fkoTxtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkoTxtSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoTxtSifreTekrar.Location = new System.Drawing.Point(128, 374);
            this.fkoTxtSifreTekrar.Multiline = true;
            this.fkoTxtSifreTekrar.Name = "fkoTxtSifreTekrar";
            this.fkoTxtSifreTekrar.PasswordChar = '*';
            this.fkoTxtSifreTekrar.Size = new System.Drawing.Size(245, 33);
            this.fkoTxtSifreTekrar.TabIndex = 38;
            // 
            // BtnGeriKayit
            // 
            this.BtnGeriKayit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnGeriKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeriKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGeriKayit.ImageList = this.ımageList1;
            this.BtnGeriKayit.Location = new System.Drawing.Point(14, 11);
            this.BtnGeriKayit.Name = "BtnGeriKayit";
            this.BtnGeriKayit.Size = new System.Drawing.Size(84, 28);
            this.BtnGeriKayit.TabIndex = 37;
            this.BtnGeriKayit.Text = "geri";
            this.BtnGeriKayit.UseVisualStyleBackColor = false;
            this.BtnGeriKayit.Click += new System.EventHandler(this.BtnGeriKayit_Click_1);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back.png");
            this.ımageList1.Images.SetKeyName(1, "save.png");
            // 
            // fkoBtnKayit
            // 
            this.fkoBtnKayit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fkoBtnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fkoBtnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fkoBtnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoBtnKayit.ImageList = this.ımageList1;
            this.fkoBtnKayit.Location = new System.Drawing.Point(114, 445);
            this.fkoBtnKayit.Name = "fkoBtnKayit";
            this.fkoBtnKayit.Size = new System.Drawing.Size(187, 37);
            this.fkoBtnKayit.TabIndex = 36;
            this.fkoBtnKayit.Text = "KAYIT";
            this.fkoBtnKayit.UseVisualStyleBackColor = false;
            this.fkoBtnKayit.Click += new System.EventHandler(this.fkoBtnKayit_Click);
            // 
            // fkoTxtSifre
            // 
            this.fkoTxtSifre.BackColor = System.Drawing.Color.LightGray;
            this.fkoTxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkoTxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoTxtSifre.Location = new System.Drawing.Point(128, 319);
            this.fkoTxtSifre.Multiline = true;
            this.fkoTxtSifre.Name = "fkoTxtSifre";
            this.fkoTxtSifre.PasswordChar = '*';
            this.fkoTxtSifre.Size = new System.Drawing.Size(245, 33);
            this.fkoTxtSifre.TabIndex = 35;
            // 
            // fkoOgrenciNumarasi
            // 
            this.fkoOgrenciNumarasi.BackColor = System.Drawing.Color.LightGray;
            this.fkoOgrenciNumarasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkoOgrenciNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoOgrenciNumarasi.Location = new System.Drawing.Point(128, 266);
            this.fkoOgrenciNumarasi.Multiline = true;
            this.fkoOgrenciNumarasi.Name = "fkoOgrenciNumarasi";
            this.fkoOgrenciNumarasi.Size = new System.Drawing.Size(245, 33);
            this.fkoOgrenciNumarasi.TabIndex = 34;
            // 
            // fkoTxtSoyadi
            // 
            this.fkoTxtSoyadi.BackColor = System.Drawing.Color.LightGray;
            this.fkoTxtSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkoTxtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoTxtSoyadi.Location = new System.Drawing.Point(128, 161);
            this.fkoTxtSoyadi.Multiline = true;
            this.fkoTxtSoyadi.Name = "fkoTxtSoyadi";
            this.fkoTxtSoyadi.Size = new System.Drawing.Size(245, 33);
            this.fkoTxtSoyadi.TabIndex = 33;
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(65, 328);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(47, 16);
            this.LblSifre.TabIndex = 32;
            this.LblSifre.Text = "Şifre :";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(19, 276);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(93, 16);
            this.LblTc.TabIndex = 31;
            this.LblTc.Text = "Öğrenci No :";
            // 
            // LblSoyadi
            // 
            this.LblSoyadi.AutoSize = true;
            this.LblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyadi.Location = new System.Drawing.Point(48, 169);
            this.LblSoyadi.Name = "LblSoyadi";
            this.LblSoyadi.Size = new System.Drawing.Size(64, 16);
            this.LblSoyadi.TabIndex = 30;
            this.LblSoyadi.Text = "Soyadı :";
            // 
            // LblAdi
            // 
            this.LblAdi.AutoSize = true;
            this.LblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdi.Location = new System.Drawing.Point(74, 115);
            this.LblAdi.Name = "LblAdi";
            this.LblAdi.Size = new System.Drawing.Size(38, 16);
            this.LblAdi.TabIndex = 29;
            this.LblAdi.Text = "Adı :";
            // 
            // fkoTxtAdi
            // 
            this.fkoTxtAdi.BackColor = System.Drawing.Color.LightGray;
            this.fkoTxtAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fkoTxtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkoTxtAdi.Location = new System.Drawing.Point(128, 107);
            this.fkoTxtAdi.Multiline = true;
            this.fkoTxtAdi.Name = "fkoTxtAdi";
            this.fkoTxtAdi.Size = new System.Drawing.Size(245, 33);
            this.fkoTxtAdi.TabIndex = 28;
            // 
            // fkoCBoxSifreyiGoster
            // 
            this.fkoCBoxSifreyiGoster.AutoSize = true;
            this.fkoCBoxSifreyiGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fkoCBoxSifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fkoCBoxSifreyiGoster.Location = new System.Drawing.Point(277, 416);
            this.fkoCBoxSifreyiGoster.Name = "fkoCBoxSifreyiGoster";
            this.fkoCBoxSifreyiGoster.Size = new System.Drawing.Size(101, 20);
            this.fkoCBoxSifreyiGoster.TabIndex = 27;
            this.fkoCBoxSifreyiGoster.Text = "şifreyi göster";
            this.fkoCBoxSifreyiGoster.UseVisualStyleBackColor = true;
            // 
            // LblPersonel
            // 
            this.LblPersonel.AutoSize = true;
            this.LblPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonel.Location = new System.Drawing.Point(74, 49);
            this.LblPersonel.Name = "LblPersonel";
            this.LblPersonel.Size = new System.Drawing.Size(251, 29);
            this.LblPersonel.TabIndex = 26;
            this.LblPersonel.Text = "Öğrenci Kayıt Ekranı";
            // 
            // FrmKayıtOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 533);
            this.ControlBox = false;
            this.Controls.Add(this.enail);
            this.Controls.Add(this.fkoTxtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fkoTxtSifreTekrar);
            this.Controls.Add(this.BtnGeriKayit);
            this.Controls.Add(this.fkoBtnKayit);
            this.Controls.Add(this.fkoTxtSifre);
            this.Controls.Add(this.fkoOgrenciNumarasi);
            this.Controls.Add(this.fkoTxtSoyadi);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblSoyadi);
            this.Controls.Add(this.LblAdi);
            this.Controls.Add(this.fkoTxtAdi);
            this.Controls.Add(this.fkoCBoxSifreyiGoster);
            this.Controls.Add(this.LblPersonel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKayıtOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT";
            this.Load += new System.EventHandler(this.FrmKayıtOgrenci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enail;
        private System.Windows.Forms.TextBox fkoTxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fkoTxtSifreTekrar;
        private System.Windows.Forms.Button BtnGeriKayit;
        private System.Windows.Forms.Button fkoBtnKayit;
        private System.Windows.Forms.TextBox fkoTxtSifre;
        private System.Windows.Forms.TextBox fkoOgrenciNumarasi;
        private System.Windows.Forms.TextBox fkoTxtSoyadi;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblSoyadi;
        private System.Windows.Forms.Label LblAdi;
        private System.Windows.Forms.TextBox fkoTxtAdi;
        private System.Windows.Forms.CheckBox fkoCBoxSifreyiGoster;
        private System.Windows.Forms.Label LblPersonel;
        private System.Windows.Forms.ImageList ımageList1;
    }
}