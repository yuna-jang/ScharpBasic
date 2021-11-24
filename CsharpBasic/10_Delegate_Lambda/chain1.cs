using System;

class Test
{
    public static int Method1() 
    {
        Console.WriteLine("Method1"); 
        return 1; 
    }
    public static int Method2() 
    {
        Console.WriteLine("Method2"); 
        return 2; 
    }
    public static int Method3() 
    {
        Console.WriteLine("Method3"); 
        return 3; 
    }
    public static int Method4()
    {
        Console.WriteLine("Method4"); 
        return 4; 
    }
}

delegate int FUNC();

class Program
{
    public static void Main()
    {
        FUNC f1 = Test.Method1;
        FUNC f2 = Test.Method2;
        FUNC f3 = Test.Method3;

        // 1. Delegate.Combine()
        FUNC f4 = (FUNC)Delegate.Combine(f1, f2); // 메소드가 2번 호출됨
        FUNC f4_ = (FUNC)Delegate.Combine(f1, f2, f3);
        FUNC f4__ = (FUNC)Delegate.Combine(f1, Test.Method4); //error
        f4();

        
        // 2. +, -, += , -=
        FUNC f5 = f1 + f2 + f3;
        FUNC f5_ = f1 + Test.Method4 + f2;
        f5_(); // 1 4 2


        // 3. delegate는 reference type
        // delegate는 immutable하다.
        FUNC f6 = Test.Method1;
        FUNC f7 = f6;

        Console.WriteLine(f6 == f7); // true

        f6 += Test.Method2; // f6 = f6 + Test.Method2;
                            // f6 = new FUNC(  ... )
                            // f6에는 새로운 delegate가 생성되어 가리키는 것..
        Console.WriteLine(f6 == f7); // false

      
        f6(); // 2개 호출
        Console.WriteLine("----");
        f7(); // 1개

    }
}


