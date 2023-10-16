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
  }
}
