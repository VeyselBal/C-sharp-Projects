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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if(count < 6)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible=false;
                pictureBox3.Visible=false;
            }
            else
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible=false;
                pictureBox1.Visible = false;
            }
            count++;
            if (count == 9)
                count = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            Form5 frm5 = new Form5();
            frm5.Show();
        }
    }
}
