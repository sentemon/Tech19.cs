using System;

namespace Lessons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // zadanie 1
            int suma = 0;
            int n = 0;
            while (n < 9)
            {
                n++;
                suma += n;
            }
            Console.WriteLine(suma);

            // zadanie 2
            int suma = 0;
            int n = 12;
            while (n < 100)
            {
                suma += n;
                n+=4;
            }
            Console.WriteLine(suma);

            // zadanie 3
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int suma = 0;
            while (i < n)
            {
                i++;
                suma += i*3;
            }
            Console.WriteLine(suma);
            
            // zadanie 4 na 2 rozwiązania. Wypisz liczby n  2, 6, 18, 54, 162
            // rozwiązanie 1
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int wynik = 2;
            int suma = 0; 
            while (i < n)
            {
                i++;
                suma += wynik;
                wynik *= 3;
            }
            Console.WriteLine(suma);

            // rozwiązanie 2
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int suma = 0;
            while (i < n)
            {
                suma = suma + (int)Math.Pow(3, i) * 2;
                i++;
            }
            Console.WriteLine(suma);
        }
    }
}