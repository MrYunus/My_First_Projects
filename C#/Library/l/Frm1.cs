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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersonelGiris frmPersonelGiris = new FrmPersonelGiris();
            frmPersonelGiris.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblKayıt_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmKayıtOgrenci frmOgrenciKayit = new FrmKayıtOgrenci();
            frmOgrenciKayit.Show();
        }

        private void LblSifre_Click(object sender, EventArgs e)
        {

        }

        private void BtnOgrenci_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOgrenciGiris frmOgrenciGiris = new FrmOgrenciGiris();
            frmOgrenciGiris.Show();
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayıtPersonel frmKayıtPersonel = new FrmKayıtPersonel();
            frmKayıtPersonel.Show();

        }
    }
}
