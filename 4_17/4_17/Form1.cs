using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_17
{
    public partial class Form1 : Form
    {
        double root = 1;
        double rep = 0;
        double num = 1;
        double divNum = 0;
        double average1 = 0;
        double average2 = 0;
        double avgDiff = 0;
        double stop = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            num = Convert.ToDouble(textBox3.Text);
            root = Convert.ToDouble(textBox1.Text);
            rep = Convert.ToDouble(textBox2.Text);
            stop = (1.0 * (Math.Pow(Math.E, - 6)));
            average2 = (average1 + 100);
            avgDiff = (average2 - average1);

            for (double i = avgDiff; i > stop && rep < 100; i++)
            {
                divNum = (num / root);
                average2 = average1;
                average1 = ((divNum + root) / 2);
                root = average1;
                rep++;
                listBox1.Items.Add(average1);
                textBox3.Text = num.ToString();
                textBox1.Text = root.ToString();
                textBox2.Text = rep.ToString();

                if ( average2 == average1)
                {
                    break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = root.ToString();
            textBox2.Text = rep.ToString();
            textBox3.Text = num.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
