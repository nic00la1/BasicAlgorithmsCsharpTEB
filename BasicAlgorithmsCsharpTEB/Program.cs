using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witamy w aplikacji: Algorytmy podstawowe C#!");
        IsPrime(42);
        GCD(196, 420);
    }

    // Zadanie 1 - Sprawdzanie czy liczba jest pierwszą
    // Liczba pierwsza to taka liczba całkowita większa od 1, która dzieli się wyłącznie przez 1 oraz przez
    // samą siebie
    public static bool IsPrime(int number)
    {
        Console.WriteLine("\n================ ZADANIE 1 ================");
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
    public static int GCD(int a, int b) // GCD - Greatest Common Divisor
    {
        Console.WriteLine("\n================ ZADANIE 2 ================");
        Console.WriteLine("Algorytm Euklidesa\n");

        int originalA = a;
        int originalB = b;

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine(
            $"Największy wspólny dzielnik z liczb {originalA} i {originalB} to: {a}");
        return a;
    }

    // Zadanie 3 - Szyfr Cezara
    // Szyfr Cezara to jeden z najstarszych i najprostszych szyfrów, opierający się na przesunięciu liter w
    // alfabecie o stałą liczbę miejsc. Dla przykładu, jeśli przesuniemy litery o 3 miejsca, to 'A' stanie się
    // 'D', 'B' stanie się 'E', i tak dalej. Przy końcu alfabetu, litery są "owijane" wokół, co oznacza, że po
    // 'Z' wracamy do 'A

}
