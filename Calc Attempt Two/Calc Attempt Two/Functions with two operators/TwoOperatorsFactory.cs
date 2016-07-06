using System;

namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public static class TwoOperatorsFactory
    {
        public static ITwoOperatorsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "button1":
                    return new Addition();
                case "button2":
                    return new Subtraction();
                case "button3":
                    return new Multiplication();
                case "button4":
                    return new Division();
                case "button8":
                    return new XToGrade();
                case "button14":
                    return new sqrt_x_y();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
