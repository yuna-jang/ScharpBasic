using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static void Foo()
    {
        Console.WriteLine($"Foo : {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(3000);
    }

    public static void Main()
    {
        //Thread t = new Thread(Program.Foo);
        //t.Start();

        Task t = Task.Run(Program.Foo); // 스레드풀 

        Console.ReadKey();
    }
}
