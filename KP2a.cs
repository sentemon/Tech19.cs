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
  }
}
