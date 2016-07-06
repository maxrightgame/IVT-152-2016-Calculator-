using System;
using Calc_Attempt_Two.Functions_with_one_operator;

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
                case "button6":
                    return new Squaring();
                case "button7":
                    return new Log10();
                case "button9":
                    return new Ln();
                case "button10":
                    return new Abs();
                case "button11":
                    return new sin();
                case "button12":
                    return new cos();
                case "button13":
                    return new tan();
                case "button15":
                    return new _10to_grade();
                case "button16":
                    return new exp();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
    
}
