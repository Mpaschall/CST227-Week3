using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_19
{
    public partial class Form1 : Form
    {
        double n = 0;
        double dec = 0;
        double len = 0;
        int ind = 0;
        double ten = 10;
        double tempTen = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToDouble(textBox1.Text);
            dec = (1 / n);
            textBox2.Text = dec.ToString();
            while (ten % n != 1)
            {
                if (ten % n == 1)
                {
                    tempTen = (ten * 10);
                    ten = tempTen;
                    
                }
                else
                {
                    len = ten;
                    textBox3.Text = len.ToString();
                    break;
                }
            }
            
        }
    }
}
