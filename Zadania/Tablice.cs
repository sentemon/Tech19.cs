using System;
using System.Linq;
using System.Collections.Generic;

class Program 
{
    public static void Main()
    {
        // Zadania tabice 1 i 2 - wymnarowe
        // I. Wpisz do tablicy 20 losowych liczb dwucyfrowych
        Random random = new Random();
        int[] arrayI = new int[20];
        
        for (int i = 0; i < arrayI.Length; i++)
            arrayI[i] = random.Next(10, 99);
        
        // 1. Oblicz sume elementów w tej tablicy
        int zadI1 = 0;
        foreach (var el in arrayI)
            zadI1 += el;
        Console.WriteLine(zadI1);
        
        // 2. wypisz liczby zlokalizowane na indeksach parzystych
        for (int i = 0; i < arrayI.Length; i+=2)
            Console.Write(arrayI[i] + " ");
        Console.WriteLine();
        
        // 3. Wypisz liczby parzyste, niepodzielne przez 3 i wieksze niz 50.
        foreach (var el in arrayI)
            if (el % 2 == 0 && el % 3 != 0 && el > 50)
                Console.Write(el + " ");
        Console.WriteLine();
        
        // 4. Wypisz ilosc i sume liczb, które sa mniejsze niz polowa średniej wartosci liczb w tabicy.
        int polowaSredniej = arrayI.Sum() / arrayI.Length / 2;
        int counterI4 = 0;
        int sumI4 = 0;

        for (int i = 0; i < arrayI.Length; i++)
        {
            if (arrayI[i] < polowaSredniej)
            {
                counterI4++;
                sumI4 += arrayI[i];
            }
        }
        Console.WriteLine(counterI4 + " " + sumI4);
        
        // 5. Oblicz srednia wazona liczb w tablicy.
        // Rozkiad wag:
        // <10; 40> - waga 1
        // <41; 70> - waga 2
        // <71; 99> - waga 3
        int sumI5 = 0;
        int counterI5 = 0;

        for (int i = 0; i < arrayI.Length; i++)
        {
            if (arrayI[i] <= 40)
            {
                sumI5 += arrayI[i] * 1;
                counterI5 += 1;
            }
            
            else if (arrayI[i] <= 70)
            {
                sumI5 += arrayI[i] * 2;
                counterI5 += 2;
            }

            else
            {
                sumI5 += arrayI[i] * 3;
                counterI5 += 3;
            }
        }
        Console.WriteLine(sumI5 / counterI5);

        // II. User wisuje do tablicy n cyfr, cyli decyduje o ilosci i wartosciach cyfr w tablicy
        Console.Write("Wpisz rozmiar tablicy: ");
        int nII = int.Parse(Console.ReadLine());
        int[] arrayII = new int[nII];
        for (int i = 0; i < arrayII.Length; i++)
        {
            Console.Write($"Wpisz do tablicy element nr {i + 1}: ");
            arrayII[i] = int.Parse(Console.ReadLine());
        }
        
        // 1. Sprawdz czy w tablicy sa liczby parzyste i oblicz ich ilosc
        int counterII1 = 0;
        foreach (var el in arrayII)
            if (el % 2 == 0)
                counterII1++;
        Console.WriteLine(counterII1);
        
        // 2. Sprawdz czy tablica jest odleglosciowa, cyli czy róznica dwoch sasiednich cyfr wynosi prynajmniej 3.
        bool czyJestOdleglosciowa = false;
        for (int i = 0; i < arrayII.Length - 1; i++)
        {
            if (Math.Abs(arrayII[i] - arrayII[i + 1]) >= 3)
                czyJestOdleglosciowa = true;
            
            else
            {
                czyJestOdleglosciowa = false;
                break;
            }
        }

        string odpII2 = czyJestOdleglosciowa ? "Tablica jest odleglosciowa" : "Tablica nie jest odleglosciowa";
        Console.WriteLine(odpII2);
        
        // 3. Sprawdz czy tablica jest posortowana rosnaco.
        bool czyPosortowanaRosnaco = false;
        for (int i = 0; i < arrayII.Length - 1; i++)
        {
            if (arrayII[i] < arrayII[i + 1]) // nwm (< || <=)
                czyPosortowanaRosnaco = true;
            
            else
            {
                czyPosortowanaRosnaco = false;
                break;
            }
        }

        string odpII3 = czyPosortowanaRosnaco ? "Tablica jest posortowana rosnaco" : "Tablica nie jest posortowana rosnaco";
        Console.WriteLine(odpII3);
        
        // 4. Znajdz dominante w tablicy (wpisuj cyfry jak by byla tylko jedna dominanta)
        int najciesciejPowtzrzajacaSieLiczba = 0;
        int najwiekszIloscWystapien = 0;

        for (int i = 0; i < arrayII.Length; i++)
        {
            int aktualnaLiczba = arrayII[i];
            int aktulnieWystapien = 1;

            for (int j = i + 1; j < arrayII.Length; j++) // zaczynamy od i + 1 zeby nie sprawdzac juz sprawdzone liczby
                if (aktualnaLiczba == arrayII[j])
                    aktulnieWystapien++;

            if (aktulnieWystapien > najwiekszIloscWystapien)
            {
                najciesciejPowtzrzajacaSieLiczba = aktualnaLiczba;
                najwiekszIloscWystapien = aktulnieWystapien;
            }
        }
        Console.WriteLine("Najciesciej powtzrzajaca sie liczba to: " + najciesciejPowtzrzajacaSieLiczba);
        
        // 5. Znajdz mode w tablicy (wpisuj licby w porzadku rosnacym, albo posortuj jak umiesz Array.Sort() - nie wymagam jeszcze sortowania)
        // nie wiem czym sie rozni od 4
        
        // III. Wpisz do macierzy 5x5 losowe liczby dwucyfrowe.
        int[,] arrayIII = new int[5, 5];
        for (int i = 0; i < arrayIII.GetLength(0); i++)
            for (int j = 0; j < arrayIII.GetLength(1); j++)
                arrayIII[i, j] = random.Next(10, 99);
        
        // 1. Wypisz sume liczb na diagonalach (glównych przekatnych)
        int sumIII1 = 0;
        for (int i = 0; i < arrayIII.GetLength(0); i++)
            for (int j = 0; j < arrayIII.GetLength(1); j++)
                if (i == j || i + j == 5)
                    sumIII1 += arrayIII[i, j];
        Console.WriteLine(sumIII1);
                
        // 2. Wyznacz sume liczb, dla których suma indeksów wiersza i kolumny jest parzysta.
        int sumIII2 = 0;
        for (int i = 0; i < arrayIII.GetLength(0); i++)
            for (int j = 0; j < arrayIII.GetLength(1); j++)
                if ((i + j) % 2 == 0)
                    sumIII2 += arrayIII[i, j];
        Console.WriteLine(sumIII2);
        // 3. Rozwarz wystkie 9 podmacierzy o wymiarach 3x3 i wyznacz sume elementów kazdej z nich.
        // nie wiem o co chodzi
        
        // IV. User wpisuje do macierzy o wymiarach n x n wzystkie n*n cyfr.
        // (prosze nie presadzac z deklaracja duzego n - testujcie na max n = 3)
        // 1. Sprawdz czy macierz jest pociagajaca, cyli czy gazies w niej sa dwa takie same sasiednie elementy. Prez sasiada rozumiemy element który jest obok (lewo, prawo, góra, dól) danego elementu.
        // Elementy "w srodku" maja 4 sasiadów.
        // Proponuje to robic tak, by dolozyc do macierzy ramke z zer.
        // Wówczas nie bedzie treba robic warunków dla elementów brzegowych, które maja
        // mniej 3 sasiadów i to jeszcze z róznych stron.
        int nIV = int.Parse(Console.ReadLine());
        int[,] arrayIV = new int[nIV, nIV];
        for (int i = 0; i < nIV; i++)
            for (int j = 0; j < nIV; j++)
                arrayIV[i, j] = int.Parse(Console.ReadLine());
        
        bool czyPociagjaca = false;
        
        int[,] macierzZRamka = new int[nIV + 2, nIV + 2];
        
        for (int i = 0; i < nIV; ++i)
            for (int j = 0; j < nIV; ++j)
                macierzZRamka[i + 1, j + 1] = arrayIV[i, j];
        
        for (int i = 1; i <= nIV; ++i)
        {
            for (int j = 1; j <= nIV; ++j)
            {
                if (macierzZRamka[i, j] == macierzZRamka[i, j + 1] ||
                    macierzZRamka[i, j] == macierzZRamka[i, j - 1] ||
                    macierzZRamka[i, j] == macierzZRamka[i + 1, j] ||
                    macierzZRamka[i, j] == macierzZRamka[i - 1, j])
                {
                    czyPociagjaca = true;
                    break;
                }
            }
        }

        string odpIV = czyPociagjaca ? "Macierz jest pociagjaca" : "Macierz nie jest pociagjaca";
        Console.WriteLine(odpIV);

        // V. Narysuj ksztalty (n wpisuje user i przyjmij, ze jest to liczba nieparzysta):
        int nV = int.Parse(Console.ReadLine());
        for (int i = 0; i < nV; i++)
        {
            for (int j = 0; j < nV; j++)
            {
                if (i == nV / 2 || j == nV / 2)
                    Console.Write("X");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }
        /*
            **X**
            **X**
            XXXXX
            **X**
            **X**
        */
        Console.WriteLine();
        for (int i = 0; i < nV; i++)
        {
            for (int j = 0; j < nV; j++)
            {
                if ((i + j) % 2 == 0)
                    Console.Write("X");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }
        /*
            X*X*X
            *X*X*
            X*X*X
            *X*X*
            X*X*X
        */
        Console.WriteLine();
        for (int i = 0; i < nV; i++)
        {
            for (int j = 0; j < nV; j++)
            {
                if (i == j || j == nV - 1 - i)
                    Console.Write("X");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }
        /*
            **X**
            *****
            X*X*X
            *****
            **X**
        */
        Console.WriteLine();
        for (int i = 0; i < nV; i++)
        {
            for (int j = 0; j < nV; j++)
            {
                if (i == nV / 2 || j == nV / 2 || i == j || j == nV - 1 - i)
                    Console.Write("X");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }
        /*
            **X**
            *XXX*
            XXXXX
            *XXX*
            **X**
        */
    }
}