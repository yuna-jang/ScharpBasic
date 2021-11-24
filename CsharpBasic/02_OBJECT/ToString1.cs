using System;

class Point
{
    private int xPos = 0;
    private int yPos = 0;

    public Point(int x, int y)
    {
        xPos = x; yPos = y;
    }

    public override string ToString()
    {
        return string.Format($"{xPos}, {yPos}");        
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);
        
        // ToString() : 객체를 문자열로 변경하는 메소드
        // 기본 구현 : "타입의 이름을 문자열로 반환"
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
    }
}
