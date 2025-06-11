namespace Otopark
{
    partial class giris
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
            this.LblHesapOlustur = new System.Windows.Forms.Label();
            this.fpgCBoxSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.fpgBtnGiris = new System.Windows.Forms.Button();
            this.fpgTxtSifre = new System.Windows.Forms.TextBox();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LblPersonelTc = new System.Windows.Forms.Label();
            this.fpgTxtPersonelTc = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHesapOlustur
            // 
            this.LblHesapOlustur.AutoSize = true;
            this.LblHesapOlustur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblHesapOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHesapOlustur.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblHesapOlustur.Location = new System.Drawing.Point(207, 382);
            this.LblHesapOlustur.Name = "LblHesapOlustur";
            this.LblHesapOlustur.Padding = new System.Windows.Forms.Padding(1);
            this.LblHesapOlustur.Size = new System.Drawing.Size(226, 19);
            this.LblHesapOlustur.TabIndex = 17;
            this.LblHesapOlustur.Text = "Şifren Yok Mu? HESAP OLUŞTUR";
            this.LblHesapOlustur.Click += new System.EventHandler(this.LblHesapOlustur_Click);
            // 
            // fpgCBoxSifreyiGoster
            // 
            this.fpgCBoxSifreyiGoster.AutoSize = true;
            this.fpgCBoxSifreyiGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpgCBoxSifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fpgCBoxSifreyiGoster.Location = new System.Drawing.Point(384, 335);
            this.fpgCBoxSifreyiGoster.Name = "fpgCBoxSifreyiGoster";
            this.fpgCBoxSifreyiGoster.Size = new System.Drawing.Size(101, 20);
            this.fpgCBoxSifreyiGoster.TabIndex = 16;
            this.fpgCBoxSifreyiGoster.Text = "şifreyi göster";
            this.fpgCBoxSifreyiGoster.UseVisualStyleBackColor = true;
            this.fpgCBoxSifreyiGoster.CheckedChanged += new System.EventHandler(this.fpgCBoxSifreyiGoster_CheckedChanged);
            // 
            // fpgBtnGiris
            // 
            this.fpgBtnGiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fpgBtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpgBtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fpgBtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fpgBtnGiris.Location = new System.Drawing.Point(207, 329);
            this.fpgBtnGiris.Name = "fpgBtnGiris";
            this.fpgBtnGiris.Size = new System.Drawing.Size(163, 33);
            this.fpgBtnGiris.TabIndex = 14;
            this.fpgBtnGiris.Text = "GİRİŞ";
            this.fpgBtnGiris.UseVisualStyleBackColor = false;
            this.fpgBtnGiris.Click += new System.EventHandler(this.fpgBtnGiris_Click);
            // 
            // fpgTxtSifre
            // 
            this.fpgTxtSifre.BackColor = System.Drawing.Color.LightGray;
            this.fpgTxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpgTxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fpgTxtSifre.Location = new System.Drawing.Point(207, 279);
            this.fpgTxtSifre.Multiline = true;
            this.fpgTxtSifre.Name = "fpgTxtSifre";
            this.fpgTxtSifre.PasswordChar = '*';
            this.fpgTxtSifre.Size = new System.Drawing.Size(265, 33);
            this.fpgTxtSifre.TabIndex = 13;
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(132, 287);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(47, 16);
            this.LblSifre.TabIndex = 12;
            this.LblSifre.Text = "Şifre :";
            // 
            // LblPersonelTc
            // 
            this.LblPersonelTc.AutoSize = true;
            this.LblPersonelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonelTc.Location = new System.Drawing.Point(120, 235);
            this.LblPersonelTc.Name = "LblPersonelTc";
            this.LblPersonelTc.Size = new System.Drawing.Size(59, 16);
            this.LblPersonelTc.TabIndex = 11;
            this.LblPersonelTc.Text = "TC No :";
            // 
            // fpgTxtPersonelTc
            // 
            this.fpgTxtPersonelTc.BackColor = System.Drawing.Color.LightGray;
            this.fpgTxtPersonelTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpgTxtPersonelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fpgTxtPersonelTc.Location = new System.Drawing.Point(207, 227);
            this.fpgTxtPersonelTc.Multiline = true;
            this.fpgTxtPersonelTc.Name = "fpgTxtPersonelTc";
            this.fpgTxtPersonelTc.Size = new System.Drawing.Size(265, 33);
            this.fpgTxtPersonelTc.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Otopark.Properties.Resources.aaaa;
            this.pictureBox2.Location = new System.Drawing.Point(116, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(607, 429);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblHesapOlustur);
            this.Controls.Add(this.fpgCBoxSifreyiGoster);
            this.Controls.Add(this.fpgBtnGiris);
            this.Controls.Add(this.fpgTxtSifre);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblPersonelTc);
            this.Controls.Add(this.fpgTxtPersonelTc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "giris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİS";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblHesapOlustur;
        private System.Windows.Forms.CheckBox fpgCBoxSifreyiGoster;
        private System.Windows.Forms.Button fpgBtnGiris;
        private System.Windows.Forms.TextBox fpgTxtSifre;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Label LblPersonelTc;
        private System.Windows.Forms.TextBox fpgTxtPersonelTc;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}