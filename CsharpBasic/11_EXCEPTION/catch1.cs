using System;
using System.Net;

class Program
{
    static void Main()
    {
        try
        {
            WebClient wc = new WebClient();
            string s = wc.DownloadString("http://www.naver.com");
            Console.WriteLine(s);
        }

        catch (System.Net.WebException e)
        {
            Console.WriteLine("WebException"); // 특수 exception이 먼저 오고
        }
        catch (System.Exception e)
        {
            Console.WriteLine("모든 예외를 한번에 처리"); // exception은 항상 마지막 catch에 와야함
        }
    }
}
