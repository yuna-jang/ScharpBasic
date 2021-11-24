using System;

// 람다 표현식
class Program
{
    public static void foo(Func<int, int, int> f)
    {
        int s = f(1, 2);
        Console.WriteLine(s);
    }
    static void Main(string[] args)
    {
        foo( Add );

        foo( (int a, int b) => { return a - b; }   ); // 람다표현식으로 메소드 대체

    }
    public static int Add(int a, int b) { return a + b; }
    
}
