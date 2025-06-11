namespace l
{
    partial class FrmPersonelGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelGiris));
            this.LblPersonelTc = new System.Windows.Forms.Label();
            this.fpgTxtSifre = new System.Windows.Forms.TextBox();
            this.fpgBtnGiris = new System.Windows.Forms.Button();
            this.PictureAdu = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fpgTxtPersonelTc = new System.Windows.Forms.TextBox();
            this.LblSifre = new System.Windows.Forms.Label();
            this.fpgCBoxSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.LblHesapOlustur = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdu)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPersonelTc
            // 
            this.LblPersonelTc.AutoSize = true;
            this.LblPersonelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonelTc.Location = new System.Drawing.Point(77, 220);
            this.LblPersonelTc.Name = "LblPersonelTc";
            this.LblPersonelTc.Size = new System.Drawing.Size(121, 16);
            this.LblPersonelTc.TabIndex = 2;
            this.LblPersonelTc.Text = "Personel TCKN :";
            this.LblPersonelTc.Click += new System.EventHandler(this.LblPersonelKodu_Click);
            // 
            // fpgTxtSifre
            // 
            this.fpgTxtSifre.BackColor = System.Drawing.Color.LightGray;
            this.fpgTxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpgTxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fpgTxtSifre.Location = new System.Drawing.Point(226, 264);
            this.fpgTxtSifre.Multiline = true;
            this.fpgTxtSifre.Name = "fpgTxtSifre";
            this.fpgTxtSifre.PasswordChar = '*';
            this.fpgTxtSifre.Size = new System.Drawing.Size(265, 33);
            this.fpgTxtSifre.TabIndex = 4;
            this.fpgTxtSifre.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            // 
            // fpgBtnGiris
            // 
            this.fpgBtnGiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fpgBtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpgBtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fpgBtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fpgBtnGiris.Location = new System.Drawing.Point(226, 314);
            this.fpgBtnGiris.Name = "fpgBtnGiris";
            this.fpgBtnGiris.Size = new System.Drawing.Size(163, 33);
            this.fpgBtnGiris.TabIndex = 5;
            this.fpgBtnGiris.Text = "GİRİŞ";
            this.fpgBtnGiris.UseVisualStyleBackColor = false;
            this.fpgBtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // PictureAdu
            // 
            this.PictureAdu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureAdu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureAdu.Image = ((System.Drawing.Image)(resources.GetObject("PictureAdu.Image")));
            this.PictureAdu.Location = new System.Drawing.Point(223, 12);
            this.PictureAdu.Name = "PictureAdu";
            this.PictureAdu.Size = new System.Drawing.Size(184, 169);
            this.PictureAdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureAdu.TabIndex = 6;
            this.PictureAdu.TabStop = false;
            this.PictureAdu.Click += new System.EventHandler(this.PictureAdu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fpgTxtPersonelTc
            // 
            this.fpgTxtPersonelTc.BackColor = System.Drawing.Color.LightGray;
            this.fpgTxtPersonelTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpgTxtPersonelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fpgTxtPersonelTc.Location = new System.Drawing.Point(226, 212);
            this.fpgTxtPersonelTc.Multiline = true;
            this.fpgTxtPersonelTc.Name = "fpgTxtPersonelTc";
            this.fpgTxtPersonelTc.Size = new System.Drawing.Size(265, 33);
            this.fpgTxtPersonelTc.TabIndex = 0;
            this.fpgTxtPersonelTc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(151, 272);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(47, 16);
            this.LblSifre.TabIndex = 3;
            this.LblSifre.Text = "Şifre :";
            // 
            // fpgCBoxSifreyiGoster
            // 
            this.fpgCBoxSifreyiGoster.AutoSize = true;
            this.fpgCBoxSifreyiGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpgCBoxSifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fpgCBoxSifreyiGoster.Location = new System.Drawing.Point(403, 320);
            this.fpgCBoxSifreyiGoster.Name = "fpgCBoxSifreyiGoster";
            this.fpgCBoxSifreyiGoster.Size = new System.Drawing.Size(101, 20);
            this.fpgCBoxSifreyiGoster.TabIndex = 7;
            this.fpgCBoxSifreyiGoster.Text = "şifreyi göster";
            this.fpgCBoxSifreyiGoster.UseVisualStyleBackColor = true;
            this.fpgCBoxSifreyiGoster.CheckedChanged += new System.EventHandler(this.fpgCBoxSifreyiGoster_CheckedChanged);
            // 
            // LblHesapOlustur
            // 
            this.LblHesapOlustur.AutoSize = true;
            this.LblHesapOlustur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblHesapOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHesapOlustur.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblHesapOlustur.Location = new System.Drawing.Point(226, 367);
            this.LblHesapOlustur.Name = "LblHesapOlustur";
            this.LblHesapOlustur.Padding = new System.Windows.Forms.Padding(1);
            this.LblHesapOlustur.Size = new System.Drawing.Size(241, 19);
            this.LblHesapOlustur.TabIndex = 8;
            this.LblHesapOlustur.Text = "Hesabın Yok Mu? HESAP OLUŞTUR";
            this.LblHesapOlustur.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Location = new System.Drawing.Point(19, 17);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(84, 28);
            this.BtnGeri.TabIndex = 9;
            this.BtnGeri.Text = "geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // FrmPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 429);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.LblHesapOlustur);
            this.Controls.Add(this.fpgCBoxSifreyiGoster);
            this.Controls.Add(this.PictureAdu);
            this.Controls.Add(this.fpgBtnGiris);
            this.Controls.Add(this.fpgTxtSifre);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblPersonelTc);
            this.Controls.Add(this.fpgTxtPersonelTc);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPersonelTc;
        private System.Windows.Forms.TextBox fpgTxtSifre;
        private System.Windows.Forms.Button fpgBtnGiris;
        private System.Windows.Forms.PictureBox PictureAdu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox fpgTxtPersonelTc;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.CheckBox fpgCBoxSifreyiGoster;
        private System.Windows.Forms.Label LblHesapOlustur;
        private System.Windows.Forms.Button BtnGeri;
    }
}

