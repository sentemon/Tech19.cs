// Karta Pracy nr 2a
using System; 

public class Program {

  public static void Main(string[] args) {
    
    // zadanie 1
    Console.WriteLine("Wprowadź dwie liczby: ");

    Console.Write("Podaj pierwszą liczbę: ");
    int a1 = int.Parse(Console.ReadLine());

    Console.Write("Podaj drugą liczbę: ");
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

    Console.Write("Podaj pierwszą liczbę: ");
    double a2 = double.Parse(Console.ReadLine());

    Console.Write("Podaj drugą liczbę: ");
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

    Console.Write("Podaj pierwszą liczbę: ");
    int k = int.Parse(Console.ReadLine());
    
    Console.Write("Podaj drugą liczbę: ");
    int l = int.Parse(Console.ReadLine());

    Console.Write("Podaj trzecią liczbę: ");
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

    Console.Write("Podaj pierwszą liczbę: ");
    int number1 = int.Parse(Console.ReadLine());
    
    Console.Write("Podaj drugą liczbę: ");
    int number2 = int.Parse(Console.ReadLine());

    Console.Write("Podaj drugą liczbę: ");
    int number3 = int.Parse(Console.ReadLine());

    Console.Write("Podaj czwartą liczbę: ");
    int number4 = int.Parse(Console.ReadLine());

    int minNumber = Math.Min(Math.Min(number1, number2), Math.Min(number3, number4)); // sprawdzenie najmniejszej liczby

    Console.WriteLine("Najmniejsza liczba z podanych: " + minNumber);

    // zadanie 5
    Console.WriteLine("Wprowadź trzy liczby: ");
    
    Console.Write("Podaj pierwszą liczbę: ");
    double a5 = double.Parse(Console.ReadLine());

    Console.Write("Podaj drugą liczbę: ");
    double b5 = double.Parse(Console.ReadLine());

    Console.Write("Podaj trzecią liczbę: ");
    double c5 = double.Parse(Console.ReadLine());

    // Sprawdzenie nierówności trójkąta
    if (a5 + b5 > c5 && a5 + c5 > b5 && b5 + c5 > a5)
    {
      Console.WriteLine("TAK");
    }
    else
    {
      Console.WriteLine("NIE");
    }
    // zadanie 6
    Console.WriteLine("Podaj długość pierwszego boku: ");
    double a = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Podaj długość drugiego boku: ");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("Podaj długość trzeciego boku: ");
    double c = double.Parse(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a) // Sprawdzamy, czy można zbudować trójkąt na podstawie nierówności trójkąta.
    {
      if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) // Sprawdzamy, czy trójkąt jest prostokątny na podstawie twierdzenia Pitagorasa.
      {
        Console.WriteLine("Trójkąt jest prostokątny.");
      }
      else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a) // Sprawdzamy, czy trójkąt jest rozwartokątny na podstawie długości boków.
      {
        Console.WriteLine("Trójkąt jest rozwartokątny."); 
      }
      else // Jeśli nie jest ani prostokątny, ani rozwartokątny, to jest ostrokątny.
      {
        Console.WriteLine("Trójkąt jest ostrokątny.");
      }
    }
    else // Jeśli nie spełnia warunków nierówności trójkąta, nie można zbudować trójkąta.
    {
      Console.WriteLine("Z podanych długości nie można zbudować trójkąta.");
    }
  }
}
