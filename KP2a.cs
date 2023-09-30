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
    Console.WriteLine("Wprowadź cztery liczby: ");
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    int number3 = int.Parse(Console.ReadLine());
    int number4 = int.Parse(Console.ReadLine());

    int minNumber = Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));

    Console.WriteLine("Najmniejsza liczba z podanych: " + minNumber);

    // zadanie 5
    Console.Write("Podaj pierwszą liczbę: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Podaj drugą liczbę: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Podaj trzecią liczbę: ");
    double c = Convert.ToDouble(Console.ReadLine());

    // Sprawdzenie nierówności trójkąta
    if (a + b > c && a + c > b && b + c > a)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
    
  }
}
