using System;

namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public class XToGrade : ITwoOperatorsCalculator
    {
        /// <summary>
        /// X to power y
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <param name="secondOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator, double secondOperator)
        {
            return Math.Pow(firstOperator, secondOperator);
        }
    }
}
