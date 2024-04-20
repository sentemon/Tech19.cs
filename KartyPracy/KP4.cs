// Karta Pracy nr 4
using System;

public class Program 
{
    // Zadanie 1
    public static double Zadanie1_1(double a, double b)
    {
       double res = (a5 + b5) * 0.4;

       return res;
    }

    public static int Zadanie1_2(int a, int b, int c)
    {
       int res = a * b * c;

       return res;
    }

    public static bool Zadanie1_3(int a)
    {
       return a % 3 == 0;
    }

    public static string Zadanie1_4(double a, double b, double c)
    {
       if (a + b > c && a + c > b && b + c > a)
       {
         if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
           return "Trójkąt jest prostokątny.";

         else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
           return "Trójkąt jest rozwartokątny.";

         else
           return "Trójkąt jest ostrokątny.";
       }

       else
         return "Z podanych długości nie można zbudować trójkąta.";
    }

    public static void Zadanie1_5(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j == n - 1) Console.Write("? ");
                else if (i == j)    Console.Write("* ");
                else                Console.Write("  ");
            }

            Console.WriteLine();
        }
    }

    // Zadanie 2
    public static int Zadanie2(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    // Zadanie 3
    public static int Zadanie3(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        
        return Zadanie3(n - 1) * n;
    }

    // Zadanie 4
    public static int Zadanie4(int n)
    {
        if (n == 0)
            return 0;
        
        if (n == 1 || n == 2)
            return 1;
        
        return Zadanie4(n - 1) + Zadanie4(n - 2);
    }

    // Zadanie 5
    public static int[] Zadanie5(int n)
    {
        int[] res = new int[n];
        
        for (int i = 0; i < n; i++)
            res[i] = Zadanie4(i);

        return res;
    }

    // Zadanie 6
    public static int Zadanie6(int n, int x)
    {
        if (x == 0)
            return 1;
        
        return n * Zadanie6(n, x - 1);

    }

    // Zadanie 7
    public static string Zadanie7(int n)
    {
        if (n == 0)
            return "";
        return Zadanie7(n / 2) + (n % 2);
    }


    public static void Main(string[] args)
    {
        // Wywołanie Zadania 1
        // Wywołanie Zadania 1_1
        Console.WriteLine("Wprowadź pierwszą liczbę zmiennoprzecinkową:");
        double a1_1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź drugą liczbę zmiennoprzecinkową:");
        double b1_1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 1_1: " + Zadanie1_1(a1_1, b1_1));

        // Wywołanie Zadania 1_2
        Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
        int a1_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
        int b1_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź trzecią liczbę całkowitą:");
        int c1_2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 1_2: " + Zadanie1_2(a1_2, b1_2, c1_2));

        // Wywołanie Zadania 1_3
        Console.WriteLine("Wprowadź liczbę:");
        int a1_3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 1_3: " + (Zadanie1_3(a1_3) ? "TAK" : "NIE"));

        // Wywołanie Zadania 1_4
        Console.WriteLine("Podaj długość pierwszego boku: ");
        double a6 = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj długość drugiego boku: ");
        double b6 = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj długość trzeciego boku: ");
        double c6 = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 1_4: " + Zadanie1_4(a6, b6, c6));

        // Wywołanie Zadania 1_5
        Console.WriteLine("Wprowadź liczbę n: ");
        int n1_5 = int.Parse(Console.ReadLine());

        Zadanie1_5(n1_5);


        // Wywołanie Zadania 2
        Console.WriteLine("Wprowadź liczbę n: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 2: " + Zadanie2(n2));

        // Wywołanie Zadania 3
        Console.WriteLine("Wprowadź liczbę n: ");
        int n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 3: " + Zadanie3(n3));

        // Wywołanie Zadania 4
        Console.WriteLine("Wprowadź liczbę n: ");
        int n4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 4: " + Zadanie4(n4));

        // Wywołanie Zadania 5
        Console.WriteLine("Wprowadź liczbę n: ");
        int n5 = int.Parse(Console.ReadLine());

        foreach (var el in Zadanie5(n5))
            Console.Write(el + " ");

        // Wywołanie Zadania 6
        Console.WriteLine("Wprowadź liczbę n: ");
        int n6 = int.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź liczbę x: ");
        int x6 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 6: " + Zadanie6(n6, x6));

        // Wywołanie Zadania 7
        Console.WriteLine("Wprowadź liczbę n: ");
        int n7 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadanie 7: " + Zadanie7(n7));
    }

}