using System;

namespace Algorytmy
{
    interface class Sortowanie
    {
        public static void QuickSortHoare(int[] array, int leftIndex = 0, int rightIndex = -1)
        {
            if (rightIndex == -1) rightIndex = array.Length - 1;

            int i = leftIndex;
            int j = rightIndex;
            int pivot = array[(leftIndex + rightIndex) / 2];
            
            while (i <= j)
            {
                while (array[i] < pivot) 
                    i++;
                while (array[j] > pivot) 
                    j--;

                if (i <= j)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSortHoare(array, leftIndex, j);

            if (i < rightIndex)
                QuickSortHoare(array, i, rightIndex);
        }

        static void Main()
        {
            int[] unSortedArray1 = { 5, 3, 1, 2, 4, 8, 7, 10, 6, 9 };
            QuickSortHoare(unSortedArray1); // => [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

            int[] unSortedArray2 = { 5, 2, 99, 21, 34, 12, 104, -4, 6 };
            QuickSortHoare(unSortedArray2); // => [-4, 2, 5, 6, 12, 21, 34, 99, 104]

            int[] unSortedArray3 = { 274, 234, 324, 567, 123, 45, -345, 324, -123, 0, -1, 0, 213 };
            QuickSortHoare(unSortedArray3); // => [-345, -123, -1, 0, 0, 45, 123, 213, 234, 274, 324, 324, 567]
        }
    }
}