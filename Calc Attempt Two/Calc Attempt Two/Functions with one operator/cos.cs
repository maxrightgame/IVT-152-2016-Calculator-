using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
