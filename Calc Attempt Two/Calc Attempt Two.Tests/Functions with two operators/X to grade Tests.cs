using Calc_Attempt_Two.Functions_with_two_operators;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class XToGradeTests
    {
        [TestCase(2, 10, 1024)]
        [TestCase(2, 0, 1)]
        [TestCase(50, 3, 125000)]
        [TestCase(20, -1, 0.05)]
        public void XToGradeTest(double first, double second, double expected)
        {
            ITwoOperatorsCalculator calculator = new XToGrade();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}