using System;

class Program
{
    static void Main()
    {
        int size = 5;

        //outer
        for (int i = 1; i <= 2; ++i)
        {
            Console.WriteLine("Outer: " + i);

        //inner
            for (int j = 1; j <= 3; j++) 
            {
            Console.WriteLine(" Inner: " + j);
            }

        }
    }
}

