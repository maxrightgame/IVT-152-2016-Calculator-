using System;

namespace Calc_Attempt_Two.Sorting
{
    public static class SortingFactory
    {
        public static ISortingSorter SortArray(string calculatorName)
        {
            switch (calculatorName)
            {
                case "button2":
                    return new BubbleSort();
                case "button1":
                    return new QuickSort();
                default: 
                    throw new Exception();
            }
        }
    }
}
