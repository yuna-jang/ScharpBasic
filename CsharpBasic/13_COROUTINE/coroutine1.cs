using System;
using System.Collections;
using System.Collections.Generic;


class Program
{
    // SUBROUTINE
    public static int Foo()
    {
        Console.WriteLine("1"); return 10;
        Console.WriteLine("2"); return 20;
        Console.WriteLine("3"); return 30;
        Console.WriteLine("4"); return 40;
        Console.WriteLine("5"); return 50;
    }

    // COROUTINE - 열거자 인터페이스 타입으로 반환하는 경우
    public static IEnumerator<int> Goo()
    {
        Console.WriteLine("1"); yield return 10;
        Console.WriteLine("2"); yield return 20;
        Console.WriteLine("3"); yield return 30;
        Console.WriteLine("4"); yield return 40;
        Console.WriteLine("5"); yield return 50;
    }

    // COROUTINE - 컬렉션 인터페이스 타입으로 반환하는 경우 / LINQ 방식
    public static IEnumerable<int> Hoo()
    {
        Console.WriteLine("1"); yield return 10;
        Console.WriteLine("2"); yield return 20;
        Console.WriteLine("3"); yield return 30;
        Console.WriteLine("4"); yield return 40;
        Console.WriteLine("5"); yield return 50;
    }

    static void Main()
    {
        // 코루틴 열거자 인터페이스 메서드 호출
        IEnumerator<int> e = Goo();

        e.MoveNext();
        int ret1 = e.Current;
        e.MoveNext();
        int ret2 = e.Current;

        Console.WriteLine($"{ret1}, {ret2}");

        // 코루틴 컬렉션 인터페이스 메서드 호출
        IEnumerable<int> c = Hoo();
        IEnumerator<int> e2 = c.GetEnumerator();

        e2.MoveNext();
        int ret3 = e2.Current;
        e2.MoveNext();
        int ret4 = e2.Current;

        Console.WriteLine($"{ret3}, {ret4}");


        // 일반 메서드 호출
        int n1 = Foo();
        int n2 = Foo();
        Console.WriteLine($"{n1}, {n2}");
    }
}