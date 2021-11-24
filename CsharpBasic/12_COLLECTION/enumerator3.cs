using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        List<int> c1 = new List<int>(arr); 
        
        // 모든 컬렉션은 foreach를 사용해서 열거할 수 있다.
        // 내부적으로 enumerator를 사용한 것
        foreach(int n in c1)
        {
            Console.WriteLine(n);
        }
    }
}
