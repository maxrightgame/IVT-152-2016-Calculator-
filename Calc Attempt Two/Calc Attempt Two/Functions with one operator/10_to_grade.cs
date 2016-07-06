using System;

namespace Calc_Attempt_Two
{
    public class _10to_grade: IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Pow(10, firstOperator);
        }
    }
}
