using Calc_Attempt_Two.Functions_with_one_operator;
using Calc_Attempt_Two.Sorting;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Sorting
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void SelectionSortTest()
        {
            int[] unsorted = { 5, 4, 3, 2, 1 };
            int[] sorted = { 1, 2, 3, 4, 5 };
            ISortingSorter sorter = new SelectionSort();
            sorter.Sort(unsorted);
            Assert.AreEqual(unsorted, sorted);
        }
    }
}