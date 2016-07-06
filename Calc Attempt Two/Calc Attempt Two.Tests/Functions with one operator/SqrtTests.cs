using Calc_Attempt_Two.Functions_with_one_operator;
using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class sqrtTests
    {
        [TestCase(4, 2)]
        [TestCase(169, 13)]
        [TestCase(1, 1)]
        [TestCase(5625, 75)]
        public void SqrtTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}