namespace Calc_Attempt_Two.Functions_with_two_operators
{
    public class Addition : ITwoOperatorsCalculator
    {
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="firstOperator"></param>
        /// <param name="secondOperator"></param>
        /// <returns></returns>
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator + secondOperator;
        }
    }
}
