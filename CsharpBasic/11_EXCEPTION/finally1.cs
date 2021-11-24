using System;

class Program
{
    static void Main()
    {
        try
        {
            throw new Exception();
        }
        // catch : 예외 발생시 실행
        catch (Exception e)
        {
            Console.WriteLine("catch");
        }
        // finally : try 블록을 벗어날 때 항상 실행
        finally
        {
            Console.WriteLine("finally");
        }
    }
}