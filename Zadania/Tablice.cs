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
        int[] array = new int[20];
        
        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(10, 99);
        
        // 1. Oblicz sume elementów w tej tablicy
        int zad1 = 0;
        foreach (var el in array)
            zad1 += el;
        Console.WriteLine(zad1);
        
        // 2. wypisz liczby zlokalizowane na indeksach parzystych
        for (int i = 0; i < array.Length; i+=2)
            Console.Write(array[i] + " ");
        Console.WriteLine();
        
        // 3. Wypisz liczby parzyste, niepodzielne przez 3 i wieksze niz 50.
        foreach (var el in array)
            if (el % 2 == 0 && el % 3 != 0 && el > 50)
                Console.Write(el + " ");
        Console.WriteLine();
        
        // 4. Wypisz ilosc i sume liczb, które sa mniejsze niz polowa średniej wartosci liczb w tabicy.
        int polowaSredniej = array.Sum() / array.Length / 2;
        int counter4 = 0;
        int sum4 = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < polowaSredniej)
            {
                counter4++;
                sum4 += array[i];
            }
        }
        Console.WriteLine(counter4 + " " + sum4);
        
        // 5. Oblicz srednia wazona liczb w tablicy.
        // Rozkiad wag:
        // <10; 40> - waga 1
        // <41; 70> - waga 2
        // <71; 99> - waga 3
        int sum5 = 0;
        int counter5 = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= 40)
            {
                sum5 += array[i] * 1;
                counter5 += 1;
            }
            
            else if (array[i] <= 70)
            {
                sum5 += array[i] * 2;
                counter5 += 2;
            }

            else
            {
                sum5 += array[i] * 3;
                counter5 += 3;
            }
        }
        Console.WriteLine(sum5 / counter5);

        // II. User wisuje do tablicy n cyfr, cyli decyduje o ilosci i wartosciach cyfr w tablicy
        // 1. Sprawdz czy w tablicy sa licy parzyste i oblic ich ilosc
        // 2. Sprawdz czy tablica jest odleglosciowa, cyli czy róznica dwoch sasiednich cyfr wynosi prynajmniej 3.
        // 3. Sprawd czy tablica jest posortowana rosnaco.
        // 4. Znajdz dominante w tablicy (wpisuj cyfry ak by byla tylko jedna dominanta)
        // 5. Znajdz mode w tablicy (wpisuj licby w porzadku rosnacym, albo posortuj jak umiesz Array.Sort() - nie wymagam jeszcze sortowania)

        // III. Wisz do macierzy 5x5 losowe liczby dwucyfrowe.
        // 1. Wypisz sume liczb na diagonalach (glównych przekatnych)
        // 2. Wyznacz sume liczb, dla których suma indeksów wiersza i kolumny jest parzysta.
        // 3. Rozwarz wystkie 9 podmacierzy o wymiarach 3x3 i wyznacz sume elementów kazdej z nich.

        // IV. User wisuje do macierzy o wymiarach n x n wzystkie n*n cyfr.
        // (prosze nie presadzac z deklaracja duzego n - testujcie na max n = 3)
        // 1. Sprawdz czy macierz jest pociagajaca, cyli czy gazies w niej sa dwa takie same sasiednie elementy. Prez sasiada rozumiemy element który jest obok (lewo, prawo, góra, dól) danego elementu.
        // Elementy "w srodku" maja 4 sasiadów.
        //  Proponuje to robic tak, by dolozy do macierzy ramke z zer.
        // Wówczas nie bedzie treba robic warunków dla elementów brzegowych, które maja
        // mniej 3 sasiadów i to jeszcze z róznych stron.

        // V. Narysuj ksztalty (n wisuje user i pryjmij, ze jest to liczba nieparzysta):
        /*
            **X**
            **X**
            XXXXX
            **X**
            **X**
        */

        /*
            X*X*X
            *X*X*
            X*X*X
            *X*X*
            X*X*X
        */

        /*
            **X**
            *****
            X*X*X
            *****
            **X**
        */

        /*
            **X**
            *XXX*
            XXXXX
            *XXX*
            **X**
        */
    }
}