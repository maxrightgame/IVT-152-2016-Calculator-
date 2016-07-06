using System;

namespace Calc_Attempt_Two
{
    public class exp : IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Exp(firstOperator);
        }
    }
}
