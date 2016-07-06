using System;
using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class OneOperatorFactoryTests
    {
        [TestCase("button15", typeof(_10to_grade))]
        [TestCase("button10", typeof(Abs))]
        [TestCase("button12", typeof(cos))]
        [TestCase("button9", typeof(Ln))]
        [TestCase("button11", typeof(sin))]
        [TestCase("button5", typeof(Sqrt))]
        [TestCase("button7", typeof(Log10))]
        [TestCase("button6", typeof(Squaring))]
        [TestCase("button13", typeof(tan))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneOperatorFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}