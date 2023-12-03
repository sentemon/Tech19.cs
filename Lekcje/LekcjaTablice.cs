using System;

namespace Lessons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] RandomNumbers = new int[10];
            Random r = new Random();

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                RandomNumbers[i] = r.Next(0, 100);
            }
            foreach (int j in RandomNumbers)
            {
                Console.Write(j + " ");
            }
        }
    }
}