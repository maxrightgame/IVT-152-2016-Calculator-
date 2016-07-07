using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Log10 : IOneOperatorsCalculator
    {
        /// <summary>
        /// Log10
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator)
        {
            if (firstOperator <= 0)
            {
                throw new Exception("Negative logarithm or 0");
            }
            return Math.Log10(firstOperator);
        }
    }
}
