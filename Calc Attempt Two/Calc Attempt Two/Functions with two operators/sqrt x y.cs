using System;
using Calc_Attempt_Two.Functions_with_two_operators;

namespace Calc_Attempt_Two
{
    public class sqrt_x_y: ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {

            if (firstOperator < 0)
            {
                throw new Exception("Negative root");
            }
           return Math.Pow(firstOperator,1/secondOperator);
        }
    }
}
