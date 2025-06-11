using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace l
{
    public partial class püyeekleme : Form
    {
        public püyeekleme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void püyeekleme_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus6 = new arayuz();
            donus6.ShowDialog();
        }

        private void pueBtnKayit_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into OgrenciKayit (fkoAdi, fkoSoyadi, fkoEmail, fkoOgrenciNo, fkoSifre) VALUES (@fkoAdi, @fkoSoyadi, @fkoEmail, @fkoOgrenciNo, @fkoSifre)", connection);
            komut.Parameters.AddWithValue("@fkoAdi", pueTxtAdi.Text);
            komut.Parameters.AddWithValue("@fkoSoyadi", pueTxtSoyadi.Text);
            komut.Parameters.AddWithValue("@fkoEmail", pueTxtEmail.Text);
            komut.Parameters.AddWithValue("@fkoOgrenciNo", pueOgrenciNumarasi.Text);
            komut.Parameters.AddWithValue("@fkoSifre", pueTxtSifre.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("kayıt olundu");
            pueTxtAdi.Text = "";
            pueTxtSoyadi.Text = "";
            pueTxtEmail.Text = "";
            pueOgrenciNumarasi.Text = "";
            pueTxtSifre.Text = "";
            this.Hide();
            arayuz donus7 = new arayuz();
            donus7.ShowDialog();

        }

        private void pueCBoxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (pueCBoxSifreyiGoster.Checked)
            {
                pueTxtSifre.PasswordChar = '\0';
                pueTxtSifreTekrar.PasswordChar = '\0';
            }
            else
            {
                pueTxtSifre.PasswordChar = '*';
                pueTxtSifreTekrar.PasswordChar = '*';
            }
        }
    }
}
