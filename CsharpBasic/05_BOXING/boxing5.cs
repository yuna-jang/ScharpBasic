using System;

// CompareTo : IComparable, IComparable<T>
// Equals    : object, IEquatable<T>
/*
interface IEquatable<T>
{
    bool Equals(T other);
}
*/

struct Point : IEquatable<Point>
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
    public bool Equals(Point pt) // IEquatable 인터페이스 재정의 : override X
    {
        Console.WriteLine("Point");
        return x == pt.x && y == pt.y;
    }
    public override bool Equals(object obj) // object 클래스의 가상함수 재정의 : override O
    {
        Console.WriteLine("object");
        Point pt = (Point)obj;
        return x == pt.x && y == pt.y;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(1, 1);
        object p2 = new Point(1, 1);

        Console.WriteLine(p1.Equals(p2));
    }
}
