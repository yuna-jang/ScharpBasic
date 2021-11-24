using System;

class Program
{
    static void Main()
    {
        //ConsoleKeyInfo cki = Console.ReadKey();
        ConsoleKeyInfo cki = Console.ReadKey(true); // no echo

        Console.WriteLine(cki.KeyChar);

    }
}

