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

    if ((a2 + b2) / 2 > Math.Sqrt(a2 * b2))
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }

    // zadanie 3
    Console.WriteLine("Wprowadź trzy liczby: ");
    int k = int.Parse(Console.ReadLine());
    int l = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());

    if (k == l)
    {
      Console.WriteLine("TAK " + k + " = " + l);
    }
    
    else if (k == m)
    {
      Console.WriteLine("TAK " + k + " = " + m);
    }

    else if (l == m)
    {
      Console.WriteLine("TAK " + l + " = " + m);
    }
    
    else
    {
      Console.WriteLine("NIE");
    }

    // zadanie 4
  }
}
