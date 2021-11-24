using System;

class Base
{
    public virtual void Foo()
    {
        Console.WriteLine("Base foo");
    }
}

class Derived : Base
{
    public override void Foo()
    {
        Console.WriteLine("Derived foo");
    }
}

class Program
{
    static void Main()
    {
        Base b = new Derived(); // 참조 타입 : Base, 객체 타입 : Derived
        b.Foo(); // Derived Foo
                // virtual - override 키워드를 통해 가상함수를 정의.
                // 객체 타입으로 함수를 호출한다.
    }
}
