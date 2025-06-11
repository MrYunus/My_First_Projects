using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class frmSatış : Form
    {
        private DataGridViewRow secilenSatir = null;
        public frmSatış()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=Otopark;Integrated Security=True;TrustServerCertificate=True");

        Arac_Kiralama arac = new Arac_Kiralama();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSatış_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from satış";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu2);
            arac.satışhesapla(label2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pueBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa kayitdonu11 = new anasayfa();
            kayitdonu11.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                secilenSatir = dataGridView1.Rows[e.RowIndex];
            }
        }
        private int LabeldenSayiCek(string text)
        {
            string rakamlar = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == ',' || c == '.')
                    rakamlar += c;
            }

            rakamlar = rakamlar.Replace(",", "").Replace(".", "");

            int sayi;
            if (int.TryParse(rakamlar, out sayi))
                return sayi;
            else
                return 0;
        }

        private void btnVerildi_Click(object sender, EventArgs e)
        {
            if (secilenSatir == null)
            {
                MessageBox.Show("Lütfen önce bir satıra çift tıklayarak seçim yapınız.");
                return;
            }

            int cikarilacakSayi = 0;
            if (!int.TryParse(secilenSatir.Cells["gun"].Value?.ToString(), out cikarilacakSayi))
            {
                MessageBox.Show("Satırdaki sayı değeri alınamadı.");
                return;
            }

            int mevcutSayi = LabeldenSayiCek(label2.Text);

            int yeniSayi = mevcutSayi - cikarilacakSayi;
            if (yeniSayi < 0) yeniSayi = 0;

            label2.Text = "Toplam Tutar = " + yeniSayi.ToString() + " TL";

            string connectionString = "Data Source=DESKTOP-3JFMBIJ;Initial Catalog=Otopark;Integrated Security=True;TrustServerCertificate=True";

            string plaka = secilenSatir.Cells["plaka"].Value?.ToString();
            if (string.IsNullOrEmpty(plaka))
            {
                MessageBox.Show("Silinecek plaka değeri alınamadı.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM satış WHERE plaka = @plaka";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@plaka", plaka);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            dataGridView1.Rows.Remove(secilenSatir);
                            secilenSatir = null;
                        }
                        else
                        {
                            MessageBox.Show("Veritabanında silinecek kayıt bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }
    }
}
