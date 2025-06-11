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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace l
{
    public partial class pkitaplisteleme : Form
    {
        public pkitaplisteleme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet daset = new DataSet();
        private void kitaplistele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap2", connection);
            adtr.Fill(daset, "Kitap2");
            dataGridView1.DataSource = daset.Tables["Kitap2"];
            connection.Close();
        }
        private void pkitaplisteleme_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void pulBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus111 = new arayuz();
            donus111.ShowDialog();
        }

        private void pulSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("bu kaydı silmek mi istiyorsunuz?", "sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Kitap2 where barkodno=@barkodno", connection);
                command.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Silme işlemi gerçekleşti");
                daset.Tables["Kitap2"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

        }

        private void pulGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Kitap2 set kitapadi=@kitapadi, yazar=@yazar, yayınevi=@yayınevi, sayfasayisi=@sayfasayisi, rafnumarasi=@rafnumarasi, turu=@turu, stoksayisi=@stoksayisi where barkodno=@barkodno", connection);

            if (command.Parameters.Contains("@barkodno"))
            {
                command.Parameters.Remove("@barkodno");
            }

            command.Parameters.AddWithValue("@barkodno", pklBarkodNo.Text);
            command.Parameters.AddWithValue("@kitapadi", pklKitapAdi.Text);
            command.Parameters.AddWithValue("@yazar", pklYazar.Text);
            command.Parameters.AddWithValue("@yayınevi", pklYayinevi.Text);
            command.Parameters.AddWithValue("@sayfasayisi", pklSayfaSayisi.Text);
            command.Parameters.AddWithValue("@rafnumarasi", pklRafNumarasi.Text);
            command.Parameters.AddWithValue("@turu", pklTürü.Text);
            command.Parameters.AddWithValue("@stoksayisi", textBox1.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");

            daset.Tables["Kitap2"].Clear();
            kitaplistele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        

    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pklBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Kitap2"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap2 where barkodno like '%" + pklBarkodNoAra.Text + "%'", connection);
            adtr.Fill(daset, "Kitap2");
            dataGridView1.DataSource = daset.Tables["Kitap2"];
            connection.Close();

        }

        private void pklBarkodNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Kitap2 where barkodno=@barkodno", connection);
            command.Parameters.AddWithValue("@barkodno", pklBarkodNo.Text);

            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                pklKitapAdi.Text = read["kitapadi"].ToString();
                pklYazar.Text = read["yazar"].ToString();
                pklYayinevi.Text = read["yayınevi"].ToString();
                pklSayfaSayisi.Text = read["sayfasayisi"].ToString();
                pklRafNumarasi.Text = read["rafnumarasi"].ToString();
                pklTürü.Text = read["turu"].ToString();
                textBox1.Text = read["stoksayisi"].ToString();
            }
            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pklBarkodNo.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
        }
    }
}