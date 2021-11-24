using System;

delegate void HANDLER();

class Button
{
    public event HANDLER handler = null; // event 키워드를 등록하면 += 연산만 가능하다.

    public void press() // 버튼이 눌리면 handler delegate가 실행됨
    {
        // ?.   ?[  -> Elvis Opearator
        //handler?(); //error. ?뒤에 .이나 [가 오는거 자체가 문법
        handler?.Invoke();
    }
}

// event 키워드를 사용하면 내부적으로는 이렇게 작동합니다.
/*
class Button
{
    private HANDLER handler = null;

    public void add_handler(HANDLER f) { handler += f; }
    public void remove_handler(HANDLER f) { handler -= f; }
    public void press()
    {
        // ?.   ?[
        //handler?();
        handler?.Invoke();
    }
}
*/
class Program
{
    static void Main()
    {
        Button btn = new Button();

        //btn.handler = F1;  // A라는 사람이 등록
        //btn.handler += F2; // B라는 사람이 등록
        //btn.handler = F2; // B라는 사람이 등록, 실수로 =을 사용

        btn.handler += F1; // btn.add_handler(F1)
        btn.handler += F2; // btn.add_handler(F2)
        //btn.handler = F1;

        btn.press();
    }
    public static void F1() { Console.WriteLine("F1"); }
    public static void F2() { Console.WriteLine("F2"); }
}

