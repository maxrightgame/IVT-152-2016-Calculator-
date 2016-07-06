﻿using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class sinTests
    {
        [TestCase(1, 0.8414)]
        [TestCase(2, 0.9092)]
        [TestCase(0, 0)]
        public void CosTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new sin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}