using System;

namespace Lessons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // zadanie 1
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

            // zadanie 2
            int[] RandomNumbers = new int[10];
            Random r = new Random();

            int CzyParzysta = 0;

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                RandomNumbers[i] = r.Next(0, 100);
            }
            
            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                Console.Write(RandomNumbers[i] + " ");
            }

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                if (RandomNumbers[i] % 2 == 0)
                {
                    CzyParzysta++;
                }
                else
                {
                    CzyParzysta--;
                }
            }
            if (CzyParzysta > 0)
            {
                Console.WriteLine("\nW tablicy jest więcej liczb parzystych");
            }
            else if (CzyParzysta < 0)
            {
                Console.WriteLine("\nW tablicy jest więcej liczb nieparzystych");
            }
            else
            {
                Console.WriteLine("\nW tablicy jest tyle samo liczb parzystych i nieparzystych");
            }
        }
    }
}