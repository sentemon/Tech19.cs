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
  }
}
