using System;
using System.Threading;

class Program
{
    public static void F1() { }
    public static void F2(object obj) { }
    public static void F3(string s1) { }
    public static void F4(string s1, int n) { }


    public static void Main()
    {
        Thread t1 = new Thread(F1);
        t1.Start();

        Thread t2 = new Thread(F2);
        t2.Start("hello");
        
        // 인자의 타입이 object가 아니거나, 인자의 개수가 여러 개인 경우 => 람다표현식 사용
        Thread t3 = new Thread( () => F3("hello") );
        t3.Start();

        Thread t4 = new Thread( () => F4("hello", 1) );
        t4.Start();
    }
}
