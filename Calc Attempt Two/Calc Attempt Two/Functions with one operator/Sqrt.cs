using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Sqrt : IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Sqrt(firstOperator);
        }
    }
}
