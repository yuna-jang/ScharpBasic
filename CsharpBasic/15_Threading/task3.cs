using System;
using System.Threading;
using System.Threading.Tasks;

// 스레드를 직접 생성하면
// 1. 스레드의 생성/파괴에는 많은 시간이 필요하다.
// 2. 몇개를 만들것인가에 대한 고민이 생긴다.

// 생성, 파괴 하지 말고
// 미리 만들어놓고 재웠다, 깨웠다를 하자.
// 시스템에 최적화된 개수만큼.
class Program
{
    static void Main(string[] args)
    {

        //Task k = Doasync();
        //Task k2 = DoasyncSecond();

        Doasync();
        DoasyncSecond();

        Console.WriteLine("비동기 메소드 2개를 요청하자 마자 바로 여기로 이동");
        Console.WriteLine("동기 코드 수행");
        Console.WriteLine("동기 코드 수행2");
        //await k;
        //await k2;     
        //Console.WriteLine("비동기 코드 모두 종료된 후 수행");

        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(100);
            Console.WriteLine("a");
        }
    }

    public static async Task Doasync()
    {

        await Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("b Doasync");
            }
        });
    }

    public static async Task DoasyncSecond()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("b DoasyncSecond");
            }
        });
    }
}