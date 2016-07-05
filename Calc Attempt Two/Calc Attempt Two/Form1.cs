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

       private void button_Click(object sender, EventArgs e)
        {
            double result = 0;
            double firstOperator = Convert.ToDouble(textBox1.Text);
            double secondOperator = Convert.ToDouble(textBox2.Text);
            switch (((Button)sender).Name)
            {
                case "button1":
                    result = firstOperator + secondOperator;
                    break;
                case "button2":
                    result = firstOperator - secondOperator;
                    break;
                case "button3":
                    result = firstOperator*secondOperator;
                    break;
                case "button4":
                    result = firstOperator/secondOperator;
                    break;
                case "button5":
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    break;
               default:
                    throw new Exception("Unknown operation");

            }
            textBox3.Text = result.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
       {
           double firstOperator = Convert.ToDouble(textBox1.Text);
           double secondOperator = Convert.ToDouble(textBox2.Text);
           double result = firstOperator * secondOperator;
           textBox3.Text = result.ToString();
       }
        private void button1_Click(object sender, EventArgs e)
        {
            double firstOperator = Convert.ToDouble(textBox1.Text);
            double secondOperator = Convert.ToDouble(textBox2.Text);
            double result = firstOperator + secondOperator;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstOperator = Convert.ToDouble(textBox1.Text);
            double secondOperator = Convert.ToDouble(textBox2.Text);
            double result = firstOperator - secondOperator;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (Convert.ToInt32(textBox2.Text) != 0)
            {
                double firstOperator = Convert.ToDouble(textBox1.Text);
                double secondOperator = Convert.ToDouble(textBox2.Text);
                double result = firstOperator / secondOperator;
                textBox3.Text = result.ToString();
            }
            else textBox3.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
