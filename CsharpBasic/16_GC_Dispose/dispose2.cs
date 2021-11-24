using System;
using System.IO;

class Car
{
    public void Go() { Console.WriteLine("Car Go"); }

    // finalizer
    ~Car() { Console.WriteLine("~Car"); }
}
class Program
{
    static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

        c2 = null;
        GC.Collect(); 
        GC.WaitForPendingFinalizers(); // c2가 소멸될 때까지 대기

        c1.Go();
    }
}