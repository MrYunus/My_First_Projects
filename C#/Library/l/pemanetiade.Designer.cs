namespace l
{
    partial class pemanetiade
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
            this.pklBtnGeriKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.peiBarkodNoAra = new System.Windows.Forms.TextBox();
            this.peiOkulNoAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peiTeslimAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pklBtnGeriKayit
            // 
            this.pklBtnGeriKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.pklBtnGeriKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pklBtnGeriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pklBtnGeriKayit.Location = new System.Drawing.Point(21, 21);
            this.pklBtnGeriKayit.Name = "pklBtnGeriKayit";
            this.pklBtnGeriKayit.Size = new System.Drawing.Size(126, 33);
            this.pklBtnGeriKayit.TabIndex = 73;
            this.pklBtnGeriKayit.Text = "geri";
            this.pklBtnGeriKayit.UseVisualStyleBackColor = false;
            this.pklBtnGeriKayit.Click += new System.EventHandler(this.pklBtnGeriKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Okul Numarası İle Arama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "veya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Barkod No İle Arama :";
            // 
            // peiBarkodNoAra
            // 
            this.peiBarkodNoAra.BackColor = System.Drawing.Color.White;
            this.peiBarkodNoAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.peiBarkodNoAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.peiBarkodNoAra.Location = new System.Drawing.Point(268, 248);
            this.peiBarkodNoAra.Multiline = true;
            this.peiBarkodNoAra.Name = "peiBarkodNoAra";
            this.peiBarkodNoAra.Size = new System.Drawing.Size(251, 29);
            this.peiBarkodNoAra.TabIndex = 78;
            this.peiBarkodNoAra.TextChanged += new System.EventHandler(this.peiBarkodNoAra_TextChanged);
            // 
            // peiOkulNoAra
            // 
            this.peiOkulNoAra.BackColor = System.Drawing.Color.White;
            this.peiOkulNoAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.peiOkulNoAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.peiOkulNoAra.Location = new System.Drawing.Point(268, 311);
            this.peiOkulNoAra.Multiline = true;
            this.peiOkulNoAra.Name = "peiOkulNoAra";
            this.peiOkulNoAra.Size = new System.Drawing.Size(251, 29);
            this.peiOkulNoAra.TabIndex = 79;
            this.peiOkulNoAra.TextChanged += new System.EventHandler(this.peiOkulNoAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(822, 455);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // peiTeslimAl
            // 
            this.peiTeslimAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.peiTeslimAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peiTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peiTeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.peiTeslimAl.Location = new System.Drawing.Point(174, 414);
            this.peiTeslimAl.Name = "peiTeslimAl";
            this.peiTeslimAl.Size = new System.Drawing.Size(184, 36);
            this.peiTeslimAl.TabIndex = 88;
            this.peiTeslimAl.Text = "TESLİM AL";
            this.peiTeslimAl.UseVisualStyleBackColor = false;
            this.peiTeslimAl.Click += new System.EventHandler(this.peiTeslimAl_Click);
            // 
            // pemanetiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1392, 603);
            this.ControlBox = false;
            this.Controls.Add(this.peiTeslimAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.peiOkulNoAra);
            this.Controls.Add(this.peiBarkodNoAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pklBtnGeriKayit);
            this.Name = "pemanetiade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.pemanetiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pklBtnGeriKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox peiBarkodNoAra;
        private System.Windows.Forms.TextBox peiOkulNoAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button peiTeslimAl;
    }
}