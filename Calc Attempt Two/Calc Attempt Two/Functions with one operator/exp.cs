using System;
using Calc_Attempt_Two.Functions_with_one_operator;

namespace Calc_Attempt_Two
{
    public class exp : IOneOperatorsCalculator
    {
        /// <summary>
        /// exp
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator)
        {
            return Math.Exp(firstOperator);
        }
    }
}
