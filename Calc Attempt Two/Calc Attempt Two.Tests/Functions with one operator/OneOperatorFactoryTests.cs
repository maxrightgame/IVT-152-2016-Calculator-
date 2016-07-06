using System;
using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_one_operator
{
    [TestFixture]
    public class OneOperatorFactoryTests
    {
        [TestCase("button15", typeof(_10to_grade))]
        [TestCase("button10", typeof(Abs))]
        [TestCase("button12", typeof(Cos))]
        [TestCase("button9", typeof(Ln))]
        [TestCase("button11", typeof(Sin))]
        [TestCase("button5", typeof(Sqrt))]
        [TestCase("button7", typeof(Log10))]
        [TestCase("button6", typeof(Squaring))]
        [TestCase("button13", typeof(Tan))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneOperatorFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}