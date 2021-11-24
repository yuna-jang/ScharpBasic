using System;
using System.Collections.Generic;

// generic class
class Point<T>
{
    private T x;
    private T y;

    // C++ : T a = T()
    public Point( T xPos = default(T), T yPos = default(T)) // T타입의 디폴트 값을 쓰겠다.
                                                            // 수치값이면 0
    {
        x = xPos;
        y = yPos;
    }
}
class Program
{
    static void Main()
    {
        Point<int> pt = new Point<int>(1, 1);
        Point<double> pt2 = new Point<double>(1.1, 1.1);

        LinkedList<int> s = new LinkedList<int>();
    }
}
