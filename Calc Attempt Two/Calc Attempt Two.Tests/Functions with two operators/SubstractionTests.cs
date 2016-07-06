using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class SubstractionTests
    {
        [TestCase(670, 200, 470)]
        [TestCase(-2, -2, 0)]
        [TestCase(37, -2, 39)]
        [TestCase(-420720, 35002.2, -455722.2)]
        public void SubstractionTest(double first, double second, double expected)
        {
            ITwoOperatorsCalculator calculator = new Subtraction();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}