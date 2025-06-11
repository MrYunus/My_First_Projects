namespace l
{
    partial class ogrenciarayuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciarayuz));
            this.btnAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.oaara = new System.Windows.Forms.TextBox();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.oaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageIndex = 1;
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(1211, 199);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(110, 42);
            this.btnAra.TabIndex = 88;
            this.btnAra.Text = "ARA...";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ara.jpeg");
            this.ımageList1.Images.SetKeyName(1, "arraa.png");
            this.ımageList1.Images.SetKeyName(2, "32.png");
            // 
            // oaara
            // 
            this.oaara.BackColor = System.Drawing.Color.White;
            this.oaara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oaara.Location = new System.Drawing.Point(590, 196);
            this.oaara.Multiline = true;
            this.oaara.Name = "oaara";
            this.oaara.Size = new System.Drawing.Size(610, 46);
            this.oaara.TabIndex = 89;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(143, 318);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.Size = new System.Drawing.Size(1696, 603);
            this.dgvKitaplar.TabIndex = 90;
            // 
            // oaDon
            // 
            this.oaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.oaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oaDon.ImageKey = "32.png";
            this.oaDon.ImageList = this.ımageList1;
            this.oaDon.Location = new System.Drawing.Point(37, 47);
            this.oaDon.Name = "oaDon";
            this.oaDon.Size = new System.Drawing.Size(234, 67);
            this.oaDon.TabIndex = 91;
            this.oaDon.Text = "GİRİŞ SAYFASINA DÖN";
            this.oaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.oaDon.UseVisualStyleBackColor = false;
            this.oaDon.Click += new System.EventHandler(this.oaDon_Click);
            // 
            // ogrenciarayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(241)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.oaDon);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.oaara);
            this.Controls.Add(this.btnAra);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ogrenciarayuz";
            this.ShowIcon = false;
            this.Text = "OGRENCI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ogrenciarayuz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox oaara;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Button oaDon;
    }
}