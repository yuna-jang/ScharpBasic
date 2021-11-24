using System;
using System.Threading;

class Program
{
    public static void Foo()
    {
        Console.WriteLine("Foo Start");
        Thread.Sleep(2000);
        Console.WriteLine("Foo End");
    }

    public static void Main()
    {
        // Foo(); // 주 스레드가 호출

        Thread t = new Thread(Program.Foo);
        t.Start();

        Console.WriteLine("Main Start");
        Thread.Sleep(2000);
        Console.WriteLine("Main End");
    }
}
