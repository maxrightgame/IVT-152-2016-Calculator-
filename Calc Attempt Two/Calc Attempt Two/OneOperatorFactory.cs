using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Attempt_Two
{
    public static class OneOperatorFactory
    {
        public static IOneOperatorsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "button5":
                    return new Sqrt();
                    break;
                case "button6":
                    return new Squaring();
                    break;
                case "button7":
                    return new Log10();
                    break;
                case "button9":
                    return new Ln();
                    break;
                case "button10":
                    return new Abs();
                    break;
                default:
                    throw new Exception("Unknown operation");

            }
        }
    }
    
}
