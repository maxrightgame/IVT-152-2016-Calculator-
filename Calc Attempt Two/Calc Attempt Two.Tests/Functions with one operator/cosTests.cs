﻿using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_one_operator
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(1, 0.5403)]
        [TestCase(2, -0.4161)]
        [TestCase(0, 1)]
        public void CosTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new Cos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}