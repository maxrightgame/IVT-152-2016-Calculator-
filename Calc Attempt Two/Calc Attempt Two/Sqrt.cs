using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calc_Attempt_Two
{
    public class Sqrt : ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return Math.Sqrt(firstOperator);
        }
    }
}
