using System;

namespace HelloWorld
{
    class Program
    {
        private static int ileParzystych(ref int[] array)
        {
            int count = 0;
            foreach (var el in array)
                if (el % 2 == 0)
                    count++;

            return count;
        }

        private static bool czyOdleglosciowa(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (Math.Abs(array[i] - array[i + 1]) < 3)
                    return false;
            }
            
            return true;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz ilosc cyfr w tablice");
            int n = int.Parse(Console.ReadLine());
            int[] tablica = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"wpisz liczbe po indeksem {i}");
                tablica[i] = int.Parse(Console.ReadLine());
            }

            // zad1
            Console.WriteLine(ileParzystych(ref tablica));

            // zad2
            Console.WriteLine(czyOdleglosciowa(ref tablica));

        }
    }
}