using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(500, 25, 20)]
        [TestCase(400, 0.5, 800)]
        [TestCase(0.5, 0.5, 1)]
        [TestCase(3, 8, 0.375)]
        public void DivisionTest(double first, double second, double expected)
        {
            ITwoOperatorsCalculator calculator = new Division();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}