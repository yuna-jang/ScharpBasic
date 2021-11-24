using System;

class A { }
class B { }
class C { }

class Program
{    
    static void Main()
    {
        A a1 = new A();
        B a1 = new B();
        C a1 = new C();

        Console.WriteLine(GC.GetGeneration(a1)); // 0세대
        GC.Collect(0); // 0세대만 GC

        b1 = null;

        Console.WriteLine(GC.GetGeneration(a1)); // 1세대
        GC.Collect(0); // 0세대만 GC
        Console.WriteLine(GC.GetGeneration(a1)); // 1세대, 0세대만 GC했으니까

        GC.Collect(1); // 0세대만 GC
        Console.WriteLine(GC.GetGeneration(a1)); // 2세대

        a1 = null; // 2세대에 있는 a1은 null인데도 수집되는데 오래 걸림.. 거의 메모리 가득찰 때 수집됨

        // ** 사용자가 GC를 마음대로 돌리는 것은 오히려 안좋을 수 있다. **

        A a2 = new A();
 
    }
}