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
            ITwoOperatorsCalculator calc = TwoOperatorsFactory.CreateCalculator(((Button)sender).Name);
            result = calc.Calculate(firstOperator, secondOperator);
            textBox3.Text = result.ToString();
        }
       private void button_Click_one_operator(object sender, EventArgs e)
       {
           double result = 0;
           double firstOperator = Convert.ToDouble(textBox1.Text);
           double secondOperator = 0;
           ITwoOperatorsCalculator calc = TwoOperatorsFactory.CreateCalculator(((Button)sender).Name);
           result = calc.Calculate(firstOperator, secondOperator);
           textBox3.Text = result.ToString();
       }
   }
}
