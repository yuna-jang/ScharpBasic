using System;

// 델리게이트에 메소드를 등록하는 방법

delegate void FUNC(int arg);

class Test
{
    public static void static_method(int arg) { }
    public void instance_method(int arg) { }
}
class Program
{
    public static void static_method(int arg) { }
    public void instance_method(int arg) { }

    public static void Main()
    {
        // 1. static method
        FUNC f1 = Test.static_method; // 클래스이름.메소드이름
        //FUNC f2 = Program.static_method;
        FUNC f2 = static_method; // 자신의 메소드인 경우 클래스 이름 생략가능

        // 2. instance method
        Test t = new Test();
        FUNC f3 = t.instance_method; // 객체.메소드이름

        Program p = new Program(); // 자신의 메소드이지만 instance method이므로 객체 생성 후 등록
        FUNC f4 = p.instance_method;

        p.foo();
    }

    public void foo()
    {
        FUNC f1 = this.instance_method;
        FUNC f2 = instance_method;
    }
}


