using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witamy w aplikacji: Algorytmy podstawowe C#!");

        // Zadanie 1 - Sprawdzanie czy liczba jest pierwszą
        Console.WriteLine(
            "Podaj liczbę, którą chcesz sprawdzić, czy jest liczbą pierwszą:");
        int primeNumber = int.Parse(Console.ReadLine());
        IsPrime(primeNumber);

        // Zadanie 2 - Algorytm Euklidesa
        Console.WriteLine(
            "Podaj dwie liczby, aby znaleźć ich największy wspólny dzielnik:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        GCD(a, b);

        // Zadanie 3 - Szyfr Cezara
        Console.WriteLine("Podaj tekst do zaszyfrowania:");
        string text = Console.ReadLine();
        Console.WriteLine(
            "Podaj klucz (liczbę), o ile miejsc w alfabecie przesunąć litery:");
        int shift = int.Parse(Console.ReadLine());
        DisplayCaesarCipher(text, shift);

        // Zadanie 4 - Znajdowanie liczb Fibonacciego
        Console.WriteLine(
            "Podaj liczbę n, aby wyświetlić n liczb Fibonacciego:");
        int n = int.Parse(Console.ReadLine());
        DisplayFibonacci(n);

        // Zadanie 5 - Rozkład liczby na czynniki pierwsze
        Console.WriteLine(
            "Podaj liczbę, aby rozłożyć ją na czynniki pierwsze:");
        int number = int.Parse(Console.ReadLine());
        PrimeFactors(number);

        // Zadanie 6 - Znajdowanie najmniejszego oraz największego elementu w zbiorze
        int[] numbers = { 4, 12, 5, 1, 8, 30, 182, 3, 6, 14, 28, 50, 13 };
        FindMinMax(numbers);

        // Zadanie 7 - Sortowanie bąbelkowe
        BubbleSort(numbers);

        // Zadanie 8 - Sortowanie przez wybór
        SelectionSort(numbers);

        // Zadanie 9 - Sortowanie przez wstawianie
        InsertionSort(numbers);
    }

    // Zadanie 1 - Sprawdzanie czy liczba jest pierwszą
    public static bool IsPrime(int number)
    {
        Console.WriteLine("\n================ ZADANIE 1 ================");
        Console.WriteLine("Sprawdzanie czy liczba jest pierwszą\n");
        if (number < 2)
        {
            Console.WriteLine($"Liczba: {number} nie jest liczbą pierwszą");
            WaitForUser();
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0)
            {
                Console.WriteLine($"Liczba: {number} nie jest liczbą pierwszą");
                WaitForUser();
                return false;
            }

        Console.WriteLine($"Liczba: {number} jest liczbą pierwszą");
        WaitForUser();
        return true;
    }

    // Zadanie 2 - Algorytm Euklidesa
    public static int GCD(int a, int b)
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
        WaitForUser();
        return a;
    }

    // Zadanie 3 - Szyfr Cezara
    public static string CaesarCipher(string text, int shift)
    {
        Console.WriteLine("\n================ ZADANIE 3 ================");
        Console.WriteLine("Szyfr Cezara\n");

        char[] buffer = text.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((letter + shift - offset) % 26 + offset);
            }

            buffer[i] = letter;
        }

        return new string(buffer);
    }

    // Metoda pomocnicza do wyświetlania zaszyfrowanego tekstu
    public static void DisplayCaesarCipher(string originalText, int shift)
    {
        string encryptedText = CaesarCipher(originalText, shift);
        Console.WriteLine($"{originalText} --> {encryptedText}");
        WaitForUser();
    }

    // Zadanie 4 - Znajdowanie liczb Fibonacciego
    public static void DisplayFibonacci(int n)
    {
        Console.WriteLine("\n================ ZADANIE 4 ================");
        Console.WriteLine("Ciąg Fibonacciego\n");

        if (n < 0)
        {
            Console.WriteLine("Liczba musi być większa lub równa 0");
            WaitForUser();
            return;
        }

        long a = 0;
        long b = 1;

        Console.Write("Sekwencja Fibonacciego: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            long temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine();
        WaitForUser();
    }

    // Zadanie 5 - Rozkład liczby na czynniki pierwsze
    public static void PrimeFactors(int number)
    {
        Console.WriteLine("\n================ ZADANIE 5 ================");
        Console.WriteLine("Rozkład liczby na czynniki pierwsze\n");

        if (number < 2)
        {
            Console.WriteLine("Liczba musi być większa niż 1");
            WaitForUser();
            return;
        }

        Console.Write($"Czynniki pierwsze liczby {number} to: ");
        for (int i = 2; i <= number; i++)
            while (number % i == 0)
            {
                Console.Write(i + " ");
                number /= i;
            }

        Console.WriteLine();
        WaitForUser();
    }

    // Zadanie 6 - Znajdowanie najmniejszego oraz największego elementu w zbiorze
    public static void FindMinMax(int[] numbers)
    {
        Console.WriteLine("\n================ ZADANIE 6 ================");
        Console.WriteLine(
            "Znajdowanie najmniejszego oraz największego elementu w zbiorze\n");

        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
                min = number;
            if (number > max)
                max = number;
        }

        Console.WriteLine($"Najmniejszy element: {min}");
        Console.WriteLine($"Największy element: {max}");
        WaitForUser();
    }

    // Zadanie 7 - Sortowanie bąbelkowe
    public static void BubbleSort(int[] numbers)
    {
        Console.WriteLine("\n================ ZADANIE 7 ================");
        Console.WriteLine("Sortowanie bąbelkowe\n");

        int n = numbers.Length;
        for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }

        Console.WriteLine("Posortowana tablica: " + string.Join(", ", numbers));
        WaitForUser();
    }

    // Zadanie 8 - Sortowanie przez wybór
    public static void SelectionSort(int[] numbers)
    {
        Console.WriteLine("\n================ ZADANIE 8 ================");
        Console.WriteLine("Sortowanie przez wybór\n");

        int n = numbers.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
                if (numbers[j] < numbers[minIndex])
                    minIndex = j;

            int temp = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = temp;
        }

        Console.WriteLine("Posortowana tablica: " + string.Join(", ", numbers));
        WaitForUser();
    }

    // Zadanie 9 - Sortowanie przez wstawianie
    public static void InsertionSort(int[] numbers)
    {
        Console.WriteLine("\n================ ZADANIE 9 ================");
        Console.WriteLine("Sortowanie przez wstawianie\n");

        int n = numbers.Length;
        for (int i = 1; i < n; i++)
        {
            int key = numbers[i];
            int j = i - 1;

            while (j >= 0 && numbers[j] > key)
            {
                numbers[j + 1] = numbers[j];
                j--;
            }

            numbers[j + 1] = key;
        }

        Console.WriteLine("Posortowana tablica: " + string.Join(", ", numbers));
        WaitForUser();
    }

    // Metoda pomocnicza do oczekiwania na naciśnięcie klawisza i czyszczenia konsoli
    public static void WaitForUser()
    {
        Console.ReadKey();
        Console.Clear();
    }
}
