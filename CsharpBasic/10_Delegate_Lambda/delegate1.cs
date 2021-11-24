using System;

delegate void FUNC(int arg); // FUNC는 "타입"입니다.
// 타입 모양   : void FUNC(int arg)
// 메서드 모양 : void foo(int arg)

class Program
{
    static void Main()
    {
        int    n = 10; 
        double d = 3.4;   
        string s = "hello";

        FUNC f = foo; // FUNC 타입 객체 f에 함수 foo를 담습니다.
        f(10); // foo(10)
        f.Invoke(10); // foo(10)
    }

    public static void foo(int arg)
    {
        Console.WriteLine($"foo : {arg}");
    }
}

