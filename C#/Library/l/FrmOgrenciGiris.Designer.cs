namespace l
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            this.TxtOkulNo = new System.Windows.Forms.TextBox();
            this.LblOkulNo = new System.Windows.Forms.Label();
            this.LblSifre = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.PictureAdu = new System.Windows.Forms.PictureBox();
            this.CBoxSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.LblHesapOlustur = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdu)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOkulNo
            // 
            this.TxtOkulNo.BackColor = System.Drawing.Color.LightGray;
            this.TxtOkulNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOkulNo.Location = new System.Drawing.Point(217, 212);
            this.TxtOkulNo.Multiline = true;
            this.TxtOkulNo.Name = "TxtOkulNo";
            this.TxtOkulNo.Size = new System.Drawing.Size(265, 33);
            this.TxtOkulNo.TabIndex = 10;
            // 
            // LblOkulNo
            // 
            this.LblOkulNo.AutoSize = true;
            this.LblOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOkulNo.Location = new System.Drawing.Point(119, 220);
            this.LblOkulNo.Name = "LblOkulNo";
            this.LblOkulNo.Size = new System.Drawing.Size(70, 16);
            this.LblOkulNo.TabIndex = 11;
            this.LblOkulNo.Text = "Okul No :";
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(142, 272);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(47, 16);
            this.LblSifre.TabIndex = 12;
            this.LblSifre.Text = "Şifre :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.LightGray;
            this.TxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(217, 264);
            this.TxtSifre.Multiline = true;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(265, 33);
            this.TxtSifre.TabIndex = 13;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(217, 314);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(163, 33);
            this.BtnGiris.TabIndex = 14;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // PictureAdu
            // 
            this.PictureAdu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureAdu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureAdu.Image = ((System.Drawing.Image)(resources.GetObject("PictureAdu.Image")));
            this.PictureAdu.Location = new System.Drawing.Point(220, 12);
            this.PictureAdu.Name = "PictureAdu";
            this.PictureAdu.Size = new System.Drawing.Size(184, 169);
            this.PictureAdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureAdu.TabIndex = 15;
            this.PictureAdu.TabStop = false;
            // 
            // CBoxSifreyiGoster
            // 
            this.CBoxSifreyiGoster.AutoSize = true;
            this.CBoxSifreyiGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBoxSifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBoxSifreyiGoster.Location = new System.Drawing.Point(394, 320);
            this.CBoxSifreyiGoster.Name = "CBoxSifreyiGoster";
            this.CBoxSifreyiGoster.Size = new System.Drawing.Size(101, 20);
            this.CBoxSifreyiGoster.TabIndex = 16;
            this.CBoxSifreyiGoster.Text = "şifreyi göster";
            this.CBoxSifreyiGoster.UseVisualStyleBackColor = true;
            this.CBoxSifreyiGoster.CheckedChanged += new System.EventHandler(this.CBoxSifreyiGoster_CheckedChanged);
            // 
            // LblHesapOlustur
            // 
            this.LblHesapOlustur.AutoSize = true;
            this.LblHesapOlustur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblHesapOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHesapOlustur.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblHesapOlustur.Location = new System.Drawing.Point(217, 367);
            this.LblHesapOlustur.Name = "LblHesapOlustur";
            this.LblHesapOlustur.Padding = new System.Windows.Forms.Padding(1);
            this.LblHesapOlustur.Size = new System.Drawing.Size(241, 19);
            this.LblHesapOlustur.TabIndex = 17;
            this.LblHesapOlustur.Text = "Hesabın Yok Mu? HESAP OLUŞTUR";
            this.LblHesapOlustur.Click += new System.EventHandler(this.LblHesapOlustur_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Location = new System.Drawing.Point(19, 17);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(84, 28);
            this.BtnGeri.TabIndex = 18;
            this.BtnGeri.Text = "geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(607, 429);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.LblHesapOlustur);
            this.Controls.Add(this.CBoxSifreyiGoster);
            this.Controls.Add(this.PictureAdu);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblOkulNo);
            this.Controls.Add(this.TxtOkulNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OGRENCI";
            this.Load += new System.EventHandler(this.FrmOgrenciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOkulNo;
        private System.Windows.Forms.Label LblOkulNo;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.PictureBox PictureAdu;
        private System.Windows.Forms.CheckBox CBoxSifreyiGoster;
        private System.Windows.Forms.Label LblHesapOlustur;
        private System.Windows.Forms.Button BtnGeri;
    }
}