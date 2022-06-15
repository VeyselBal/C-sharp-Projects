using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text) && 
                !string.IsNullOrEmpty(comboBox3.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                int number=Convert.ToInt32(textBox1.Text);
                if (number <45 || number > 50)
                {
                    MessageBox.Show("koltuk Sayısı Geçerli Değil!!! ");
                }
                else
                {
                    Otobus otobus = new Otobus(comboBox1.Text, comboBox2.Text, comboBox3.Text, number);

                    listBox1.Items.Add("------------------------------------------------------");
                    listBox1.Items.Add("Sefer adı:          "+ otobus.SeferAdi);
                    listBox1.Items.Add("Sefer saati:       " + otobus.SeferSaati);
                    listBox1.Items.Add("Model:              " + otobus.Model);
                    listBox1.Items.Add("Koltuk sayısı:     " + otobus.KoltukSayisi);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input", "Invailid Input");
            }
        }
    }
}
