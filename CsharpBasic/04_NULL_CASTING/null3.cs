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
        // null coalescing operator (널 접합 연산자)
        // 혹시 좌변이 null이면 우변을 꺼냄
        Car c = CreateCar(300) ?? new Car();


        // nullable type으로부터 안전하게 값을 꺼낼 떄
        int? n1 = 10;
        int n2 = n1 ?? 0; 
    }   
}