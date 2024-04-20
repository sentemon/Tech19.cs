// Karta Pracy nr 3a
using System; 

public class Program {

  public static void Main(string[] args) {
    // Zadanie 1
    Console.WriteLine("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
      Console.Write("∗ − | ");
    }
    
    // Zadanie 2
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("∗");
        }
        if (i < n)
        {
            Console.Write("||");
        }
    }
    
    // Zadanie 3
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.Write("∗");

        for (int j = 1; j <= i; j++)
        {
            Console.Write("|");
        }

        if (i < n)
        {
            Console.Write("−−");
        }
    }

    // Zadanie 4
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i + j) == (n - 1) / 2 || Math.Abs(i - j) == (n - 1) / 2 || (i + j) == (n - 1) + (n - 1) / 2)
                Console.Write("* ");
            else
                Console.Write("  ");
        }

        Console.WriteLine();
    }

    // Zadanie 5
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == n / 2)      Console.Write("* ");
            else if (i == n / 2) Console.Write("— ");
            else                 Console.Write("  ");
        }

        Console.WriteLine();
    }

    // Zadanie 6
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());
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

    // Zadanie 7
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == 0 || j == 0 || i == n - 1 || j == n - 1 || (i == j && i == n / 2 && j == n / 2)) 
                Console.Write("* ");
            else                
                Console.Write("  ");
        }

        Console.WriteLine();
    }

  }
}