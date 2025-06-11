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
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 frm1donus3 = new Frm1();
            frm1donus3.ShowDialog();
        }

        private void LblHesapOlustur_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayıtOgrenci kayitdonus = new FrmKayıtOgrenci();
            kayitdonus.ShowDialog();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtOkulNo.Text) && !string.IsNullOrEmpty(TxtSifre.Text))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM OgrenciKayit WHERE fkoOgrenciNo = @fkoOgrenciNo AND fkoSifre = @fkoSifre";
                    SqlCommand komut = new SqlCommand(query, connection);
                    komut.Parameters.AddWithValue("@fkoOgrenciNo", TxtOkulNo.Text);
                    komut.Parameters.AddWithValue("@fkoSifre", TxtSifre.Text);
                    int sonuc = (int)komut.ExecuteScalar();
                    if (sonuc == 1) 
                    {
                        MessageBox.Show("Hoşgeldiniz!");
                        TxtOkulNo.Text = "";
                        TxtSifre.Text = "";
                        this.Hide();
                        ogrenciarayuz ogrenciPaneli = new ogrenciarayuz();
                        ogrenciPaneli.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("Yanlış öğrenci numarası veya şifre!", "Hata");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }

        }

        private void CBoxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxSifreyiGoster.Checked)
            {
                TxtSifre.PasswordChar = '\0';
            }
            else
            {
                TxtSifre.PasswordChar = '*';
            }
        }
    }
}
