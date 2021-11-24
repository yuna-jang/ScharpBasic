using System;
using System.Collections.Generic;

class MyCompare : IComparer<int>
{
    public int Compare(int a, int b) { return (a < b ? 1 : ((a == b) ? 0 : -1)); }
}

class Program
{
    static void Main()
    {
        List<int> c1 = new List<int>() { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
        
        c1.Sort();

        // Sort(Comparison<T>) : delegate
        c1.Sort( (a,b) => ( a < b ? 1 : ((a == b) ? 0 : -1)) ); // 내림차순

        // Sort(Icomparer<T>) : interface
        // c1.Sort(객체);
        c1.Sort(new MyCompare());
        

        foreach(int n in c1)
        {
            Console.WriteLine(n);
        }
    }
}
