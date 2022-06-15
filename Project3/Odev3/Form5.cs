using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSalise.Text = salise.ToString();
            if (salise == 100)
            {
                salise = 0;
                saniye++;
                lblSaniye.Text = saniye.ToString();
            }

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
                lblDakika.Text = dakika.ToString();
            }

            if (dakika==60)
            {
                dakika = 0;
                saat++;
                lblSaat.Text = saat.ToString();
            }
            salise++;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }
    }
}
