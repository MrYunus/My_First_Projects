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

namespace l
{
    public partial class pkitaplekleme1 : Form
    {
        public pkitaplekleme1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void pkitaplisteleme_Load(object sender, EventArgs e)
        {

        }

        private void pkeBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus7 = new arayuz();
            donus7.ShowDialog();
        }

        private void pkeBtnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap2 (barkodno, kitapadi, yazar, yayınevi, sayfasayisi, rafnumarasi, yayinlanmatarihi, turu,stoksayisi) VALUES (@barkodno, @kitapadi, @yazar, @yayınevi, @sayfasayisi, @rafnumarasi, @yayinlanmatarihi ,@turu, @stoksayisi)", connection);
            komut.Parameters.AddWithValue("@barkodno", pkeTxtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", pkeTxtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", pkeTxtYazar.Text);
            komut.Parameters.AddWithValue("@yayınevi", pkeTxtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", pkeTxtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@rafnumarasi", pkeStokSayısı.Text);
            komut.Parameters.AddWithValue("@yayinlanmatarihi", DateTime.Parse(pkeDateYayinlanmaTarih.Text));
            komut.Parameters.AddWithValue("@turu", pkeComboTur.Text);
            komut.Parameters.AddWithValue("@stoksayisi", pkeStokSayısı.Text);

            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("kitap eklendi");
            pkeTxtBarkodNo.Text = "";
            pkeTxtKitapAdi.Text = "";
            pkeTxtYazar.Text = "";
            pkeTxtYayinevi.Text = "";
            pkeTxtSayfaSayisi.Text = "";
            pkeStokSayısı.Text = "";
            pkeDateYayinlanmaTarih.Text = "";
            pkeComboTur.Text = "";
            this.Hide();
            arayuz donus8 = new arayuz();
            donus8.ShowDialog();
        }
    }
}
