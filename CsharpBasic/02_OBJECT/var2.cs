using System;

class Program
{
    public static void Main()
    {
        // C#에서 모든 것은 객체이다.
        // 10, "AA"  모두 객체이다.

        10.ToString(); // 10도 객체라서 메소드를 가짐

        int n = 10; // System.Int32 라는 struct


        // string과 String은 동일한 객체이다.
        string s1 = "AAA";

        String s2 = "AAA";
        System.String s3 = "AAA";
    }
}