using System; 

public class Program {

  public static void Main(string[] args) {
    // zadanie 1
    Console.WriteLine("Wprowadź liczbę:");
    int a1 = int.Parse(Console.ReadLine());
    if (a1 % 3 == 0)
    {
      Console.WriteLine("TAK");
    }
    else
    {
     Console.WriteLine("NIE"); 
    }
    // zadanie 2
    Console.WriteLine("Wprowadź liczbę:");
    int a2 = int.Parse(Console.ReadLine());
    if (a2 >= 100 && a2 <= 999 && a2 % 17 == 0)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
    // zadanie 3
    Console.WriteLine("Wprowadź swój wiek");
    int wiek = int.Parse(Console.ReadLine());
    if (wiek >= 18)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
    // zadanie 4
    Console.WriteLine("Wprowadź wagę ciężarówki(w kilogramach):");
    int waga = int.Parse(Console.ReadLine());
    int limit = 20000;
    if (waga <= limit)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
    // zadanie 5
    Console.WriteLine("Wprowadź 3 liczby");
    int a5 = int.Parse(Console.ReadLine());
    int b5 = int.Parse(Console.ReadLine());
    int c5 = int.Parse(Console.ReadLine());
    if (a5 < c5 && c5 < b5 || a5 > c5 && c5 > b5)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
    // zadanie 6
    int a6 = int.Parse(Console.ReadLine());
    int p6 = int.Parse(Console.ReadLine());
    if (Math.Pow(a6, p6) % p == a6)
    {
        Console.WriteLine("TAK");
    }
    else
    {
        Console.WriteLine("NIE");
    }
    // zadanie 7
    int p7 = int.Parse(Console.ReadLine());
    int k7 = int.Parse(Console.ReadLine());
    int s7 = int.Parse(Console.ReadLine());
    if (p7 + 3 * s7 >= k7)
    {
        Console.WriteLine("TAK");
    }
    else
    {
        Console.WriteLine("NIE");
    }
    // zadanie dodatkowe
    
  }
}
