using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5};

        IEnumerable<int> e = arr.MySelect(n => n * 10);

        IEnumerator<int> p = e.GetEnumerator();

        while (p.MoveNext())
        {
            Console.WriteLine(p.Current); // 0, 20, 30, 40, 50
        }
    }
}

// 확장메서드
public static class MyLinq
{
    public static IEnumerable<T> MySelect<T>(this IEnumerable<T> arr, Func<T, T> predicate)
    {
        foreach (T n in arr)
        {
            yield return predicate(n);
        }
    }
}