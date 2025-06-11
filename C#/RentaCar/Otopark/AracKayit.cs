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
    public partial class AracKayit : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public AracKayit()
        {
            InitializeComponent();
        }

        private void AracKayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void fkoBtnKayit_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka",bir.Text);
            komut2.Parameters.AddWithValue("@marka", iki.Text);
            komut2.Parameters.AddWithValue("@seri", üc.Text);
            komut2.Parameters.AddWithValue("@yil", dort.Text);
            komut2.Parameters.AddWithValue("@renk", bes.Text);
            komut2.Parameters.AddWithValue("@km", altı.Text);
            komut2.Parameters.AddWithValue("@yakit", yedi.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(sekiz.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString()); 
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            MessageBox.Show("araba eklendi");
            if (üc.Items.Count > 0)
            üc.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.Image = null;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                üc.Items.Clear();
                if (iki.SelectedItem.ToString() == "BMW")//BMW
                {
                    üc.Items.Add("1 Serisi");
                    üc.Items.Add("2 Serisi");
                    üc.Items.Add("3 Serisi");
                    üc.Items.Add("4 Serisi");
                    üc.Items.Add("5 Serisi");
                    üc.Items.Add("6 Serisi");
                    üc.Items.Add("7 Serisi");
                    üc.Items.Add("8 Serisi");
                    üc.Items.Add("İ Serisi");
                    üc.Items.Add("M Serisi");
                    üc.Items.Add("Z Serisi");
                }
                else if (iki.SelectedItem.ToString() == "Citroen")//Citroen
                {
                    üc.Items.Add("AMI");
                    üc.Items.Add("C1");
                    üc.Items.Add("C2");
                    üc.Items.Add("C3");
                    üc.Items.Add("C4");
                    üc.Items.Add("C5");
                    üc.Items.Add("C6");
                    üc.Items.Add("C8");
                    üc.Items.Add("Saxo");
                }
                else if (iki.SelectedItem.ToString() == "Dacia")//Dacia
                {
                    üc.Items.Add("Jogger");
                    üc.Items.Add("Lodgy");
                    üc.Items.Add("Logan");
                    üc.Items.Add("Sandero");
                    üc.Items.Add("Nova");
                    üc.Items.Add("Solenza");
                }
                else if (iki.SelectedItem.ToString() == "Audi")//Audi
                {
                    üc.Items.Add("A1");
                    üc.Items.Add("A2");
                    üc.Items.Add("A3");
                    üc.Items.Add("A4");
                    üc.Items.Add("A5");
                    üc.Items.Add("A6");
                    üc.Items.Add("A7");
                    üc.Items.Add("A8");
                    üc.Items.Add("R8");
                    üc.Items.Add("RS");
                    üc.Items.Add("S Serisi");
                    üc.Items.Add("Cabrio");
                    üc.Items.Add("100 Serisi");
                }
                else if (iki.SelectedItem.ToString() == "Fiat")//Fiat
                {
                    üc.Items.Add("Albea");
                    üc.Items.Add("Bravo");
                    üc.Items.Add("Coupe");
                    üc.Items.Add("Egea");
                    üc.Items.Add("Idea");
                    üc.Items.Add("Linea");
                    üc.Items.Add("Marea");
                    üc.Items.Add("Palio");
                    üc.Items.Add("Panda");
                    üc.Items.Add("Punto");
                    üc.Items.Add("Siena");
                    üc.Items.Add("Tempra");
                    üc.Items.Add("Tipo");
                    üc.Items.Add("UNO");
                }
                else if (iki.SelectedItem.ToString() == "Ford")//ford
                {
                    üc.Items.Add("B-Max");
                    üc.Items.Add("C-Max");
                    üc.Items.Add("Escort");
                    üc.Items.Add("Fiesta");
                    üc.Items.Add("Focus");
                    üc.Items.Add("Fusion");
                    üc.Items.Add("Mondeo");
                    üc.Items.Add("Mustang");
                    üc.Items.Add("Granada");
                    üc.Items.Add("Taunus");
                }
                else if (iki.SelectedItem.ToString() == "Honda")//Honda
                {
                    üc.Items.Add("Accord");
                    üc.Items.Add("City");
                    üc.Items.Add("Civic");
                    üc.Items.Add("E");
                    üc.Items.Add("Integra");
                    üc.Items.Add("Jazz");
                    üc.Items.Add("S2000");
                    üc.Items.Add("Stream");
                }
                else if (iki.SelectedItem.ToString() == "Hyundai")//Hyundai
                {
                    üc.Items.Add("Accent");
                    üc.Items.Add("Atos");
                    üc.Items.Add("Elantra");
                    üc.Items.Add("Excel");
                    üc.Items.Add("Getz");
                    üc.Items.Add("I10");
                    üc.Items.Add("I20");
                    üc.Items.Add("I30");
                    üc.Items.Add("I40");
                    üc.Items.Add("Ioniq");
                    üc.Items.Add("Matrix");

                }
                else if (iki.SelectedItem.ToString() == "Mercedes-Benz")//Mercedes-Benz
                {
                    üc.Items.Add("A Serisi");
                    üc.Items.Add("B Serisi");
                    üc.Items.Add("C Serisi");
                    üc.Items.Add("CL");
                    üc.Items.Add("CLA");
                    üc.Items.Add("CLE");
                    üc.Items.Add("CLC");
                    üc.Items.Add("E Serisi");
                    üc.Items.Add("Maybach");
                    üc.Items.Add("R Serisi");
                    üc.Items.Add("S Serisi");
                    üc.Items.Add("SL");
                    üc.Items.Add("SLC");
                    üc.Items.Add("190");
                    üc.Items.Add("200");
                    üc.Items.Add("220");
                    üc.Items.Add("240");
                    üc.Items.Add("250");
                    üc.Items.Add("300");
                    üc.Items.Add("400");
                    üc.Items.Add("420");
                    üc.Items.Add("500");
                    üc.Items.Add("560");
                    üc.Items.Add("600");
                }
                else if (iki.SelectedItem.ToString() == "Nissan")//Nissan
                {
                    üc.Items.Add("Almera");
                    üc.Items.Add("Maxima");
                    üc.Items.Add("Micra");
                    üc.Items.Add("Note");
                    üc.Items.Add("Primera");
                    üc.Items.Add("Pulsar");
                    üc.Items.Add("Sunny");
                    üc.Items.Add("Teana");
                }
                else if (iki.SelectedItem.ToString() == "Opel")//opel
                {
                    üc.Items.Add("Adam");
                    üc.Items.Add("Astra");
                    üc.Items.Add("Calibra");
                    üc.Items.Add("Corsa");
                    üc.Items.Add("Insignia");
                    üc.Items.Add("Kadett");
                    üc.Items.Add("Meriva");
                    üc.Items.Add("Omega");
                    üc.Items.Add("Tigra");
                    üc.Items.Add("Vectra");
                    üc.Items.Add("Zafira");
                }
                else if (iki.SelectedItem.ToString() == "Peugeot")//Peugeot
                {
                    üc.Items.Add("106");
                    üc.Items.Add("107");
                    üc.Items.Add("205");
                    üc.Items.Add("206");
                    üc.Items.Add("206+");
                    üc.Items.Add("207");
                    üc.Items.Add("208");
                    üc.Items.Add("301");
                    üc.Items.Add("305");
                    üc.Items.Add("306");
                    üc.Items.Add("307");
                    üc.Items.Add("308");
                    üc.Items.Add("405");
                    üc.Items.Add("406");
                    üc.Items.Add("407");
                    üc.Items.Add("408");
                    üc.Items.Add("508");
                    üc.Items.Add("605");
                    üc.Items.Add("607");
                    üc.Items.Add("806");
                    üc.Items.Add("807");
                    üc.Items.Add("RCZ");
                    üc.Items.Add("ROA");
                    üc.Items.Add("1007");
                }
                else if (iki.SelectedItem.ToString() == "Porsche")//porsche
                {
                    üc.Items.Add("718");
                    üc.Items.Add("911");
                    üc.Items.Add("Boxster");
                    üc.Items.Add("Cayman");
                    üc.Items.Add("Panamera");
                    üc.Items.Add("Taycan");
                }
                else if (iki.SelectedItem.ToString() == "Renault")//renoult
                {
                    üc.Items.Add("Clio");
                    üc.Items.Add("Espace");
                    üc.Items.Add("Fluence");
                    üc.Items.Add("Laguna");
                    üc.Items.Add("Latitude");
                    üc.Items.Add("Megane");
                    üc.Items.Add("Symbol");
                    üc.Items.Add("Taliant");
                    üc.Items.Add("Talisman");
                    üc.Items.Add("Twingo");
                    üc.Items.Add("ZOE");
                    üc.Items.Add("R5");
                    üc.Items.Add("R9");
                    üc.Items.Add("R11");
                    üc.Items.Add("R12");
                    üc.Items.Add("R19");
                    üc.Items.Add("R21");
                    üc.Items.Add("R25");
                }
                else if (iki.SelectedItem.ToString() == "Toyota")//toyota
                {
                    üc.Items.Add("Auris");
                    üc.Items.Add("Avensis");
                    üc.Items.Add("Camry");
                    üc.Items.Add("Carina");
                    üc.Items.Add("Corolla");
                    üc.Items.Add("Corona");
                    üc.Items.Add("Starlet");
                    üc.Items.Add("Supra");
                    üc.Items.Add("Verso");
                    üc.Items.Add("Yaris");
                }
                else if (iki.SelectedItem.ToString() == "Tesla")//tesla
                {
                    üc.Items.Add("Model 3");
                    üc.Items.Add("Model S");
                    üc.Items.Add("Model X");
                    üc.Items.Add("Model Y");
                }
                else if (iki.SelectedItem.ToString() == "Volkswagen")//volkswagen
                {
                    üc.Items.Add("Arteon");
                    üc.Items.Add("Beetle");
                    üc.Items.Add("Bora");
                    üc.Items.Add("Golf");
                    üc.Items.Add("Jetta");
                    üc.Items.Add("Lupo");
                    üc.Items.Add("Passat");
                    üc.Items.Add("Polo");
                    üc.Items.Add("Scirocco");
                    üc.Items.Add("VW CC");
                }
                /* 
Audi
BMW
Citroen
Dacia 
Fiat
Ford
Honda
Hyundai
Mercedes-Benz
Nissan
Opel
Peugeot
Porsche
Renault
Toyota
Tesla
Volkswagen
                 */






            }
            catch {
                ;
            }
            }

        private void pueBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa kayitdonu11111 = new anasayfa();
            kayitdonu11111.ShowDialog();
        }
    }      
}
