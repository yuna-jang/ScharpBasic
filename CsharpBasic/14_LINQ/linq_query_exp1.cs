using System;
using System.Collections.Generic;
using System.Linq;

// Fluent Syntax vs Query Syntax
class Program
{
    static void Main()
    {
        string[] arr = { "kim", "lee", "park", "choi", "robert"};

        // Fluent Syntax
        var e = arr.Where(s => s.Contatins("o"))
                    .OrderBy(s => s.Length)     // 길이순 정렬
                    .Select(s => s.ToUpper());  // 대문자로 전환

        // Query Syntax
        var e2 = from s in arr
                 where s.Contains("o")
                 orderby s.Length
                 select s.ToUpper();

        foreach(var n in e)
        {
            Console.WriteLine(n);
        }
    }
}