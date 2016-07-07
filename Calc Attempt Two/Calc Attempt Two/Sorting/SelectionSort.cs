namespace Calc_Attempt_Two.Sorting
{
    public class SelectionSort : ISortingSorter
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            return arr;
        }
    }
}
