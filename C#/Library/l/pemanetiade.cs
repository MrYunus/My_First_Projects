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
    public partial class pemanetiade : Form
    {
        public pemanetiade()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet daset = new DataSet();
        private void pklBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus000 = new arayuz();
            donus000.ShowDialog();
        }

        private void pemanetiade_Load(object sender, EventArgs e)
        {
            EmanetListele();

        }
        private void EmanetListele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", connection);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void peiBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where BarkodNo like'%"+peiBarkodNoAra.Text+"%'", connection);
            adtr.Fill(daset, "EmanetKitaplar");
            connection.Close();
            if(peiBarkodNoAra.Text=="")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void peiOkulNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where OgrenciNo like'%" + peiOkulNoAra.Text + "%'", connection);
            adtr.Fill(daset, "EmanetKitaplar");
            connection.Close();
            if (peiOkulNoAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void peiTeslimAl_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut3 = new SqlCommand("delete from EmanetKitaplar where OgrenciNo=@OgrenciNo and BarkodNo=@BarkodNo", connection);
            komut3.Parameters.AddWithValue("@OgrenciNo", dataGridView1.CurrentRow.Cells["OgrenciNo"].Value.ToString());
            komut3.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut3.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("iade işlemi yapıldı.");
            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }
    }
}
