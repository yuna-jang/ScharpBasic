using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.Concurrent;


class Program
{
    static void Main()
    {
        // 1. System.Object를 저장하는 컬렉션
        ArrayList c1 = new ArrayList();
        c1.Add(1);
        c1.Add(2);
        c1.Add("aa"); // c2에 add하려고 했는데 오타가 났다..

        // 2. 특정 타입만 저장하는 컬렉션
        StringCollection c2 = new StringCollection();
        c2.Add("aa");
        c2.Add(1); // error. 타입 안정성이 뛰어나다.

        // 3. Generic 컬렉션
        List<int> c3 = new List<int>();

        // 4. Thread safe 컬렉션 
        ConcurrentStack<int> c4 = new ConcurrentStack<int>();
    }
}