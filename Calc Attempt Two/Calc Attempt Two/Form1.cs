using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Attempt_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(textBox1.Text)*Convert.ToDouble(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (Convert.ToInt32(textBox2.Text) != 0)
            {
                double result = Convert.ToDouble(textBox1.Text)/Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            else textBox3.Text = "0";
        }
    }
}
