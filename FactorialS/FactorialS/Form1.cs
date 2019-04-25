using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double a;
        public double b;
        private string c;
        public string s;

        public string C { get => c; set => c = value; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)// = 
        {
            try
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

                switch (C)
                {
                    case "^":
                        textBox1.Text = Convert.ToString(Math.Pow(a, b));
                        break;

                    case "%":
                        textBox1.Text = Convert.ToString(((a / b) * 100) + "%");
                        break;


                }
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
        }
        }

        private void button3_Click(object sender, EventArgs e)//x^Y
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                C = "^";
                textBox1.Text = "";
            }       
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }

        }

        private void button15_Click(object sender, EventArgs e)// Sqrt
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(a));
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double s = 1;
                a = Convert.ToDouble(textBox1.Text);
                for(int i =1;i <= a; i++)
                {
                    s = s * i;
                }
                textBox1.Text = Convert.ToString(s);

            }
            catch (Exception)
            {
                MessageBox.Show(" Ошибка Ввода");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(a, 2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(a, 3));

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(1 / a);
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(1 / a);
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }
    }
    }

