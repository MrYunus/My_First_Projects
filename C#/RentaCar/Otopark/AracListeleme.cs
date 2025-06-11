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
    public partial class AracListeleme : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public AracListeleme()
        {
            InitializeComponent();
        }

        private void pueBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa kayitdonu55 = new anasayfa();
            kayitdonu55.ShowDialog();
        }

        private void AracListeleme_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            comboAraçlar.SelectedIndex = 0;
        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select * from araç ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtplaka.Text = satır.Cells["plaka"].Value.ToString();
            combomarka.Text = satır.Cells["marka"].Value.ToString();
            comboseri.Text = satır.Cells["seri"].Value.ToString();
            txtmodel.Text = satır.Cells["yil"].Value.ToString();
            txtrenk.Text = satır.Cells["renk"].Value.ToString();
            txtkm.Text = satır.Cells["km"].Value.ToString();
            comboyakıt.Text = satır.Cells["yakit"].Value.ToString();
            txtkiraucret.Text = satır.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void fkoBtnKayit_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtplaka.Text);
            komut2.Parameters.AddWithValue("@marka", combomarka.Text);
            komut2.Parameters.AddWithValue("@seri", comboseri.Text);
            komut2.Parameters.AddWithValue("@yil", txtmodel.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@km", txtkm.Text);
            komut2.Parameters.AddWithValue("@yakit", comboyakıt.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtkiraucret.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            comboseri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            YenileAraçlarListesi();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            YenileAraçlarListesi();

        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraçlar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (comboAraçlar.SelectedIndex == 1)
                {
                    string cümle = "select * from araç where durumu='BOŞ' ";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
                if (comboAraçlar.SelectedIndex == 2)
                {
                    string cümle = "select * from araç where durumu='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
            }
            catch {; }
        }
    }
}
