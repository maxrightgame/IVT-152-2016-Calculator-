using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Tan: IOneOperatorsCalculator
    {
        /// <summary>
        /// Tan
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator)
        {
            return Math.Tan(firstOperator);
        }
    }
}
