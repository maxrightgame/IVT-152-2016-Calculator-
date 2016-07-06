using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Attempt_Two
{
    public class _10to_grage: IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return Math.Pow(10, firstOperator);
        }
    }
}
