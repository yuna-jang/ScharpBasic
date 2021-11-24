using System;
using System.IO;

class Program
{
    public static void Foo()
    {
        FileStream fs1 = new FileStream("a.txt", FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None);

        // 2. Dispose
        fs1.Dispose();
    }
    static void Main()
    {
        Foo();

        // 1. GC호출
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Finish Foo");

        // 같은 파일을 다시 여는데.. 
        // exception
        FileStream fs2 = new FileStream("a.txt", FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None);
    }
}