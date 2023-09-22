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
    if (a2 >= 100 && a <= 999 && a % 17 == 0)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
  }
}
