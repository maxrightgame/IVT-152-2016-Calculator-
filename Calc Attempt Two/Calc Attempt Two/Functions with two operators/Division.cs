using System;

namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public class Division : ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            if (secondOperator == 0)
            {
                throw new Exception("Division by zero");
            }
            return firstOperator/secondOperator;
        }
    }
}
