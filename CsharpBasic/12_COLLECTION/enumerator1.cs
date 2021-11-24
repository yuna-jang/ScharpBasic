using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        List<int> c1 = new List<int>(arr); // 연속된 메모리
        LinkedList<int> c2 = new LinkedList<int>(arr); // 비연속 메모리
                                                       // 인덱서 불가능
        // 인덱서를 제공하는 자료구조와 제공하지 않는 자료구조..
        // -> 반복자(iterator) 패턴 : 컬렉션의 내부 구조에 상관없이 동일한 방식의 요소를 열거하는 디자인 패턴
        // -> C#에서는 열거자(enumerator)라는 용어 사용

        for (int i=0; i<c1.Count; i++)
        {
            Console.WriteLine(c1[i]);
        }
    }

}
