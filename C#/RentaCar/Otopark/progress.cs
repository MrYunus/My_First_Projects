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
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 3;
            label1.Text = progressBar1.Value.ToString()+ "%";
            if (progressBar1.Value >= 99)
            {
                timer1.Enabled = false;
                this.Hide();
                giris frm1donus2 = new giris();
                frm1donus2.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
