using System;

public class Program {

    public static void Main(string[] args) {
        // zadanie 1
        Console.WriteLine("Wpisz liczbę n:");

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) 
        {
            Console.WriteLine(Math.Pow(i, 3) + 3);
        }
    }
}
