using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    internal class Arac_Kiralama
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=Otopark;Integrated Security=True;TrustServerCertificate=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            connection.Open();
            komut.Connection = connection;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            connection.Close();

        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, connection);
            adtr.Fill(tablo);
            connection.Close();
            return tablo;
        }
        public void TC_Ara(TextBox tcara,TextBox tc, TextBox adsoyad,TextBox telefon, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString() ;

            }
            connection.Close();
        }
        public void Ücret_Hesapla(ComboBox combokiraşekli, TextBox ucret, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokiraşekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                if (combokiraşekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString())*0.80).ToString();
                if (combokiraşekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();

            }
            connection.Close();
        }
        public void Boş_Araçlar(ComboBox combo, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            connection.Close();
        }
        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil,TextBox renk, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["seri"].ToString();
            }
            connection.Close();
        }
        public void satışhesapla(Label label2)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select sum(tutar) from satış", connection);
                object result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                    label2.Text = "Toplam Tutar = " + result.ToString() + " TL";
                else
                    label2.Text = "Toplam Tutar = 0 TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
} 
