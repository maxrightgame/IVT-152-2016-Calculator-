using System;
using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_one_operator
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

        [Test]
        public void SqrtZero()
        {
            IOneOperatorsCalculator calculator = new Sqrt();
            Assert.Throws<Exception>(() => calculator.Calculate(-12));
        }
    }
}