// Karta Pracy nr 5
using System;

class Program
{
    public static int zadanie1()
    {
        static bool isPrime(num)
        {
            
        }
        int sum = 0;
        
        for (int i = 10; i < 100; i++)
        {
            for (int j = 1; j < i; j++)
            {
                if (j % i != 0)
                {
                    sum += j;
                }
            }
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        // zadanie 1
        Console.WriteLine(zadanie1());
        
    }
}