using System;

namespace Calc_Attempt_Two.Functions_with_one_operator
{
    /// <summary>
    /// This is factory for one operators functions such as Logarithm, Trigonometric, etc.
    /// </summary>
    /// <returns>
    /// Returns completed calculations
    /// </returns>
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
                    return new Sin();
                case "button12":
                    return new Cos();
                case "button13":
                    return new Tan();
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
