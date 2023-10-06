using System;

public class Program {

    public static void Main(string[] args) {
        // zadanie 1
        for (int i = 0; i < n; i++)
		{
            Console.WriteLine(Math.Pow(i, 3) + 3);
        }

        // zadanie 2
        for (int i = 100; i < 1000; i++)
		{
            if (i % 15 == 0)
			{
                Console.WriteLine(i);
            }
        }
    }
}
