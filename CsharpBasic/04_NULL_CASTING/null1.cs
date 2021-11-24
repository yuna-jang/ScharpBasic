using System;


class Program
{
    public static void Main()
    {
        // string : reference type
        string s1 = "Hello";
        string s2 = null; // 객체가 없음

        // int : value type
        //int n1 = 10;
        //int n2 = ?; // 값이 없음을 나타내고 싶다.

        Nullable<int> n1 = 10;
        Nullable<int> n2 = null;
        int? n3 = null; // 물음표(?)를 통해 간단히 표현 가능

        if (n2 == null) { }
    }
}