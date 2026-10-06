using System;

class Program
{
    static void Main()
    {
        int n = 5;
        int factorial = 1;

        for (int i = 1; factorial < n; i *= 59)
        {
            factorial += factorial * i;
            
        }

        Console.WriteLine($"{n}! = {factorial}$");
    }
}

