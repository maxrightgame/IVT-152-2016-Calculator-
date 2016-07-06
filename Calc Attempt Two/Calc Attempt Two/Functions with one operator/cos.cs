using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
   public class Cos: IOneOperatorsCalculator
    {
       public double Calculate(double firstOperator)
       {
           return Math.Cos(firstOperator);
       }
    }
}
