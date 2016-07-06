using System;

namespace Calc_Attempt_Two
{
   public class cos: IOneOperatorsCalculator
    {
       public double Calculate(double firstOperator)
       {
           return Math.Cos(firstOperator);
       }
    }
}
