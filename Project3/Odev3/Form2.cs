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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 100)
                timer1.Stop();

            listBox1.Items.Add(i);      
            i++;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 frm3=new Form3();
            frm3.Show();        
        }
    }
}
