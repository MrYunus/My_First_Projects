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
    public partial class uye : Form
    {
        public uye()
        {
            InitializeComponent();
        }
        private void uyelistele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from OgrenciKayit",connection);
            adtr.Fill(daset, "OgrenciKayit");
            dataGridView1.DataSource = daset.Tables["OgrenciKayit"];
            connection.Close();
        }
        private void puyelisteleme_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void pulBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus2 = new arayuz();
            donus2.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pulOgrenciNumarasi.Text = dataGridView1.CurrentRow.Cells["fkoOgrenciNo"].Value.ToString();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void pulOgrenciNumarasi_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from OgrenciKayit where fkoOgrenciNo like '"+pulOgrenciNumarasi.Text+"'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                pulTxtAdi.Text = read["fkoAdi"].ToString();
                pulTxtSoyadi.Text = read["fkoSoyadi"].ToString();
                pulTxtEmail.Text = read["fkoEmail"].ToString();
                pulOgrenciNumarasi.Text = read["fkoOgrenciNo"].ToString();
            }
            connection.Close();
        }
        DataSet daset=new DataSet();
        private void pulOgrenciAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["OgrenciKayit"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from OgrenciKayit where fkoOgrenciNo like '%" + pulOgrenciAra.Text + "%'", connection);
            adtr.Fill(daset,"OgrenciKayit");
            dataGridView1.DataSource = daset.Tables["OgrenciKayit"];
            connection.Close();
        }

        private void pulSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("bu kaydı silmek mi istiyorsunuz?","sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from OgrenciKayit where fkoOgrenciNo=@fkoOgrenciNo", connection);
                command.Parameters.AddWithValue("@fkoOgrenciNo", dataGridView1.CurrentRow.Cells["fkoOgrenciNo"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Silme işlemi gerçekleşti");
                daset.Tables["OgrenciKayit"].Clear();
                uyelistele();
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
            SqlCommand command = new SqlCommand("update OgrenciKayit set fkoAdi=@fkoAdi,fkoSoyadi=@fkoSoyadi,fkoEmail=@fkoEmail where fkoOgrenciNo=@fkoOgrenciNo", connection); command.Parameters.AddWithValue("@fkoOgrenciNo", pulOgrenciNumarasi.Text);
            command.Parameters.AddWithValue("@fkoAdi", pulTxtAdi.Text);
            command.Parameters.AddWithValue("@fkoSoyadi", pulTxtSoyadi.Text);
            command.Parameters.AddWithValue("@fkoEmail", pulTxtEmail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            daset.Tables["OgrenciKayit"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }
    }
}
