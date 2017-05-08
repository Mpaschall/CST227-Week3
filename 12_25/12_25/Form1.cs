using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_25
{
    public partial class Form1 : Form
    {
        string word, post, combined;
        int len = 1;
        int count = 0;

        Stack<string> stack = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            post = textBox2.Text;

            while (count < 1)
            {                
                for (int i = post.Length - 1; i >= 0; i--)
                {
                    word = textBox1.Text;
                    stack.Push(post.Substring(i, len));
                }
                count++;
            }
            if (count == 1)
            {
                word = combined;
            }

            if (stack.Count != 0)
            {

                combined = (word + "" + stack.Pop());
                textBox3.Text = combined;
            }
            
        }
    }
}
