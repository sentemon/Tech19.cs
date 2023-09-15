using System; 

public class Program {

  public static void Main(string[] args) {
    // Zadanie 1: Wprowadź dwie liczby całkowite i oblicz sumę ich kwadratów.
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b1 = int.Parse(Console.ReadLine());
    int zadanie1 = a1 * a1 + b1 * b1;
    Console.WriteLine("Zadanie 1: " + zadanie1);
    
    // Zadanie 2: Wprowadź dwie liczby całkowite i oblicz kwadrat ich sumy.
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b2 = int.Parse(Console.ReadLine());
    int zadanie2 = a2 + b2;
    Console.WriteLine("Zadanie 2: " + Math.Pow(zadanie2, 2));
    
    // Zadanie 3: Wprowadź dwie liczby całkowite i oblicz sześcian różnicy.
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b3 = int.Parse(Console.ReadLine());
    int zadanie3 = a3 - b3;
    Console.WriteLine("Zadanie 3: " + Math.Pow(zadanie3, 3));
    
    // Zadanie 4: Wprowadź trzy liczby całkowite i oblicz ich iloczyn.
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź trzecią liczbę całkowitą:");
    int c4 = int.Parse(Console.ReadLine());
    int zadanie4 = a4 * b4 * c4;
    Console.WriteLine("Zadanie 4: " + zadanie4);
    
    // Zadanie 5: Wprowadź dwie liczby zmiennoprzecinkowe i oblicz ich średnią arytmetyczną.
    Console.WriteLine("Wprowadź pierwszą liczbę zmiennoprzecinkową:");
    double a5 = double.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę zmiennoprzecinkową:");
    double b5 = double.Parse(Console.ReadLine());
    double zadanie5_1 = 2 * (a5 + b5) / 5;
    double zadanie5_2 = (a5 + b5) * 0.4;
    Console.WriteLine("Zadanie 5: " + (zadanie5_1 + zadanie5_2));
    
    // Zadanie 6: Wprowadź liczbę zmiennoprzecinkową brutto i oblicz netto 23%
    Console.WriteLine("Wprowadź kwotę w brutto:");
    double a6 = double.Parse(Console.ReadLine());
    double zadanie6 = a6 / 1.23;
    Console.WriteLine("Zadanie 6: " + zadanie6);
    
    // Zadanie 7: Wprowadź dwie liczby całkowite i oblicz resztę z dzielenia.
    Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
    int a7 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
    int b7 = int.Parse(Console.ReadLine());
    int zadanie7 = a7 % b7;
    Console.WriteLine("Zadanie 7: " + zadanie7);
  }
}