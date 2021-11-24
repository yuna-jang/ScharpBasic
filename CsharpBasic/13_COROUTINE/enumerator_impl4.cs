using System;
using System.Collections;
using System.Collections.Generic;

// 코루틴을 사용한 열거자 만들기
// - 별도의 열거자 타입이 필요없다.

class Node
{
    public int data;
    public Node next;

    public Node(int d, Node n) { data = d; next = n; }
}

class IntLinkedList : IEnumerable
{
    public Node head = null;

    public void AddFirst(int data)
    {
        head = new Node(data, head);
    }

    public IEnumerator GetEnumerator()
    {
        Node current = head;
        while(current != null)
        {
            yield return current.data;
            current = current.next;
        }
    }
}

class Program
{
    static void Main()
    {
        IntLinkedList st = new IntLinkedList();

        st.AddFirst(10);
        st.AddFirst(20);
        st.AddFirst(30);
        st.AddFirst(40);
        st.AddFirst(50);

        IEnumerator e = st.GetEnumerator();

        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
    }
}