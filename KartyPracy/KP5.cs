// Karta Pracy nr 5
using System;

class Program
{
    public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    public static int zadanie1()
    {
        int sum = 0;
        
        for (int i = 10; i < 100; i++)
            if (IsPrime(i))
                sum += i;

        return sum;
    }

    public static int zadanie2()
    {
        int sum = 0;

        int[] digits = Math.Pow(2, 2019).ToString().Split().Select(x => int.Parse(x)).ToArray();

        return digits.Sum();
    }

    public static int zadanie3(int n) 
    {
        int count = 0;

        for (int a = 1; a < n; a++) 
        {
            for (int b = a; b < n; b++) 
            {
                int c = n - a - b;
                if (c > 0 && a * a + b * b == c * c) 
                    count++;
            }
        }

        return count;
    }

    public static bool zadanie4(int n, int d)
    {
        return n % d == 0;
    }

    public static int zadanie5(int n)
    {
        if (n == 0)
            return 0;

        return n % 10 + zadanie5(n / 10);
    }

    public static double pierwsza(ref int n)
    {
        return n % 2 == 0 ? druga(ref n) : trzecia(ref n);
    }

    private static int druga(ref int n) => n * 3;

    private static double trzecia(ref int n) => n * 0.4;



    public static void Main(string[] args)
    {
        // zadanie 1
        Console.WriteLine(zadanie1());

        // zadanie 2
        Console.WriteLine(zadanie2());

        // zadanie 3
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(zadanie3(n));

        // zadanie 4   
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(zadanie4(n, d));

        // zadanie 5
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(zadanie5(n));

        // zadanie 6, wersja 1
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(pierwsza(ref n));

        // zadanie 6, wersja 2
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(pierwsza(ref n));
        Console.WriteLine(druga(ref n));
        Console.WriteLine(trzecia(ref n));

        // uwazam ze wersja 1 jest lepsza poniewaz nie trzeba przekazywac zmiennej n do funkcji druga i trzecia oraz nie narusz zasady hermetyzacji (jesli jest wywolywana z innej klasy)
    }
}