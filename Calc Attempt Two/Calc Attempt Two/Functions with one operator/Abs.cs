using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Abs : IOneOperatorsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator)
        {
            return Math.Abs(firstOperator);
        }
    }
}
