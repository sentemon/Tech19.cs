using System;

namespace Algorytmy 
{
    internal class Sortowanie
    {   
        public static void BubbleSort(ref int[] array)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        // (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void Main()
        {
            int[] unSortedArray1 = { 5, 3, 1, 2, 4, 8, 7, 10, 6, 9 };
            BubbleSort(ref unSortedArray1); // => [1, 2, 3, 4, 5, 7, 6, 8, 9, 10]

            Console.WriteLine();

            int[] unSortedArray2 = { 5, 2, 99, 21, 34, 12, 104, -4, 6 };
            BubbleSort(ref unSortedArray2); // => [-4, 2, 5, 6, 12, 21, 34, 99, 104]

            int[] unSortedArray3 = { 274, 234, 324, 567, 123, 45, -345, 324, -123, 0, -1, 0, 213 };
            BubbleSort(ref unSortedArray3); // => [-345, -123, -1, 0, 0, 45, 123, 213, 234, 274, 324, 324, 567]
        }
    }
}