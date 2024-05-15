using System;

namespace Algorytmy
{
    internal class Search
    {
        public static bool LinearSearch(in int[] array, in int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return true; 
                }
            }

            return false;
        }

        public static void Main()
        {
            int[] array1 = { 1, 2, 3, 4 };
            int target1 = 3;

            bool result = LinearSearch(in array1, in target1);

            string ans = result ? "Element found in the array." : "Element not found in the array.";
            
            Console.WriteLine(ans);
        }
    }
}