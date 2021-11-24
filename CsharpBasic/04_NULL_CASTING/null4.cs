using System;

class Car
{
    public int color = 10;
    public void Go()
    {
        Console.WriteLine("GO.");
    }
}
class Program
{
    public static Car CreateCar(int speed)
    {
        if (speed > 200)
            return null;
        return new Car();
    }

    public static void Main()
    {
        Car c = CreateCar(300);

        /*if (c != null)
        {
            c.Go();
        }*/

        // Elvis operator
        // 1. ?. 
        // 좌변이 null이면 더 이상 실행하지 않고 null로 반환
        // c가 null이 아니면 Go()
        c?.Go();

        //int n = c?.color; // 우변이 null이면 int가 받지 못하므로..
        int? n = c?.color; // ok


        // 2. ?[
        int[] arr = { 1, 2, 3 };

        //int n2 = arr[0]; // 우변이 null이면 int가 받지 못하므로..
        int? n2 = arr?[0]; // ok
    }
   
}