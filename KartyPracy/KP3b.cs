using System; 

public class Program {

  public static void Main(string[] args) {
    // Zadanie 1
    for (int i = 1; i <= 30; i++)
    {
      Console.Write(i + " ");
    }
    
    // Zadanie 2
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
      if (i % 2 != 0)
      {
        Console.Write(i * i + " ");
      }
      else
      { 
        n++;
      }
    }
    
    // Zadanie 3
    for (int i = 1137; i < 10000; i+=379)
    {
      Console.Write(i + " ");
    }
    
    // Zadanie 4
    for (int i = 100; i < 1000; i++)
    {
      if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0) // nie jestem pewien czy dobrze zrozumiałem polecenie
      {
        Console.Write(i + " ");
      } 
    }
    
    // Zadanie 5
    int n = int.Parse(Console.ReadLine());
    int num;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
      num = int.Parse(Console.ReadLine());
      count += num;
    }
    Console.Write("SUMA: " + count);
    
    // Zadanie 6
    int k = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 2; i <= k; i+=2)
    {
      sum += i;
    }
    Console.WriteLine("Suma: " + sum);
    
    // Zadanie 7
    int m = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 11; i <= m; i += 2)
    {
        sum += i;
    }
    Console.WriteLine("Suma: " + sum);
    
    // Zadanie 8
    Console.WriteLine("Wprowadź kwotę inwestycji: ");
    double W0 = double.Parse(Console.ReadLine());

    Console.WriteLine("Wprowadź okres inwestycji w latach: ");
    double L = double.Parse(Console.ReadLine());

    double rate = 0.06 / 12; // Miesięczna stopa procentowa

    int months = (int)(L * 12); // Okres inwestycji w miesiącach
    double wartosc = W0;

    for (int i = 0; i < months; i++)
    {
        wartosc += wartosc * rate;
    }
    Console.WriteLine(Math.Round(wartosc, 2));
    
    // Zadanie 9
    int n = int.Parse(Console.ReadLine());
    int sum = 0;
    
    for (int i = 21, count = 0; count < n; i += 100, count++)
    {
        sum += i;
    }
    Console.WriteLine("Suma: " + sum);
    
    // Zadanie 10
  }
}
