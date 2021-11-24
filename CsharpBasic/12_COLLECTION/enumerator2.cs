using System;
using System.Collections.Generic;

// 모든 컬렉션은 IEnumerable<T> 인터페이스를 구현한다.

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        List<int> c1 = new List<int>(arr); 
        LinkedList<int> c2 = new LinkedList<int>(arr);

        // GetEnumerator() : 컬렉션의 요소를 가리키는 객체
        // - MoveNext(), Current, Reset() 멤버로 접근 가능

        IEnumerator<int> e1 = c1.GetEnumerator();
        IEnumerator<int> e2 = c2.GetEnumerator();

        //var e1 = c1.GetEnumerator();
        //var e2 = c2.GetEnumerator();

        e1.MoveNext(); // 최초 호출, 초기화
        Console.WriteLine(e1.Current); // 1

        e1.MoveNext(); // 다음 요소로 이동
        Console.WriteLine(e1.Current); // 2

        while (e2.MoveNext())
        {
            Console.WriteLine(e2.Current);
        }
    }

}
