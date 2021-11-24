using System;

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = n1;

        n2 = 20;

        Console.WriteLine($"{n1}, {n2}"); // 10, 20

        int n3 = 10;
        ref int n4 = ref n3; // value type이어도 reference type으로 줄 수 있음
                            // 사이즈가 클 때 사용하면 유용
                            // 양쪽에 ref가 붙어야 함을 숙지

        n4 = 20;

        Console.WriteLine($"{n3}, {n4}"); // 20, 20
    }
}