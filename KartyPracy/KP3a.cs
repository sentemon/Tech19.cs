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

    // Zadanie 5
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());

    // Zadanie 6
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());


    // Zadanie 7
    Console.Write("Wprowadź liczbę n: ");
    int n = int.Parse(Console.ReadLine());

  }
}
