using System;
using System.Collections.Generic;

// LINQ (Language INtegrated Qeury)

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        foreach (int n in arr)      // 내부적으로 arr.GetEnumerator()
            Console.WriteLine(n);

        IEnumerable<int> col = arr;

        foreach (int n in col)
            Console.WriteLine(n);
    }
}