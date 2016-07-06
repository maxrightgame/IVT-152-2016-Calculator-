using System;

namespace Calc_Attempt_Two
{
    public class tan: IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Tan(firstOperator);
        }
    }
}
