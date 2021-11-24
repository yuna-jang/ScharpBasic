using System;

interface iList
{
    void Clear();
}

// 모든 컬렉션은 반드시 iList를 구현해야 한다.
class Stack : iList
{
    public void Clear() { }
}

class Queue : iList
{
    public void Clear() { }
}

class Program
{
    static void Main()
    {
            
    }
}