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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Random rnd=new Random();

        int pic1 = 0;
        int pic2 = 0;
        int pic3 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int finish = button1.Left;

            pic1 = rnd.Next(5,30);
            pic2 = rnd.Next(5,30);
            pic3 = rnd.Next(5,30);

            pictureBox1.Left+= pic1;
            pictureBox2.Left+= pic2;
            pictureBox3.Left+= pic3;

            if (pictureBox1.Width + pictureBox1.Left > button1.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yarışı 1. araba kazanıştır");
            }
            else if(pictureBox2.Width + pictureBox2.Left > button1.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yarışı 2. araba kazanıştır");
            }
            else if (pictureBox3.Width + pictureBox3.Left > button1.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yarışı 3. araba kazanıştır");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
