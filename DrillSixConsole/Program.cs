using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 7, 19, 42, 8, 3, 15, 20 };
        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i>=0; i++)
            Console.WriteLine(numbers[i]);

        Console.WriteLine($"Evens: {evenCount}, Odds: {oddCount}");
    }
}

