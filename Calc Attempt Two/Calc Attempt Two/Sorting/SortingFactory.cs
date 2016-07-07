using System;

namespace Calc_Attempt_Two.Sorting
{
    public static class SortingFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public static ISortingSorter SortArray(string calculatorName)
        {
            switch (calculatorName)
            {
                case "button2":
                    return new BubbleSort();
                case "button1":
                    return new SelectionSort();
                default: 
                    throw new Exception();
            }
        }
    }
}
