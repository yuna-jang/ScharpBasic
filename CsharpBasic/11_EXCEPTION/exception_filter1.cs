using System;
using System.Net;

class Program
{
    static void Main()
    {
        WebClient wc = new WebClient();
        try
        {
            string s = wc.DownloadString("http://wwww.naver.com");
        }

        //catch (WebException e)
        //{
        //    if (e.Status == WebExceptionStatus.NameResolutionFailure)
        //        Console.WriteLine("URL이 잘못되었습니다.");
        //    else
        //        Console.WriteLine("다른 문제");
        //}

        // 아래와 같은 문법도 있습니다.
        catch (WebException e) when (e.Status == WebExceptionStatus.NameResolutionFailure)
        {
            Console.WriteLine("URL이 잘못되었습니다.");
        }

        catch (Exception e)
        {

        }
        wc.Dispose();
    }
}