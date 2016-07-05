namespace Calc_Attempt_Two.Functions_with_one_operator
{
    public class Squaring : IOneOperatorsCalculator
    {
        public double Calculate(double firstOperator)
        {
            return firstOperator*firstOperator;
        }
    }
}
