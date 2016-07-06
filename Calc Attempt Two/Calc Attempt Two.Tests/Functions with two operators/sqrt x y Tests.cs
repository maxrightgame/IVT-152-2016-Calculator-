using System;
using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class SqrtxyTests
    {
        [TestCase(4,2,2)]
        [TestCase(27,3,3)]
        [TestCase(1,1,1)]
        [TestCase(1024,10,2)]
        public void SqrtxyTest(double first, double second, double expected)
        {
            ITwoOperatorsCalculator calculator = new SqrtXy();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SqrtZero()
        {
            ITwoOperatorsCalculator calculator = new SqrtXy();
            Assert.Throws<Exception>(() => calculator.Calculate(-4,2));
        }
    }
}