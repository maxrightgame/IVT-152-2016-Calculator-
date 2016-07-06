using Calc_Attempt_Two.Functions_with_one_operator;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_one_operator
{
    [TestFixture]
    public class _10to_gradeTests
    {
        [TestCase(4, 10000)]
        [TestCase(2, 100)]
        [TestCase(12, 1000000000000)]
        [TestCase(0, 1)]
        public void _10to_gradeTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new _10to_grade();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}