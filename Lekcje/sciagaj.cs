using System; 

public class Program {

  public static void Main(string[] args) {
    int[] T = new int[50];
    Random r = new Random();

    int suma = 0;
    int iloscWiekszychOdSredniej = 0;
    int sumaWiekszychOdSredniej = 0;

    for (int i = 0; i < 50; i++)
    {
      T[i] = r.Next(10, 100);
      suma += T[i];
      Console.Write(T[i] + " ");
      
    }
    double srednia = suma / 50;
    for (int i = 0; i < 50; i++)
    {
      if (T[i] > srednia)
      {
        iloscWiekszychOdSredniej++;
        sumaWiekszychOdSredniej += T[i];
      }
    }
    Console.WriteLine("Średnia liczb powyzej sredniej (XDD): " + srednia);
    Console.WriteLine("Ilosc liczb powyzej sredniej: " + iloscWiekszychOdSredniej);
  }
}
