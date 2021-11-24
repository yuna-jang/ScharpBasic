using System;
using System.Threading;

class Program
{
    public static void F1()
    {
        Thread t = Thread.CurrentThread; //자신의 쓰레드 얻을 수 있음

        Console.WriteLine("F1 Start");
        Thread.Sleep(1000);
        Console.WriteLine("F1 End");
    }

    public static void Main()
    {
        Thread t1 = new Thread(F1);
        t1.Start();

        Console.WriteLine($"{t1.ManagedThreadId}");     // ID
        Console.WriteLine($"{t1.Priority}");            // Normal
        Console.WriteLine($"{t1.IsThreadPoolThread}");  // false
        Console.WriteLine($"{t1.IsAlive}");             // true


        // Background 스레드 : 주스레드가 종료되면 강제 종료
        // Foreground 스레드 : 주스레드가 종료되어도 계속작업
        t1.IsBackground = true;

        t1.Join();                                
    }
}
