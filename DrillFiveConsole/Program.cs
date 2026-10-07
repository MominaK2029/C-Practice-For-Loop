using System;

class Program
{
    static void Main()
    {
        string original = "DotNet";
        string reversed = "";
        
        for(int i = 5; i>=0; i-- )
            Console.WriteLine(original[i]);

        Console.WriteLine($"Reversed: {reversed}");
    }
}

