using System;

class People
{
    private int age = 0; // private은 소문자로

    public int Age      // property는 대문자로
    {
        get { return age; } 
        set { age = value; }
    }
       

    //public int get_age() { return age; }
    //public void set_age(int value) { age = value;  }
}

class Program
{
    static void Main()
    {
        People p = new People();

        p.Age = 10; // set {}
        int n2 = p.Age; // get{}

        //p.set_age(10);
        //int n = p.get_age();

    }
}





