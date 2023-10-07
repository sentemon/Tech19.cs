using System;

public class Program {

  public static void Main(string[] args) {
    // Zadanie 1
    Console.WriteLine("Zadanie 1: Wprowadź liczbę n: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Wynik zadania 1: ");
    for (int i = 0; i < n1; i++)
    {
      Console.Write(Math.Pow(i, 3) + 3 + " ");
    }
    Console.WriteLine();

    // Zadanie 2
    Console.Write("Wynik zadania 2: ");
    for (int i = 100; i < 1000; i++)
    {
      if (i % 15 == 0)
      {
        Console.Write(i + " ");
      }
    }
    Console.WriteLine();

    // Zadanie 3
    Console.WriteLine("Zadanie 3: Wprowadź liczbę n: ");
    int n3 = int.Parse(Console.ReadLine());
    Console.Write("Wynik zadania 3: ");
    for (int i = 1; i <= n3; i++)
    {
      if (n3 % i == 0)
      {
        Console.Write(i + " ");
      }
    }

    // Zadanie 4
    int count = 0;

    for (int i = 10; i < 100; i++)
    {
      count += i;
    }
    Console.WriteLine("Wynik zadania 3: " + count);

    // Zadanie 5

    // Zadanie 6
    int a = 1;
    int b = 1;
    int n = int.Parse(Console.ReadLine());
    
    for (int i = 0; i < n; i++)
    {
      Console.Write(a + " ");
      int temp = a;
      a = b;
      b = temp + b;
    }
  }
}
