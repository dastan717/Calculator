using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int x = 0;
        public int n =0;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";

            }
            else if (textBox1.Text == "1")
            {
                textBox1.Text = "1";
            }
            else if (textBox1.Text == "2")
            {
                textBox1.Text = "2";
            }
            else if (textBox1.Text == "3")
            {
                textBox1.Text = "3";
            }
            else if (textBox1.Text == "4")
            {
                textBox1.Text = "5";
            }
            else if (textBox1.Text == "5")
            {
                textBox1.Text = "8";
            }
            else if (textBox1.Text == "6")
            {
                textBox1.Text = "13";

            }
            else if (textBox1.Text == "7")
            {
                textBox1.Text = "21";
            }
            else if (textBox1.Text == "8")
            {
                textBox1.Text = "34";
            }
            else if (textBox1.Text == "9")
            {
                textBox1.Text = "55";
            }
        }
    }
}
