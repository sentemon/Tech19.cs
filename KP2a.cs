using System; 

public class Program {

  public static void Main(string[] args) {
    // zadanie 1
    Console.WriteLine("Wprowadź dwie liczby: ");
    int a1 = int.Parse(Console.ReadLine());
    int b1 = int.Parse(Console.ReadLine());

    if ((a1 + b1) % 2 == 0)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
    
    // zadanie 2
    Console.WriteLine("Wprowadź dwie liczby: ");
    double a2 = double.Parse(Console.ReadLine());
    double b2 = double.Parse(Console.ReadLine());

    if (Math.Pow(a2 + b2, 2) >= 4 * a2 * b2)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
  }
}
