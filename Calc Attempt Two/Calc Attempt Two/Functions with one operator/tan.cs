using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Tan: IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Tan(firstOperator);
        }
    }
}
