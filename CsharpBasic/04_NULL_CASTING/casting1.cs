using System;

class Program
{
    static void Main()
    {
        int n = 3;
        double d = 3.8;

        d = n; // int => double. 데이타 손실 없음.
        //n = d; // double=> int.  데이타 손실 발생.
        n = (int)d;

        Console.WriteLine(n);
    }
}