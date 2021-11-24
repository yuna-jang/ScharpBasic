using System;
using System.Collections.Generic;
using System.Linq;

// 컬렉션에 있는 요소 중 3의 배수만 얻고 싶다. 
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 1. 반복문과 조건문 사용
        foreach (int n in arr)
        {
            if (n % 3 == 0)
                Console.WriteLine(n);
        }

        // 2. LINQ 사용
        //IEnumerable<int> e = arr.Where(n => n % 3 == 0);
        var e = arr.Where(n => n % 3 == 0);

        foreach (int n in e)
            Console.WriteLine(n);

    }
}