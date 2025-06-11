using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l
{
    public partial class arayuz : Form
    {
        public arayuz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void arayuz_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pUyeEkleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            püyeekleme ekle = new püyeekleme();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            uye listeleme1 = new uye();
            listeleme1.ShowDialog();
        }

        private void paDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 donus1 = new Frm1();
            donus1.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void paKitapEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            pkitaplekleme1 eklegiris1 = new pkitaplekleme1();
            eklegiris1.ShowDialog();
        }

        private void paKitapListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            pkitaplisteleme duzenlegiris1 = new pkitaplisteleme();
            duzenlegiris1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            pemanetiade pemanetiadeee = new pemanetiade();
            pemanetiadeee.ShowDialog();
        }

        private void paKitapIade_Click(object sender, EventArgs e)
        {
            this.Hide();
            pemanetekleme donus1111 = new pemanetekleme();
            donus1111.ShowDialog();
        }

        private void paEmanetEtme_Click(object sender, EventArgs e)
        {
            this.Hide();
            peemanetlisteleme donus22222 = new peemanetlisteleme();
            donus22222.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sıralamafrm donus2222222 = new Sıralamafrm();
            donus2222222.ShowDialog();
        }
    }
}
