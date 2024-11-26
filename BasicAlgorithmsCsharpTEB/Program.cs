using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witamy w aplikacji: Algorytmy podstawowe C#!");
        IsPrime(42);
    }

    // Zadanie 1 - Sprawdzanie czy liczba jest pierwszą
    // Liczba pierwsza to taka liczba całkowita większa od 1, która dzieli się wyłącznie przez 1 oraz przez
    // samą siebie
    public static bool IsPrime(int number)
    {
        Console.WriteLine("\n\t====== ZADANIE 1 ======");
        Console.WriteLine("Sprawdzanie czy liczba jest pierwszą\n");
        if (number < 2)
            Console.WriteLine($"Liczba: {number} nie jest liczbą pierwszą");

        for (int i = 2; i < number; i++)
            if (number % i == 0)
            {
                Console.WriteLine($"Liczba: {number} nie jest liczbą pierwszą");
                return false;
            }

        Console.WriteLine($"Liczba: {number} jest liczbą pierwszą");
        return true;
    }

    // Zadanie 2 - Algorytm Euklidesa
    // Algorytm Euklidesa służy do wyznaczania największego wspólnego dzielnika (NWD) dwóch liczb.
}
