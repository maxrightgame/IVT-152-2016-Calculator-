using System;
using Calc_Attempt_Two.Sorting;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Sorting
{
    [TestFixture]
    public class SortingFactoryTests
    {
        [TestCase("button2", typeof(BubbleSort))]
        [TestCase("button1", typeof(SelectionSort))]
        public void SortTest(string name, Type type)
        {
            var calculator = SortingFactory.SortArray(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}