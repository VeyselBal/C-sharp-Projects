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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Button btn;
        int count = 0;
        private void hareket(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btn = (Button)sender;
            btn.BackColor = Color.Green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btn.Top < button8.Top)
            {
                button8.Top--;
                btnenable(false);
                timer2.Enabled = false;

            }
            else if (btn.Top > button8.Top)
            {
                button8.Top++;
                btnenable(false);
                timer2.Enabled = false;

            }
            else
            {
                timer2.Enabled = true;
                btn.BackColor = Color.Transparent;
                btnenable(true);
                timer3.Start();
            }
        }
        private void btnenable(bool durum)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = durum;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            hareket(button1, e);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 10)
            {
                button8.Top--;
                btnenable(false);
                timer2.Enabled = false;

                if (btn.Top==button8.Top)
                {
                    timer2.Enabled = true;
                    btn.BackColor = Color.Transparent;
                    btnenable(true);
                    timer3.Start();
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }
    }
}