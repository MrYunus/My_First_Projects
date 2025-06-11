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
    public partial class müsterilisteleme : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public müsterilisteleme()
        {
            InitializeComponent();
        }

        private void pueBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa frm1donus2 = new anasayfa();
            frm1donus2.ShowDialog();
        }

        private void müsterilisteleme_Load(object sender, EventArgs e)
        {
            YenileListele();

        }

        private void YenileListele()
        {
            string cümle = "select * from musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();

            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "ADRES";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "EMAİL";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from musteri where tc like'%"+textBox2.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();


            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            fkpTxtAdi.Text = satır.Cells[0].Value.ToString();
            fkpTxtSoyadi.Text = satır.Cells[1].Value.ToString();
            fkpTxtEmail.Text = satır.Cells[2].Value.ToString();
            fkpTxtTc.Text = satır.Cells[3].Value.ToString();
            textBox1.Text = satır.Cells[4].Value.ToString();

        }

        private void fkoBtnKayit_Click(object sender, EventArgs e)
        {
            string cümle = "update musteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", fkpTxtAdi.Text);
            komut2.Parameters.AddWithValue("@adsoyad", fkpTxtSoyadi.Text);
            komut2.Parameters.AddWithValue("@telefon", fkpTxtEmail.Text);
            komut2.Parameters.AddWithValue("@adres", fkpTxtTc.Text);
            komut2.Parameters.AddWithValue("@email", textBox1.Text);
            MessageBox.Show("güncellendi");
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from musteri where tc='" + satır.Cells["tc"].Value.ToString() + "'";
            SqlCommand komut2=new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }
    }
}
