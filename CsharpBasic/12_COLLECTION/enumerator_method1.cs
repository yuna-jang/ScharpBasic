using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> c1 = new List<int>() { 1, 2, 3, 1, 2, 3, 1, 2, 3, 9 };

        // 값 검색
        Console.WriteLine(c1.IndexOf(3)); // 2
        Console.WriteLine(c1.IndexOf(3, 5)); // 인덱스 5부터 시작해서 3을 찾아주세요.
        Console.WriteLine(c1.IndexOf(3, 6, 2)); // 인덱스 6부터 시작해서 2개 요소만 보고 3을 찾아주세요.

        // 조건 검색 : 3의 배수 찾기
        Console.WriteLine(c1.FindIndex( n => n % 3 == 0 )); // Predicate(조건자)는 delegate

        // 조건을 만족하는 모든 요소 찾기
        List<int> c2 = c1.FindAll(n => n % 3 == 0);
        foreach (int n in c2)
            Console.WriteLine(n);
    }
}
