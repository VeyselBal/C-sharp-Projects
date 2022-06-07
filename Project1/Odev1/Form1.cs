using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "txt Files|*.txt";

            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFile1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            int count = 0;
            int start=0;
            string word=textBox1.Text.Trim();
            string[] arr = richTextBox1.Text.Trim().Split(' ', '.', ',', ':', ';', '!', '?','\n');

            for (int i = 0; i < arr.Length; i++)
            {
                if (word.Equals(arr[i]))
                {
                    count++;
                    richTextBox1.Select(start, word.Length);
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
                start += arr[i].Length + 1;
            }
            label1.Text = count.ToString()+" tane bulundu";
        }
    }
}
