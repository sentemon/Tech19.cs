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
  }
}
