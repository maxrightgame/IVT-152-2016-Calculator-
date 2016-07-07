using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Squaring : IOneOperatorsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator)
        {
            return Math.Pow(firstOperator,2);
        }
    }
}
