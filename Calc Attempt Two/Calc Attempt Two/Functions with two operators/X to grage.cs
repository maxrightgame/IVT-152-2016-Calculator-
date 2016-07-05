using System;

namespace Calc_Attempt_Two.Functions_with_two_operators
{
    class XToGrage : ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return Math.Pow(firstOperator, secondOperator);
        }
    }
}
