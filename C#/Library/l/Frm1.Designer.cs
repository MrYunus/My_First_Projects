namespace l
{
    partial class Frm1
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
            this.BtnOgrenci = new System.Windows.Forms.Button();
            this.LblGiris = new System.Windows.Forms.Label();
            this.BtnPersonel = new System.Windows.Forms.Button();
            this.LblDaha = new System.Windows.Forms.Label();
            this.LblKayıt = new System.Windows.Forms.Label();
            this.LblSifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOgrenci
            // 
            this.BtnOgrenci.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenci.Location = new System.Drawing.Point(112, 200);
            this.BtnOgrenci.Name = "BtnOgrenci";
            this.BtnOgrenci.Size = new System.Drawing.Size(170, 106);
            this.BtnOgrenci.TabIndex = 0;
            this.BtnOgrenci.Text = "öğrenci girişi";
            this.BtnOgrenci.UseVisualStyleBackColor = false;
            this.BtnOgrenci.Click += new System.EventHandler(this.BtnOgrenci_Click);
            // 
            // LblGiris
            // 
            this.LblGiris.AutoSize = true;
            this.LblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGiris.Location = new System.Drawing.Point(52, 74);
            this.LblGiris.Name = "LblGiris";
            this.LblGiris.Size = new System.Drawing.Size(501, 38);
            this.LblGiris.TabIndex = 1;
            this.LblGiris.Text = "Giriş yapacağınız statüyü seçiniz.";
            this.LblGiris.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnPersonel
            // 
            this.BtnPersonel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonel.Location = new System.Drawing.Point(306, 200);
            this.BtnPersonel.Name = "BtnPersonel";
            this.BtnPersonel.Size = new System.Drawing.Size(170, 106);
            this.BtnPersonel.TabIndex = 2;
            this.BtnPersonel.Text = "personel girişi";
            this.BtnPersonel.UseVisualStyleBackColor = false;
            this.BtnPersonel.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblDaha
            // 
            this.LblDaha.AutoSize = true;
            this.LblDaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDaha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblDaha.Location = new System.Drawing.Point(115, 350);
            this.LblDaha.Name = "LblDaha";
            this.LblDaha.Size = new System.Drawing.Size(180, 15);
            this.LblDaha.TabIndex = 3;
            this.LblDaha.Text = "Daha Önce Giriş Yapmadın Mı?";
            this.LblDaha.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblKayıt
            // 
            this.LblKayıt.AutoSize = true;
            this.LblKayıt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LblKayıt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblKayıt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblKayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKayıt.Location = new System.Drawing.Point(230, 368);
            this.LblKayıt.Name = "LblKayıt";
            this.LblKayıt.Padding = new System.Windows.Forms.Padding(1);
            this.LblKayıt.Size = new System.Drawing.Size(84, 22);
            this.LblKayıt.TabIndex = 4;
            this.LblKayıt.Text = "KAYIT OL";
            this.LblKayıt.Click += new System.EventHandler(this.LblKayıt_Click);
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(115, 371);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(105, 16);
            this.LblSifre.TabIndex = 17;
            this.LblSifre.Text = "öğrenci kayıdı";
            this.LblSifre.Click += new System.EventHandler(this.LblSifre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(340, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "personel kayıdı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(459, 368);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "KAYIT OL";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblKayıt);
            this.Controls.Add(this.LblDaha);
            this.Controls.Add(this.BtnPersonel);
            this.Controls.Add(this.LblGiris);
            this.Controls.Add(this.BtnOgrenci);
            this.MaximizeBox = false;
            this.Name = "Frm1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KUTUPHANEM";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOgrenci;
        private System.Windows.Forms.Label LblGiris;
        private System.Windows.Forms.Button BtnPersonel;
        private System.Windows.Forms.Label LblDaha;
        private System.Windows.Forms.Label LblKayıt;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}