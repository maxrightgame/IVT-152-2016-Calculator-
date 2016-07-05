using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Log10 : IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Log10(firstOperator);
        }
    }
}
