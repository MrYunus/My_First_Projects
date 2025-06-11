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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=Otopark;Integrated Security=True;TrustServerCertificate=True");

        private void LblHesapOlustur_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayit kayitdonu1 = new kayit();
            kayitdonu1.ShowDialog();
        }

        private void fpgCBoxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (fpgCBoxSifreyiGoster.Checked)
            {
                fpgTxtSifre.PasswordChar = '\0';
            }
            else
            {
                fpgTxtSifre.PasswordChar = '*';
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void fpgBtnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fpgTxtPersonelTc.Text) && !string.IsNullOrEmpty(fpgTxtSifre.Text))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM personel WHERE tcno = @tcno AND sifre = @sifre";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tcno", fpgTxtPersonelTc.Text);
                    command.Parameters.AddWithValue("@sifre", fpgTxtSifre.Text);
                    int v = (int)command.ExecuteScalar();

                    if (v == 1)
                    {
                        MessageBox.Show("Hoşgeldiniz!");
                        fpgTxtPersonelTc.Text = "";
                        fpgTxtSifre.Text = "";
                        this.Hide();
                        anasayfa girisyap = new anasayfa();
                        girisyap.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yanlış TC veya şifre", "Hata");
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
    }
}
