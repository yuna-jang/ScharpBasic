using System;

class Program
{
    public static void f1(params object[] arr)      // object 타입으로 받으면 여러 타입을 한번에 가능
    {
        foreach (object o in arr)
            Console.WriteLine(o.ToString());
    }

    public static void Main()
    {
        f1(1, 3.4, "Hello");
        f2(1, 2, 3, 4);
        //       f3(1, 2, 3, 4);

        int s1 = Sum(1, 2);
        int s2 = Sum(1, 2, 3,4); // new int[]{1,2,3}
    }

    public static void f2(int a, params int[] arr) { }
    //    public static void f3(params int[] arr, int a) { } // params 매개변수 뒤에 변수를 받을 수 없다.

    public static int Sum(int a, int b)
    {
        Console.WriteLine("int, int");
        return a + b;
    }
    public static int Sum(int a, int b, int c)
    {
        Console.WriteLine("int, int, int");
        return a + b + c;
    }

    public static int Sum(params int[] arr)
    {
        Console.WriteLine("params");
        int s = 0;
        foreach (int n in arr)
            s += n;
        return s;
    }
}