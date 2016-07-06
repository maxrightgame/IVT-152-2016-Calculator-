using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_one_operator
{
    [TestFixture]
    public class SquaringTests
    {
        [TestCase(4, 16)]
        [TestCase(2, 4)]
        [TestCase(10, 100)]
        [TestCase(0, 0)]
        public void SquaringTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new Squaring();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}