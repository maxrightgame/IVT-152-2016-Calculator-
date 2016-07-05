﻿namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public class Multiplication : ITwoOperatorsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator*secondOperator;
        }
    }
}
