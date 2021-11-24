using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3 };

        // value or reference 조사
        // GetType()
        // isValueType 속성

        Type t = arr.GetType();
        Console.WriteLine(t.IsValueType);
    }
}