using System;


class Program
{
    public static void Main()
    {
        int? n1 = 10;
        int a1 = 20;

        n1 = a1; //ok
        // a1 = n1; // error
        a1 = (int)n1;

        Console.WriteLine(a1);
    }
}