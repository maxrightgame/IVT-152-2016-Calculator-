using Calc_Attempt_Two.Sorting;
using NUnit.Framework;

namespace Calc_Attempt_Two.Tests.Sorting
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void BubbleSortTest()
        {
            int[] unsorted = {5, 4, 3, 2, 1};
            int[] sorted = {1, 2, 3, 4, 5};
            ISortingSorter sorter= new BubbleSort();
            sorter.Sort(unsorted);
            Assert.AreEqual(unsorted,sorted);
        }
    }
}