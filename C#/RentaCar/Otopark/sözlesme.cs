using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class sözlesme : Form
    {
        public sözlesme()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sözlesme_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sözleşme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void Boş_Araçlar()
        {
            string sorgu2 = "select * from araç where durumu='BOŞ'";
            arac.Boş_Araçlar(comboAraçlar, sorgu2);
        }

        private void pueBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa kayitdonu11 = new anasayfa();
            kayitdonu11.ShowDialog();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from araç where plaka like'%" + comboAraçlar.SelectedItem + "%'";
            arac.CombodanGetir(comboAraçlar,txtMarka,txtSeri,txtYil,txtRenk,sorgu2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from araç where plaka like'%" + comboAraçlar.SelectedItem + "%'";
            arac.Ücret_Hesapla(combokirasekli,txtkiraücret,sorgu2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                // Sadece tarih kısmını al (saatleri sıfırla)
                DateTime cikis = datecikis.Value.Date;
                DateTime donus = datedönüs.Value.Date;

                TimeSpan fark = donus - cikis;
                int gunSayisi = fark.Days;

                // En az 1 gün saymak için kontrol
                if (gunSayisi <= 0)
                {
                    MessageBox.Show("Dönüş tarihi çıkış tarihinden sonra olmalıdır!");
                    return;
                }

                txtgün.Text = gunSayisi.ToString();

                if (int.TryParse(txtkiraücret.Text, out int gunlukUcret))
                {
                    int toplamTutar = gunSayisi * gunlukUcret;
                    txtTutar.Text = toplamTutar.ToString();
                }
                else
                {
                    MessageBox.Show("Günlük ücret alanı geçerli değil!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void Temizle()
        {
            datecikis.Text = DateTime.Now.ToShortDateString();
            datedönüs.Text = DateTime.Now.ToShortDateString();
            combokirasekli.Text = "";
            txtkiraücret.Text = "";
            txtgün.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tarihlerden gün sayısını hesapla (saat sıfır)
                DateTime cikis = datecikis.Value.Date;
                DateTime donus = datedönüs.Value.Date;

                int gunSayisi = (donus - cikis).Days;

                if (gunSayisi <= 0)
                {
                    MessageBox.Show("Dönüş tarihi çıkış tarihinden sonra olmalıdır!");
                    return;
                }

                string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih) " +
                                "values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", txtTc.Text);
                komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut2.Parameters.AddWithValue("@ehliyetno", txtehlitetno.Text);
                komut2.Parameters.AddWithValue("@e_tarih", txtehliyettarihi.Text);
                komut2.Parameters.AddWithValue("@e_yer", txteverildiğiyer.Text);
                komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
                komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
                komut2.Parameters.AddWithValue("@yil", txtYil.Text);
                komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut2.Parameters.AddWithValue("@kirasekli", combokirasekli.Text);

                // Günlük ücret
                if (!int.TryParse(txtkiraücret.Text, out int gunlukUcret))
                {
                    MessageBox.Show("Günlük ücret geçersiz!");
                    return;
                }
                komut2.Parameters.AddWithValue("@kiraucreti", gunlukUcret);

                komut2.Parameters.AddWithValue("@gun", gunSayisi);

                // Toplam tutar
                int toplamTutar = gunSayisi * gunlukUcret;
                komut2.Parameters.AddWithValue("@tutar", toplamTutar);

                // Tarihleri DateTime olarak veritabanına gönder
                komut2.Parameters.AddWithValue("@ctarih", cikis);
                komut2.Parameters.AddWithValue("@dtarih", donus);

                arac.ekle_sil_güncelle(komut2, sorgu2);

                string sorgu3 = "update araç set durumu='DOLU' where plaka=@plaka";
                SqlCommand komut3 = new SqlCommand();
                komut3.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
                arac.ekle_sil_güncelle(komut3, sorgu3);

                MessageBox.Show("Müşteriye araç eklendi");

                comboAraçlar.Items.Clear();
                Boş_Araçlar();
                Temizle();

                foreach (Control item in groupBox1.Controls)
                    if (item is TextBox) item.Text = "";

                foreach (Control item in groupBox2.Controls)
                    if (item is TextBox) item.Text = "";

                comboAraçlar.Text = "";
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            if (txttcara.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from musteri where tc like'%" + txttcara.Text + "%'";
            arac.TC_Ara(txttcara,txtTc, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void btnsözgüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözleşme set tc=@tc, adsoyad=@adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih=@e_tarih, e_yer=@e_yer, marka=@marka, seri=@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti=@kiraucreti, gun=@gun, tutar=@tutar, ctarih=@ctarih, dtarih=@dtarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtehlitetno.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtehliyettarihi.Text);
            komut2.Parameters.AddWithValue("@e_yer", txteverildiğiyer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", combokirasekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtkiraücret.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtgün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", datecikis.Text);
            komut2.Parameters.AddWithValue("@dtarih", datedönüs.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);
            MessageBox.Show("Sözleşme bilgileri güncellendi, sayfaya çıkış yapıp giriniz");
            comboAraçlar.Items.Clear();
            Boş_Araçlar();
            Temizle();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text=satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtehlitetno.Text = satır.Cells[3].Value.ToString();
            txtehliyettarihi.Text = satır.Cells[4].Value.ToString();
            txteverildiğiyer.Text = satır.Cells[5].Value.ToString();
            comboAraçlar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtYil.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            combokirasekli.Text = satır.Cells[11].Value.ToString();
            txtkiraücret.Text = satır.Cells[12].Value.ToString();
            txtgün.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            datecikis.Text = satır.Cells[15].Value.ToString();
            datedönüs.Text = satır.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            DateTime bugün = DateTime.Now;
            DateTime dönüş = DateTime.Parse(satır.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarkı = bugün - dönüş;
            int _gunfarkı =gunfarkı.Days;
            int ucretfarkı;
            ucretfarkı = _gunfarkı * ucret;
            txtextra.Text = ucretfarkı.ToString();
        }

        private void fkoBtnKayit_Click(object sender, EventArgs e)
        {
            if (txtextra.Text != "")
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Today; // Teslim tarihi (bugün)

                DateTime cikis, donus;
                if (DateTime.TryParse(satır.Cells["ctarih"].Value.ToString(), out cikis) &&
                    DateTime.TryParse(satır.Cells["dtarih"].Value.ToString(), out donus))
                {
                    int _gun = (donus - cikis).Days;
                    if (_gun <= 0)
                        _gun = 1;

                    // Kiralama ücreti
                    int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());

                    int toplamtutar = _gun * ucret;

                    MessageBox.Show($"Gün: {_gun}\nÜcret: {ucret}\nTutar: {toplamtutar}");

                    string sorgu1 = "delete from sözleşme where plaka= @plaka";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                    arac.ekle_sil_güncelle(komut, sorgu1);

                    string sorgu2 = "update araç set durumu = 'BOŞ' where plaka = @plaka";
                    SqlCommand komut3 = new SqlCommand();
                    komut3.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                    arac.ekle_sil_güncelle(komut3, sorgu2);

                    string sorgu3 = "insert into satış(tc,adsoyad,plaka,marka,seri,yil,renk,gun,fiyat,tutar,tarih1,tarih2) " +
                                    "values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@fiyat,@tutar,@tarih1,@tarih2)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                    komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                    komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                    komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                    komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                    komut2.Parameters.AddWithValue("@yil", satır.Cells["yil"].Value.ToString());
                    komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                    komut2.Parameters.AddWithValue("@gun", _gun);
                    komut2.Parameters.AddWithValue("@fiyat", ucret);
                    komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                    komut2.Parameters.AddWithValue("@tarih1", cikis);
                    komut2.Parameters.AddWithValue("@tarih2", bugün);

                    arac.ekle_sil_güncelle(komut2, sorgu3);

                    MessageBox.Show("Araç teslim edildi");

                    comboAraçlar.Text = "";
                    comboAraçlar.Items.Clear();
                    Boş_Araçlar();
                    Yenile();

                    foreach (Control item in groupBox1.Controls)
                        if (item is TextBox) item.Text = "";

                    foreach (Control item in groupBox2.Controls)
                        if (item is TextBox) item.Text = "";

                    comboAraçlar.Text = "";
                    Temizle();
                    txtextra.Text = "";
                }
                else
                {
                    MessageBox.Show("Tarih bilgileri okunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtextra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgün_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
