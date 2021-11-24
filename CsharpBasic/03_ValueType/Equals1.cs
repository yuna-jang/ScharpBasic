using System;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    // 오버라이드
    public override bool Equals(object obj)
    {
        Point pt = (Point)obj;
        return pt.x == x && pt.y == y;
    }

    // == 연산자 재정의
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.x == p2.x && p1.y == p2.y;
    }
    public static bool operator !=(Point p1, Point p2)
    {
        return p1.x != p2.x || p1.y != p2.y;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = p1;
        Point p3 = new Point(1, 1);

        // 방법1. == 연산자 사용
        Console.WriteLine(p1 == p2); // true
        Console.WriteLine(p1 == p3); // false


        // 방법2. Equals() 가상 메서드 사용
        // 기본동작 : 참조가 동일한가?
        Console.WriteLine(p1.Equals(p2)); // true
        Console.WriteLine(p1.Equals(p3)); // false

        // 방법3. Equals() 가상 메서드 재정의 (override)
        Console.WriteLine(p1.Equals(p2)); // true
        Console.WriteLine(p1.Equals(p3)); // true

        // 방법4. == 연산자 재정의
        // 추천되지 않음
        // -> object 타입으로 캐스팅 되었을 때 문제
        Console.WriteLine(p1 == p2); // true
        Console.WriteLine(p1 == p3); // true
    }
}