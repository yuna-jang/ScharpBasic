using System;

class Program
{
    public static void Main()
    {
        // int n = new int();

        // 1. int
        int n1 = 1;
        int n2 = n1;

        n2 = 10;
        Console.WriteLine(n1); // 1
        // n2는 n1의 객체 복사
        // int는 value type입니다.



        // 2. array
        //System.Array a;
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;

        arr2[0] = 10;

        Console.WriteLine(arr1[0]); // 10
        // arr2는 arr1의 참조 복사
        // System.Array는 reference type입니다.


        
        // 3. string
        string s1 = "Hello";
        string s2 = s1;

        Console.WriteLine(s1 == s2); // true

        s2 = "world"; // s2 = new string("world")

        Console.WriteLine(s1 == s2); // false
        Console.WriteLine(s1); // "world"
        // s2는 s1의 참조 복사
        // 그런데 System.String은 immutable 객체 이므로 
        // s2 변경시 새로운 객체를 생성하여 가리키게 됩니다.
    }
}