using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Attempt_Two
{
    public class Addition : ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator + secondOperator;
        }
    }
}
