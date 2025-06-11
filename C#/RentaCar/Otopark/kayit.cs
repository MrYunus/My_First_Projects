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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=Otopark;Integrated Security=True;TrustServerCertificate=True");


        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            giris frm1donus2 = new giris();
            frm1donus2.ShowDialog();
        }

        private void fkoBtnKayit_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into personel (adi, soyadi, email, tcno, sifre) VALUES (@adi, @soyadi, @email, @tcno, @sifre)", connection);
            command.Parameters.AddWithValue("@adi", fkpTxtAdi.Text);
            command.Parameters.AddWithValue("@soyadi", fkpTxtSoyadi.Text);
            command.Parameters.AddWithValue("@email", fkpTxtEmail.Text);
            command.Parameters.AddWithValue("@tcno", fkpTxtTc.Text);
            command.Parameters.AddWithValue("@sifre", fkpTxtSifre.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("kayıt olundu");
            fkpTxtAdi.Text = "";
            fkpTxtSoyadi.Text = "";
            fkpTxtEmail.Text = "";
            fkpTxtTc.Text = "";
            fkpTxtSifre.Text = "";
            this.Hide();
            giris girisekranı = new giris();
            girisekranı.ShowDialog();

        }
        int check(string fkpTxtEmail)
        {
            connection.Open();
            string query = "select count(*) from personelKayit5 where email='" + fkpTxtEmail + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void CBoxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxSifreyiGoster.Checked)
            {
                fkpTxtSifre.PasswordChar = '\0';
                fkpTxtSifreTekrar.PasswordChar = '\0';
            }
            else
            {
                fkpTxtSifre.PasswordChar = '*';
                fkpTxtSifreTekrar.PasswordChar = '*';
            }
        }
    }
}
