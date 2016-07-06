using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Functions_with_two_operators
{
    [TestFixture]
    public class tanTests
    {
        [TestCase(1, 1.5574)]
        [TestCase(2, -2.1850)]
        [TestCase(0, 0)]
        public void tanTest(double first, double expected)
        {
            IOneOperatorsCalculator calculator = new tan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}