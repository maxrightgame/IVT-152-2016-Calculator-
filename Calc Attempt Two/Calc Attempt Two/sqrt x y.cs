using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc_Attempt_Two.Functions_with_two_operators;

namespace Calc_Attempt_Two
{
    public class sqrt_x_y: ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
           return Math.Pow(firstOperator,1/secondOperator);
        }
    }
}
