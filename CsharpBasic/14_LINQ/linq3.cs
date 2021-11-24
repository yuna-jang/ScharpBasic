using System;
using System.Collections.Generic;
using System.Linq;

// 컬렉션에 있는 요소 중 3의 배수만 얻고 싶다. 
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 배열에서 홀수만 얻고 싶다.
        IEnumerable<int> e = arr.Where(n => n % 2 == 1)
                                .Select(n => n * 10)
                                .Skip(3);

        foreach (int n in e)
            Console.WriteLine(n);

    }
}