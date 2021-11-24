using System;

class Program
{
    // generic method
    public static T Foo1<T>(T a) 
    {
        Type t = a.GetType();
        Console.WriteLine(t.FullName);
        return a;
    }

    static void Main()
    {
        Foo1<int>(3);
        Foo1<double>(3.4);
        Foo1(3);    // 타입생략 가능

        Foo2(1, 2);
        Foo2(1, 3.4);
        //Foo2(1, "AAA"); // error
        Foo2<object>(1, "AAA"); // ok
    }

    public static T Foo2<T>(T a, T b)
    {
        // a가 가리키는 실제 객체의 타입..
        Type t1 = a.GetType();
        Console.WriteLine(t1.FullName);

        Type t2 = typeof(T);
        Console.WriteLine(t2.FullName);
        return a;
    }
}
