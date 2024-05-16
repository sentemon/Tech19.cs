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


    public static void Main(string[] args)
    {
        // zadanie 1
        Console.WriteLine(zadanie1());
        
    }
}