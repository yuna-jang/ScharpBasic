using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5};

        IEnumerable<int> e = arr.Select(n => n * 10);

        arr[0] = 0;

        foreach (int n in e)
            Console.WriteLine(n); // 0, 20, 30, 40, 50
                                  // 지연된 실행
        
    }
}