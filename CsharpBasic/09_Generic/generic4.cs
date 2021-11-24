using System;

class Program
{
    /*
    public static int Max(int a, int b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }
    public static string Max(string a, string b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }
    */


    // 1. object
    // value type인 경우 boxing/unboxing
    // 반환 받을 때 캐스팅 필요
    /*
    public static object Max(object a, object b)
    {
        IComparable c1 = a as IComparable;
        IComparable c2 = b as IComparable;

        return c1.CompareTo(c2) < 0 ? b : a;
    }
    */

    // 2. IComparable
    // 모든 인터페이스 : reference type
    // value type인 경우 boxing/unboxing
    // 반환 받을 때 캐스팅 필요
    /*
    public static object Max(IComparable a, IComparable b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }
    */

    // 3. generic
    // boxing/unboxing 현상이 없음
    public static T Max<T>(T a, T b) where T : IComparable // Icomparable 인터페이스를 구현한 T만 올 수 있다는 뜻
                                                                  // int, string 클래스에 가보면 Icomparable 인터페이스 상속해서 
                                                                  // 구현해둔 것을 알 수 있음
    {
        // 기본적으로 object로 할 수 있는 연산만 가능 -> CompareTo 불가
        // a.Equals(b); // ok.. object 멤버

        // Generic Constraint을 쓰면 CompareTo 가능
        return a.CompareTo(b) < 0 ? b : a;
    }


    static void Main()
    {
        Console.WriteLine(Max(10, 20));
        Console.WriteLine(Max("A", "B"));
        Console.WriteLine(Max(new Car(), new Car()));

        int n = Max(10, 20);
    }
}

class Car : IComparable
{
    public int CompareTo(object t)
    {
        return 0;
    }
}


