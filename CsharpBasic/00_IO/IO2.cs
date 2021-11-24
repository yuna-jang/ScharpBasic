using System;
using static System.Console;

class Program
{
    static void Main()
    {
        int n = 10;
        double d = 3.4;

        Console.WriteLine(n);

        Console.WriteLine("n={0}, d={1}", n, d);
        Console.WriteLine($"n={n}, d={d}");

        Console.WriteLine("C:\\AAA\\BBB\\a.txt");
        Console.WriteLine(@"C:\AAA\BBB\a.txt");

    }
}

