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

namespace l
{
    public partial class pemanetekleme : Form
    {
        public pemanetekleme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet daset = new DataSet();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void kitapsayisi()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select sum(stoksayisi) from sepet", connection);
            lblkitapsayi.Text = cmd.ExecuteScalar().ToString();
            connection.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pemanetekleme_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayisi();
        }
        private void sepetlistele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", connection);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            connection.Close();
        }

        private void pklBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus111 = new arayuz();
            donus111.ShowDialog();
        }

        private void peeEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into sepet(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,teslimtarihi,iadetarihi,stoksayisi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@teslimtarihi,@iadetarihi,@stoksayisi)", connection);
            cmd.Parameters.AddWithValue("@barkodno", peeBarkodNo.Text);
            cmd.Parameters.AddWithValue("@kitapadi", peeKitapAdi.Text);
            cmd.Parameters.AddWithValue("@yazari", peeYazar.Text);
            cmd.Parameters.AddWithValue("@yayinevi", peeYayinevi.Text);
            cmd.Parameters.AddWithValue("@sayfasayisi", peeSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@teslimtarihi", peeTeslimTarihi.Text);
            cmd.Parameters.AddWithValue("@iadetarihi", peeİadeTarihi.Text);
            cmd.Parameters.AddWithValue("@stoksayisi", int.Parse(peeStoksayısı.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("kitap sepete eklendi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblkitapsayi.Text = "";
            kitapsayisi();
            foreach (Control item in peeKitapBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    if (item != peeStoksayısı)
                        item.Text = "";
                }
            }
        }

        private void peeOgrenciNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from OgrenciKayit where fkoOgrenciNo like'%" + peeOgrenciNo.Text + "%'", connection);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                peeAdi.Text = read["fkoAdi"].ToString();
                peeSoyadi.Text = read["fkoSoyadi"].ToString();
                peeMail.Text = read["fkoEmail"].ToString();
            }
            connection.Close();
            connection.Open();
            SqlCommand komut2 = new SqlCommand("select sum(stoksayisi) from EmanetKitaplar", connection);
            lblkayitlikitapsayi.Text = komut2.ExecuteScalar().ToString();
            connection.Close();
            if (peeOgrenciNo.Text == "")
            {
                foreach (Control item in peeUyeBilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblkayitlikitapsayi.Text = "";
                    }
                }
            }
        }

        private void peeBarkodNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Kitap2 where barkodno like'%" + peeBarkodNo.Text + "%'", connection);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                peeKitapAdi.Text = read["kitapadi"].ToString();
                peeYazar.Text = read["yazar"].ToString();
                peeYayinevi.Text = read["yayınevi"].ToString();
                peeSayfaSayisi.Text = read["sayfasayisi"].ToString();
            }
            connection.Close();
            if (peeBarkodNo.Text == "")
            {
                foreach (Control item in peeKitapBilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        if ((item != peeStoksayısı))
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void peeSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("silme işlemi yapıldı", "silme işlemi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblkitapsayi.Text = "";
            kitapsayisi();
        }

        private void peeTeslimEtme_Click(object sender, EventArgs e)
        {
            if (lblkitapsayi.Text != "")
            {
                if (lblkayitlikitapsayi.Text == "" && int.Parse(lblkitapsayi.Text) <= 5 || lblkayitlikitapsayi.Text != "" && int.Parse(lblkayitlikitapsayi.Text) + int.Parse(lblkitapsayi.Text) <= 5)
                {
                    if (peeOgrenciNo.Text != "" && peeAdi.Text != "" && peeSoyadi.Text != "" && peeMail.Text != "")
                    {
                        connection.Open();  

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            SqlCommand komut = new SqlCommand("INSERT INTO EmanetKitaplar (OgrenciNo, Adi, Soyadi, Mail, BarkodNo, KitapAdi, Yazari, Yayinevi, SayfaSayisi, TeslimTarihi, IadeTarihi, stoksayisi) " +
                                                              "VALUES (@OgrenciNo, @Adi, @Soyadi, @Mail, @BarkodNo, @KitapAdi, @Yazari, @Yayinevi, @SayfaSayisi, @TeslimTarihi, @IadeTarihi, @stoksayisi)", connection);

                            komut.Parameters.AddWithValue("@OgrenciNo", peeOgrenciNo.Text);
                            komut.Parameters.AddWithValue("@Adi", peeAdi.Text);
                            komut.Parameters.AddWithValue("@Soyadi", peeSoyadi.Text);
                            komut.Parameters.AddWithValue("@Mail", peeMail.Text);
                            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("@KitapAdi", dataGridView1.Rows[i].Cells["KitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("@Yazari", dataGridView1.Rows[i].Cells["Yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("@Yayinevi", dataGridView1.Rows[i].Cells["Yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@SayfaSayisi", dataGridView1.Rows[i].Cells["SayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@TeslimTarihi", dataGridView1.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@IadeTarihi", dataGridView1.Rows[i].Cells["IadeTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@stoksayisi", int.Parse(dataGridView1.Rows[i].Cells["stoksayisi"].Value.ToString()));
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("UPDATE OgrenciKayit SET okukitapsayisi = okukitapsayisi + @StokSayisi WHERE fkoOgrenciNo = @OgrenciNo", connection);
                            komut2.Parameters.AddWithValue("@StokSayisi", int.Parse(dataGridView1.Rows[i].Cells["stoksayisi"].Value.ToString()));
                            komut2.Parameters.AddWithValue("@OgrenciNo", peeOgrenciNo.Text);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("UPDATE Kitap2 SET stoksayisi = stoksayisi - @StokSayisi WHERE barkodno = @BarkodNo", connection);
                            komut3.Parameters.AddWithValue("@StokSayisi", int.Parse(dataGridView1.Rows[i].Cells["stoksayisi"].Value.ToString()));
                            komut3.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut3.ExecuteNonQuery();
                        }

                        SqlCommand komut4 = new SqlCommand("DELETE FROM sepet", connection);
                        komut4.ExecuteNonQuery();

                        connection.Close();  

                        MessageBox.Show("Kitaplar emanet edildi.");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        peeOgrenciNo.Text = "";
                        lblkitapsayi.Text = "";
                        kitapsayisi();
                        lblkayitlikitapsayi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gerekli.", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 5'den fazla olamaz.", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Önce sepete kitap ekleyiniz.", "Uyarı");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}