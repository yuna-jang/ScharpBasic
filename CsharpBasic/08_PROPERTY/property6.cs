using System;

class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        // 객체를 생성할 때 property를 사용해서 초기화
        Point p2 = new Point() { X = 10, Y = 20 };
        Point p3 = new Point   { X = 10, Y = 20 };
        Point p4 = new Point { Y = 20 };


        // 무명 타입 (Anonymous type)
        var p = new { Name = "kim", Age = 20 }; // new하고 타입이 없음
                                                // 읽기 전용!
                                                // LINQ 등에서 많이 사용

        Console.WriteLine(p.Name); // "kim"
        //p.Name = "lee"; // error, 쓰기 불가

        Type t = p.GetType();
        Console.WriteLine(t.FullName);  // Anonymous type

    }
}






