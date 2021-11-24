using System;

class Program
{
    //public static int Sum(int a, int b)
    //{
    //    return a + b;
    //}

    public static int Sum(params int[] arr) //params 키워드를 사용하면
    {
        int s = 0;
        foreach (int n in arr)
            s += n;
        return s;
    }

    public static void Main()
    {
        int s1 = Sum(1,2);                  // 호출할 때 배열을 넘기지 않아도 된다.
        int s2 = Sum(1,2,3);

        int s3 = Sum(new int[] { 1, 2 });
        int s4 = Sum(new int[] { 1, 2, 3 });

        Console.WriteLine($"{s1}, {s2}");
    }
}