using System;

namespace Calc_Attempt_Two
{
   public class sin : IOneOperatorsCalculator
    {
       public double Calculate(double firstOperator)
       {
        return Math.Sin(firstOperator);
       }
    }
}
