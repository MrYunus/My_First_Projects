using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace l
{
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPersonelKodu_Click(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fpgTxtPersonelTc.Text) && !string.IsNullOrEmpty(fpgTxtSifre.Text))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM PersonelKayit5 WHERE tcno = @tcno AND sifre = @sifre";
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
                        arayuz girisyap = new arayuz();
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


        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayıtPersonel kayitdonus2 = new FrmKayıtPersonel();
            kayitdonus2.ShowDialog();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 frm1donus4 = new Frm1();
            frm1donus4.ShowDialog();
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

        private void PictureAdu_Click(object sender, EventArgs e)
        {

        }
    }
}
