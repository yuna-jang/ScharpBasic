using System;

class Base
{
    public void Foo()
    {
        Console.WriteLine("Base foo");
    }
}

class Derived : Base
{
    public new void Foo()
    {
        Console.WriteLine("Derived foo");
    }
}

class Program
{
    static void Main()
    {
        Base b1 = new Base();
        b1.Foo(); // Base Foo

        Derived d1 = new Derived();
        d1.Foo(); // Derived Foo

        Base b2 = new Derived(); // 참조 타입 : Base, 객체 타입 : Derived
        b2.Foo(); // Base Foo
                    // 참조 타입으로 호출한다. (C#, C++)
                    // 객체 타입으로 호출하려면? virtual
    }
}
