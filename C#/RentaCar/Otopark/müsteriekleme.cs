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
    public partial class müsteriekleme : Form
    {
        Arac_Kiralama Arac_Kiralama = new Arac_Kiralama();
        public müsteriekleme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=Otopark;Integrated Security=True;TrustServerCertificate=True");


        private void fkoBtnKayit_Click(object sender, EventArgs e)
        {
            string cümle = "insert into musteri (tc, adsoyad, telefon, adres, email) VALUES (@tc, @adsoyad, @telefon, @adres, @email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", fkpTxtAdi.Text);
            komut2.Parameters.AddWithValue("@adsoyad", fkpTxtSoyadi.Text);
            komut2.Parameters.AddWithValue("@telefon", fkpTxtEmail.Text);
            komut2.Parameters.AddWithValue("@adres", fkpTxtTc.Text);
            komut2.Parameters.AddWithValue("@email", textBox1.Text);
            Arac_Kiralama.ekle_sil_güncelle(komut2, cümle);
            MessageBox.Show("kayıt olundu");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";


        }

        private void müsteriekleme_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa frm1donus2 = new anasayfa();
            frm1donus2.ShowDialog();
        }

        private void pueBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa frm1donus3 = new anasayfa();
            frm1donus3.ShowDialog();
        }
    }
}
