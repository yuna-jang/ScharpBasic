using System;


struct SPoint
{
    public int x;
    public int y;
    public SPoint(int xPos, int yPos)
    {
        x = xPos; y = yPos;
    }
}

class CPoint
{
    public int x;
    public int y;
    public CPoint(int xPos, int yPos)
    {
        x = xPos; y = yPos;
    }
}

class Program
{
    public static void Main()
    {
        SPoint sp1 = new SPoint(1, 1);
        CPoint cp1 = new CPoint(1, 2);

        SPoint sp2 = sp1; // deep copy. 객체가 2개
        CPoint cp2 = cp1; // shallow copy. 객체가 1개, 참조가 2개

        sp2.x = 10;
        Console.WriteLine(sp1.x); // 1

        cp2.x = 10;
        Console.WriteLine(cp1.x); // 10
    }
}