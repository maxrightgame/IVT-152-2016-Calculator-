using System;

namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public class Division : ITwoOperatorsCalculator
    {
        /// <summary>
        /// Division
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <param name="secondOperator"></param>
        /// <returns></returns>
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
