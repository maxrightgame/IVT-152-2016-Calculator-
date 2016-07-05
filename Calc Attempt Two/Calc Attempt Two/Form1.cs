using System;
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
            var firstOperator = Convert.ToDouble(textBox1.Text);
            var secondOperator = Convert.ToDouble(textBox2.Text);
            var calc = TwoOperatorsFactory.CreateCalculator(((Button) sender).Name);
            double result = calc.Calculate(firstOperator, secondOperator);
            textBox3.Text = result.ToString();
        }

        private void button_Click_one_operator(object sender, EventArgs e)
        {
            var firstOperator = Convert.ToDouble(textBox1.Text);
            var calc = OneOperatorFactory.CreateCalculator(((Button) sender).Name);
            double result = calc.Calculate(firstOperator);
            textBox3.Text = result.ToString();
        }
    }
}