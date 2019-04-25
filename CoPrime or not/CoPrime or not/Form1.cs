using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoPrime_or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a;
        public int b;
        public char c;
       

        
        private void button1_Click(object sender, EventArgs e)//
        {
            Button btn = sender as Button;
            textBox1.Text +=btn.Text ;
        }

        

        private void button10_Click(object sender, EventArgs e)// AND
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
           
            
        }

        private void button11_Click(object sender, EventArgs e)// = 
        {

         b = Convert.ToInt32(textBox1.Text);
         textBox1.Text = "";
        
         int[] div = new int[100];
         int k = 0;
                        
         for (  int i = 2; i <= a; i++)
                        {

                if (a % i == 0)
                {
                    div[k] = i;
                    k++;
                }
                        }

         bool IsFound = false;
         for (int i = 0; i < k; i++)
         {

                if (b % div[i] == 0)
                {
                    textBox1.Text = Convert.ToString(div[i]);
                    IsFound = true;
                    break;
                }
                
         }
                if (!IsFound)
                textBox1.Text = "1";
           

                        
                
            
            
        }
    }
}
