using System;

class Program
{
    public static int Add(int a, int b) { return a + b; }

    static void Main()
    {
        Func<int, int, int> f1 = Add;

        Func<int, int, int> f2 = (int a, int b) => { return a + b; };

        Func<int, int, int> f3 = ( a,  b) => { return a + b; }; // 람다표현식에서 파라미터에 타입 생략 가능

        Func<int, int, int> f4 = (a, b) => a + b;               // 반환값의 타입도 생략 가능

        Func<int, int> f5 = (a) => a + a;

        Func<int, int> f6 = a => a + a; // 인자가 하나일 때에는 괄호 제거 가능
                                        // Linq

    }

}
