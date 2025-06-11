using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            müsteriekleme kayitdonu1 = new müsteriekleme();
            kayitdonu1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            müsterilisteleme kayitdonu1 = new müsterilisteleme();
            kayitdonu1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AracKayit kayitdonu111 = new AracKayit();
            kayitdonu111.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AracListeleme kayitdonu333 = new AracListeleme();
            kayitdonu333.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            sözlesme kayitdonu3333 = new sözlesme();
            kayitdonu3333.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSatış kayitdonu33333 = new frmSatış();
            kayitdonu33333.ShowDialog();
        }
    }
}
