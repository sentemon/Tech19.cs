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
        Console.Write(i*i + " ");
      }
    }
  }
}
