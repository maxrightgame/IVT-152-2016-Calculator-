using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 0, 0)]
        [TestCase(35, 0.5, 17.5)]
        [TestCase(2.2, 4, 8.8)]
        public void MultiplicationTest(double first, double second, double expected)
        {
            ITwoOperatorsCalculator calculator = new Multiplication();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}