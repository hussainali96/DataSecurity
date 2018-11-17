using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vertical_Rotates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool check = false;
            if (listBox1.Text != " ")
            {
                listBox1.Items.Clear();
                check = true;
            }
            string txtbox = textBox1.Text.Replace(" ", "");
            string str = "";
            int x = txtbox.Length;
            if (check == true)
            {
                if (x % 2 == 0)
                {
                    for (int i = 2; i < x; i++)
                    {
                        if (x % i == 0)
                        {
                            for (int j = 2; j < x; j++)
                            {
                                if (x % i == 0)
                                {
                                    if (i * j == x)
                                    {
                                        str += i.ToString() + "x" + j.ToString();
                                        listBox1.Items.Add(str);
                                        str = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            String list = listBox1.SelectedItem.ToString();
            int x = list.Length;
            int k = 0;
            for (int i = 0; i < x; i++)
            {
                if (list[i] == 'x')
                {
                    k = i;
                }
            }
            for (int i = 0; i < x; i++)
            {
                if (i < k) textBox3.Text += list[i].ToString();
                else if (i > k) textBox4.Text += list[i].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox5.Text = "";
            int row = int.Parse(textBox3.Text);
            int column = int.Parse(textBox4.Text);
            int m = 0;
            char[,] ch = new char[row, column];

            string str = textBox2.Text.Replace(" ", "");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    ch[i, j] += str[m];
                    m++;
                    textBox5.Text += ch[i, j];
                }
                textBox5.Text += Environment.NewLine;
            }
            for (int j = 0; j < column; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    textBox1.Text += ch[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox5.Text = "";
            int row = int.Parse(textBox3.Text);
            int column = int.Parse(textBox4.Text);
            int m = 0;
            char[,] ch = new char[row, column];

            string str = textBox1.Text.Replace(" ", "");

            for (int j = 0; j < column; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    ch[i, j] += str[m];
                    m++;
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    textBox5.Text += ch[i, j];
                    textBox2.Text += ch[i, j];
                }
                textBox5.Text += Environment.NewLine;
            }
        }
    }
}
