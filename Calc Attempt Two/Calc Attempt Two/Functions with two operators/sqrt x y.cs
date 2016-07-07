using System;

namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public class SqrtXy: ITwoOperatorsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <param name="secondOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator, double secondOperator)
        {

            if (firstOperator < 0)
            {
                throw new Exception("Negative root");
            }
           return Math.Pow(firstOperator,1/secondOperator);
        }
    }
}
