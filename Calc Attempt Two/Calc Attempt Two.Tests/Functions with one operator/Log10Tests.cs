using System;
using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_one_operator
{
    [TestFixture]
    public class Log10Tests
    {
        [TestCase(10,1)]
        [TestCase(100, 2)]
        [TestCase(1, 0)]
        public void Log10Test(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new Log10();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
            [Test]
        public void SqrtZero()
        {
            IOneOperatorsCalculator calculator = new Log10();
            Assert.Throws<Exception>(() => calculator.Calculate(-12));
        }
    }
}