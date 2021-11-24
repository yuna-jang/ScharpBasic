using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static void F1()
    {
        Console.WriteLine("F1 Start");
        Thread.Sleep(1000);
        Console.WriteLine("F1 End");
    }

    public static void F2(object obj)
    {
        Console.WriteLine("F2 Start");
        Thread.Sleep(1000);
        Console.WriteLine("F2 End");
    }

    public static int F2()
    {
        Console.WriteLine("F2 Start");
        Thread.Sleep(1000);
        Console.WriteLine("F2 End");

        return 100;
    }

    public static void Main()
    {
        // F1
        Task t1 = Task.Run(F1); // 인자없는 메서드만 받음

        // F2
        Task t2 = Task.Run(() => F2("hello")); // 람다식으로 인자넘김

        Console.WriteLine(t.IsCompleted); //false
        t2.Wait();
        Console.WriteLine(t.IsCompleted); //true

        // F3, 반환값
        Task<int> t3 = Task.Run(() => F3("hello")); // 람다식으로 인자넘김
        Console.WriteLine(t3.Result); // 결과 나올 때까지 대기 후 출력

        
    }
}
