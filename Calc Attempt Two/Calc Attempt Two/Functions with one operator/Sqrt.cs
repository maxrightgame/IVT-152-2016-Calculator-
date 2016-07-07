using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Sqrt : IOneOperatorsCalculator
    {
        /// <summary>
        /// Squaring
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator)
        {
            if (firstOperator < 0)
            {
                throw new Exception("Negative root");
            }
            return Math.Sqrt(firstOperator);
        }
    }
}
