using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
   public class Sin : IOneOperatorsCalculator
    {
       public double Calculate(double firstOperator)
       {
        return Math.Sin(firstOperator);
       }
    }
}
