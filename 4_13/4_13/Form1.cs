using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            double radius = 0;
            double pi = 0;

            radius = Convert.ToDouble(textBox1.Text);
            pi = Math.PI;

            textBox2.Text = ((radius * radius) * pi).ToString();

        }
    }
}
