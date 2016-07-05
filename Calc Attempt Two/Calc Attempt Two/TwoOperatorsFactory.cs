using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Attempt_Two
{
    public static class TwoOperatorsFactory
    {
        public static ITwoOperatorsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "button1":
                    return new Addition();
                    break;
                case "button2":
                    return new Subtraction();
                    break;
                case "button3":
                    return new Multiplication();
                    break;
                case "button4":
                    return new Division();
                    break;
                default:
                    throw new Exception("Unknown operation");

            }
        }
    }
}
