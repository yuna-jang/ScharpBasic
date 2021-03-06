using System;

// 1. 배열의 기본 모양
class Program
{
    static void Main()
    {
        int[] arr1; // 스택에 참조변수만 선언한 것.
        int[] arr2 = new int[5]; // 힙
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 }; // 힙
        int[] arr4 = new int[] { 1, 2, 3, 4, 5 }; // 힙
        int[] arr5 = { 1, 2, 3, 4, 5 }; // 힙

        Type t = arr5.GetType();
        Console.WriteLine(t.FullName);
        Console.WriteLine(t.BaseType.FullName);
        Console.WriteLine(t.BaseType.BaseType.FullName);
        System.Array a;
        
        Console.WriteLine(arr5.Length);         // 5
        Console.WriteLine(arr5.GetLength(0));   // 5
        Console.WriteLine(arr5.GetValue(3));    // arr5[3] = 4
        Console.WriteLine(arr5.GetLowerBound(0));// 0
        Console.WriteLine(arr5.GetUpperBound(0));// 4


        int[] arr6 = { 1, 2, 3, 4, 5 };
        int[] arr7 = arr6;
        int[] arr8 = (int[])arr6.Clone(); // arr6가 가리키는 배열의 복사본을 힙에 생성

        Console.WriteLine(arr6 == arr7);   // true            
        Console.WriteLine(arr6 == arr8);   // false
    }
}

