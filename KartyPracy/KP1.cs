// Karta Pracy nr 1
using System; 

public class Program {

  public static void Main(string[] args) {
    // Zadanie 1
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b1 = int.Parse(Console.ReadLine());
    int zadanie1 = a1 * a1 + b1 * b1;
    Console.WriteLine("Zadanie 1: " + zadanie1);
    
    // Zadanie 2
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b2 = int.Parse(Console.ReadLine());
    int zadanie2 = a2 + b2;
    Console.WriteLine("Zadanie 2: " + Math.Pow(zadanie2, 2));
    
    // Zadanie 3
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b3 = int.Parse(Console.ReadLine());
    int zadanie3 = a3 - b3;
    Console.WriteLine("Zadanie 3: " + Math.Pow(zadanie3, 3));
    
    // Zadanie 4
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź trzecią liczbę całkowitą:");
    int c4 = int.Parse(Console.ReadLine());
    int zadanie4 = a4 * b4 * c4;
    Console.WriteLine("Zadanie 4: " + zadanie4);
    
    // Zadanie 5
    Console.WriteLine("Wprowadź pierwszą liczbę zmiennoprzecinkową:");
    double a5 = double.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę zmiennoprzecinkową:");
    double b5 = double.Parse(Console.ReadLine());
    double zadanie5 = (a5 + b5) * 0.4;
    Console.WriteLine("Zadanie 5: " + zadanie5);
    
    // Zadanie 6
    Console.WriteLine("Wprowadź kwotę w brutto:");
    double a6 = double.Parse(Console.ReadLine());
    double zadanie6 = a6 / 1.23;
    Console.WriteLine("Zadanie 6: " + zadanie6);
    
    // Zadanie 7
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a7 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b7 = int.Parse(Console.ReadLine());
    int zadanie7 = a7 % b7;
    Console.WriteLine("Zadanie 7: " + zadanie7);
  }
}
