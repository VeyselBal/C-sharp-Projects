using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // Paint += button8_Click;
        }
        Random rnd = new Random();

        private void kutulariTemizle()
        {
            bool durum = false;
            button1.Visible = button2.Visible = button3.Visible = button4.Visible = button5.Visible =
            button6.Visible = button7.Visible = button8.Visible = button9.Visible = button10.Visible =
            button11.Visible = button12.Visible = button13.Visible = durum;
        }
        private void yazıyaCevir()
        {
            int sayi= Convert.ToInt32(lblSonuc.Text);
            string[] birler = { "", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] yuzler = { "", "YÜZ", "İKİYÜZ", "ÜÇYÜZ", "DÖRTYÜZ", "BEŞYÜZ", "ALTIYÜZ", "YEDİYÜZ", "SEKİZYÜZ", "DOKUZYÜZ" };

            if (sayi == 0)
            {
                lblSonuc.Text = "SIFIR";
            }
            else
            {
                lblSonuc.Text = yuzler[sayi / 100] + onlar[(sayi % 100) / 10] + birler[sayi % 10];
            }
        }
        private void topla()
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            lblSonuc.Text = (x + y).ToString();
        }
        private void carp()
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            lblSonuc.Text = (x * y).ToString();
        }

        private void usAl()
        {
            int taban=Convert.ToInt32(textBox1.Text);
            int us=Convert.ToInt32(textBox2.Text);

            int total = 1;
            for (int i = 0; i < us; i++)
            {
                total *= taban;
            }
            lblSonuc.Text = total.ToString();
        }

        private void faktoriyel()
        {
            int n1=Convert.ToInt32(textBox1.Text);
            int n2=Convert.ToInt32(textBox2.Text);
            if (n1 > n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }
            int faktoriyell=n2- n1;
            for (int i = 1; i < n2-n1; i++)
            {
                faktoriyell *= i;
            }
            MessageBox.Show("2 sayının arasındaki farkın faktoriyeli: "+faktoriyell.ToString());
        }

        private void rastgeleSayi()
        {
            Random rnd=new Random();
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text =rnd.Next(1,10).ToString();
            textBox2.Text =rnd.Next(1,10).ToString();
        }
        
        private void cizgiCiz(int s1,int s2,int s3,int s4)
        {
            Graphics graphics=CreateGraphics();
            Pen pen=new Pen(Color.Blue,7);
            graphics.DrawLine(pen,s1,s2,s3,s4);
        }
        
        private void topla(int[] sayilar)
        {
            int total = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                total+= sayilar[i];
            }
            lblSonuc.Text=total.ToString();
        }

        private void formuRenklendir()
        {
            
            this.BackColor = Color.FromArgb(rnd.Next(1,255), rnd.Next(1, 255), rnd.Next(1, 255));        
        }

        private void formuRenklendir(Color renk)
        {
             this.BackColor = renk;
        }

        private void us_al2(double taban,double us)
        {
            double total =1;
            for(int i = 0; i < us; i++)
            {
                total *= taban;
            }
            lblSonuc.Text=total.ToString();
        }

        private int intusAl(int taban,int us)
        {
            int total = 1;
            for (int i = 0; i < us; i++)
            {
                total *= taban;
            }
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kutulariTemizle();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            yazıyaCevir();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            topla();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            carp();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            usAl();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            faktoriyel();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            rastgeleSayi();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int s1 = rnd.Next(0, 500);
            int s2 = rnd.Next(0, 500);
            int s3 = rnd.Next(0, 500);
            int s4 = rnd.Next(0, 500);
            cizgiCiz(s1, s2, s3, s4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(textBox1.Text);
            int n2=Convert.ToInt32(textBox2.Text);
            if (n1 > n2)
            {
                int temp = n1;
                n1=n2;
                n2=temp;
            }
            int[] numbers=new int[n2-n1];

            int index = 0;
            for (int i = n1; i < n2; i++)
            {
                numbers[index] = i;
                index++;
            }
            topla(numbers);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            formuRenklendir();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult=renkSecim.ShowDialog();
            Color renk = renkSecim.Color;
            formuRenklendir(renk);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            us_al2(Convert.ToDouble(textBox1.Text), 
                Convert.ToDouble(textBox2.Text));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(textBox1.Text);
            int n2=Convert.ToInt32(textBox2.Text);
            lblSonuc.Text = intusAl(n1, n2).ToString();
        } 
    }
}
