using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Fibonacci
{
    public partial class Form1 : Form
    {
      public Form1()
        {
            InitializeComponent();
        }
       public  double a;
       public  double b;
       public  string c;
        public bool znak = true;
        
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)//ln(x)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Log(a));
            }
            catch(Exception)
            {
                MessageBox.Show("ошибка ввода");
            }
        }

        private void button6_Click(object sender, EventArgs e)// ==
        {
            try {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = " ";

                switch (c)
                {
                    case "+":

                        textBox2.Text = Convert.ToString(a + "+" + b + "=");
                        textBox1.Text = Convert.ToString(a + b);
                        break;
                    case "logA(x)":
                        textBox1.Text = Convert.ToString(Math.Log10(a) / Math.Log10(b));
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");

            }
        }

        private void button4_Click(object sender, EventArgs e)//log(x)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Log10(a));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            {
                if (znak == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    znak = false;
                }
                else if (znak == false)
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    znak = true;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)//LogA(x)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "logA(x)";
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)// ( )
        {
            {
                if (znak == true)
                {
                    textBox1.Text = "(" + textBox1.Text;
                    znak = false;

                }
                else if (znak == false)
                {
                    textBox1.Text = ")" + textBox1.Text;
                    znak = true;

                }
            }      
        }

        private void button19_Click(object sender, EventArgs e)// +
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");

                a = Convert.ToDouble(textBox1.Text);
                c = "+";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
