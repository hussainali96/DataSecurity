using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zigzag_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string str = textBox1.Text.Replace(" ","");
            int x = str.Length;
            int k=0 ,m=0;
            char[] ch1 = new char[x/2];
            char[] ch2 = new char[x/2];

            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    ch1[k] += str[i];
                    k++;
                }
                else
                {
                    ch2[m] += str[i];
                    m++;
                }

            }
            for (int i = 0; i < k; i++)
            {
                textBox2.Text += ch1[i];
            }
            for (int i = 0; i < m; i++)
            {
                textBox2.Text += ch2[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string str = textBox2.Text.Replace(" ", "");
            int x = str.Length;
            int k = 0, m = 0;
            char[] ch1 = new char[x / 2];
            char[] ch2 = new char[x / 2];

            for (int i = 0; i < x; i++)
            {
                if (i <(x/2))
                {
                    ch1[k] += str[i];
                    k++;
                }
                else if ( i >= (x/2))
                {
                    ch2[m] += str[i];
                    m++;
                }

            }
            for (int i = 0; i < x/2; i++)
            {
                textBox1.Text += ch1[i];
                textBox1.Text += ch2[i];
            }
        }
    }
}
