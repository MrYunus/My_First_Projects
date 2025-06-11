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
    public partial class FrmKayıtOgrenci : Form
    {
        public FrmKayıtOgrenci()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void FrmKayıtOgrenci_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 frm1donus = new Frm1();
            frm1donus.ShowDialog();
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBoxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (fkoCBoxSifreyiGoster.Checked)
            {
                fkoTxtSifre.PasswordChar = '\0';
                fkoTxtSifreTekrar.PasswordChar= '\0';
            }
            else
            {
                fkoTxtSifre.PasswordChar = '*';
                fkoTxtSifreTekrar.PasswordChar = '*';
            }
        }

        private void fkoBtnKayit_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into OgrenciKayit (fkoAdi, fkoSoyadi, fkoEmail, fkoOgrenciNo, fkoSifre) VALUES (@fkoAdi, @fkoSoyadi, @fkoEmail, @fkoOgrenciNo, @fkoSifre)", connection);
            komut.Parameters.AddWithValue("@fkoAdi", fkoTxtAdi.Text);
            komut.Parameters.AddWithValue("@fkoSoyadi", fkoTxtSoyadi.Text);
            komut.Parameters.AddWithValue("@fkoEmail", fkoTxtEmail.Text);
            komut.Parameters.AddWithValue("@fkoOgrenciNo", fkoOgrenciNumarasi.Text);
            komut.Parameters.AddWithValue("@fkoSifre", fkoTxtSifre.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("öğrenci eklendi");
            fkoTxtAdi.Text = "";
            fkoTxtSoyadi.Text = "";
            fkoTxtEmail.Text = "";
            fkoOgrenciNumarasi.Text = "";
            fkoTxtSifre.Text = "";
            this.Hide();
            FrmOgrenciGiris girisekranı2 = new FrmOgrenciGiris();
            girisekranı2.ShowDialog();

        }

        private void BtnGeriKayit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 frm1donus5 = new Frm1();
            frm1donus5.ShowDialog();
        }
    }
}
