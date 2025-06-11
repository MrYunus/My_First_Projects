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
using System.Text.RegularExpressions;

namespace l
{
    public partial class FrmKayıtPersonel : Form
    {
        public FrmKayıtPersonel()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LblPersonelNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 frm1donus2 = new Frm1();
            frm1donus2.ShowDialog();
        }

        private void FrmKayıtPersonel_Load(object sender, EventArgs e)
        {

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into PersonelKayit5 (adi, soyadi, email, tcno, sifre) VALUES (@adi, @soyadi, @email, @tcno, @sifre)", connection);
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
            FrmPersonelGiris girisekranı = new FrmPersonelGiris();
            girisekranı.ShowDialog();

        }
        int check(string fkpTxtEmail)
        {
            connection.Open();
            string query = "select count(*) from personelKayit5 where email='" + fkpTxtEmail + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v=(int)command.ExecuteScalar();
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
