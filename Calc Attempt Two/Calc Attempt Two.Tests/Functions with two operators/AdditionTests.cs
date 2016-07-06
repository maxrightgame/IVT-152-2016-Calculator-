using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(670 ,200 ,870)]
        [TestCase(2, 0, 2)]
        [TestCase(67.3, 32.7, 100)]
        [TestCase(0.5, -2, -1.5)]
        public void AdditionTest(double first, double second, double expected)
        {
            ITwoOperatorsCalculator calculator=new Addition();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected,result);
        }
    }
}