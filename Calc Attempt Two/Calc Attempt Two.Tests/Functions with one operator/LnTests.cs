using System;
using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_one_operator
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(25, 3.2188)]
        [TestCase(100, 4.6051)]
        [TestCase(1, 0)]
        public void LnTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [Test]
        public void SqrtZero()
        {
            IOneOperatorsCalculator calculator = new Ln();
            Assert.Throws<Exception>(() => calculator.Calculate(-12));
        }
    }
}