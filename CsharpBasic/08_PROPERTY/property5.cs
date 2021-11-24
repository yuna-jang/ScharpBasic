using System;

class People
{
    private int age = 0;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int Age { get; set; } = 0; // 자동 속성 (automatic property)
                                        // backing field, get, set의 구현을 자동으로 제공
    

    // public int age = 0;
    // public int Age { };
}

class Program
{
    static void Main()
    {
        People p = new People();

        //p.age = -10;

        p.Age = 10;
        Console.WriteLine(p.Age);
    }
}






