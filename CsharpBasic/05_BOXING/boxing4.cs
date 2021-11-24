using System;

// 비교 하는 메소드의 이름을 약속하자.
/*
// C# 1.0
interface IComparable
{
    int CompareTo(object other);
}
*/

/*
// C# 2.0 : generic interface
interface IComparable<T>
{
    int CompareTo(T other);
}*/

// IComparable<T>, IComparable를 모두 구현하는 것이 좋다.
struct Point : IComparable<Point>, IComparable
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    public int CompareTo(Point pt) // Point type으로 받을
    {
        if (x > pt.x) return 1;
        else if (x == pt.x) return 0;
        return -1;
    }

    public int CompareTo(object other)
    {
        //Point pt = other as Point;
        Point pt = (Point)other;  // 힙에 있던 other가 캐스팅되면서 스택으로 unboxing됨

        if (x > pt.x) return 1;
        else if (x == pt.x) return 0;
        return -1;
    }

}
class Program
{
    static void Main()
    {
        string s;
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        Console.WriteLine(p1.CompareTo(p2)); // value type인 p2는 스택에 있음
                                             // 함수의 인자로 넘기면서 힙으로 boxing됨(복사됨)
    }
}
