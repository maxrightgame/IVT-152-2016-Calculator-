using System;

namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public class XToGrade : ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return Math.Pow(firstOperator, secondOperator);
        }
    }
}
