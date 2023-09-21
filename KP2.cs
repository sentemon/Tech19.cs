using System; 

public class Program {

  public static void Main(string[] args) {
    // zadanie 1
    Console.WriteLine("Wprowadź liczbę:");
    int a1 = int.Parse(Console.ReadLine());
    if (a1 % 3 == 0)
    {
      Console.WriteLine("Liczba " + a1 + " jest podzilna przez 3");
    }
    else
    {
     Console.WriteLine("Liczba " + a1 + " nie jest podzilna przez 3"); 
    }
  }
}
