using System;

class Car
{

}

class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();

        // 정의하지 않은 메소드가 있는 이유
        // 모든 타입은 "System.Object"로부터 파생된다.
        c.ToString();

        // System.Object
        // 1. 2개의 static method : 타입에서 호출
        // 2. 3개의 virtual instance method
        // 3. 1개의 non-virtual instance method
        // 4. 1개의 protected instance method
    }
}