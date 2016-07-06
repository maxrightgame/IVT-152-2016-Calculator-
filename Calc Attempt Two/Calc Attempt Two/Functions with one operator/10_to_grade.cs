using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class _10to_grade: IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Pow(10, firstOperator);
        }
    }
}
