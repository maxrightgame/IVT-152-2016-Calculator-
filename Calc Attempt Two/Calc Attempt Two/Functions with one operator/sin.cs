using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
   public class Sin : IOneOperatorsCalculator
    {
       /// <summary>
        /// Sin
       /// </summary>
       /// <param name="firstOperator"></param>
       /// <returns></returns>
       public double Calculate(double firstOperator)
       {
        return Math.Sin(firstOperator);
       }
    }
}
