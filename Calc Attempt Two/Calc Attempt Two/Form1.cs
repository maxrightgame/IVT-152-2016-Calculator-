using System;
using System.Windows.Forms;
using Calc_Attempt_Two.Functions_with_one_operator;
using Calc_Attempt_Two.Functions_with_two_operators;

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
            
            try
            {
                var firstOperator = Convert.ToDouble(textBox1.Text); 
                var secondOperator = Convert.ToDouble(textBox2.Text);
                var calc = TwoOperatorsFactory.CreateCalculator(((Button)sender).Name);
                double result = calc.Calculate(firstOperator, secondOperator);
                textBox3.Text = result.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
            
        }

        private void button_Click_one_operator(object sender, EventArgs e)
        {
            try
            {
                var firstOperator = Convert.ToDouble(textBox1.Text);
                var calc = OneOperatorFactory.CreateCalculator(((Button)sender).Name);
                double result = calc.Calculate(firstOperator);
                textBox3.Text = result.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.Show();
        }
    }
}