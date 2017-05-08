using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_18
{
    public partial class Form1 : Form
    {
        int remain;
        int num1;
        int num2;
        public Form1()
        {
            InitializeComponent();
        }

        public int getRemainder(int num1, int num2)
        {
            if (num1 > num2)
            {
                remain = num1 % num2;
            }
            else if (num2 > num1)
            {
                remain = num2 % num1;
            }
            return remain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            int remainder = getRemainder(num1, num2);
            int aRem = 0;
            while (remainder != 0)
            {
                num1 = num2;
                num2 = remainder;
                remainder = getRemainder(num1, num2);
                textBox1.Text = (num1.ToString());
                textBox2.Text = (num2.ToString());
            }
            if (remainder == 0)
            {
                textBox3.Text = num2.ToString();
            }
        }
    }
}
