using System;
using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class TwoOperatorsFactoryTests
    {
        [TestCase("button1", typeof(Addition))]
        [TestCase("button2", typeof(Subtraction))]
        [TestCase("button3", typeof(Multiplication))]
        [TestCase("button4", typeof(Division))]
        [TestCase("button8", typeof(XToGrade))]
        [TestCase("button14", typeof(SqrtXy))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoOperatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}