using System;
using System.Collections.Generic;

// 컬렉션 관련 인터페이스
// 1. IEnumerable<T> : GetEnumerator()
// 2. ICollection<T> : Count, Add(), Clear() 등
// 3. IList<T>       : this[] 등

class Program
{
    static void Main()
    {
        List<int> c1 = new List<int>();
        c1.Add(10);
        c1.Add(20);
        c1.Clear();
        int n1 = c1[0]; // IList 인터페이스에 있는 메서드(인덱서)

        SortedSet<int> c2 = new SortedSet<int>();
        c2.Add(10);
        c2.Add(20);
        c2.Clear();
        int n2 = c2[0]; //error
    }
}