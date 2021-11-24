using System;
using System.Net;

class Server
{
    public void Connect()
    {
        throw new TimeoutException();
    }
}
class Program
{
    static void Foo()
    {
        int retryCount = 0;
        bool bSuccess = false;

        Server wc = new Server();

        while (bSuccess == false)
        {
            try
            {
                wc.Connect();
                bSuccess = true;
            }
            catch (TimeoutException e) when (++retryCount<4) // catch문은 성능이 좀 떨어지므로 이러한 예외필터 적용하면 좋음
            {
                Console.WriteLine("One more try.");
            }
            /*
            catch (TimeoutException e)
            {
                if (++retryCount < 4)
                    Console.WriteLine("One more try.");
                else
                    throw;
            }
            */
        }
    }

    static void Main()
    {
        try
        {
            Foo();
        }
        catch (Exception e)
        {
            Console.WriteLine("Main 예외처리");
        }
    }
}