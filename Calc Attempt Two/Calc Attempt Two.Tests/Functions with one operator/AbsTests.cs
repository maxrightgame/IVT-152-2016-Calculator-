using Calc_Attempt_Two.Functions_with_one_operator;
using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class AbsTests
    {
        [TestCase(-100, 100)]
        [TestCase(-12, 12)]
        [TestCase(0, 0)]
        [TestCase(5625, 5625)]
        public void AbsTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new Abs();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}