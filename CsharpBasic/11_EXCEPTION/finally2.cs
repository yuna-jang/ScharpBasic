using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileStream fs = null;

        try
        {
            fs = new FileStream("a.txt", FileMode.CreateNew);
            //fs.Dispose(); // 성공시에도 Dispose
        }
        catch (Exception e)
        {
            //fs.Dispose(); // 실패시에도 Dispose
        }
        finally
        {
            if (fs != null)
                fs.Dispose();
        }

        // -------------------- using 키워드를 이용
        // 위 코드와 완전히 동일한 문법

        using (fs = new FileStream("a.txt", FileMode.CreateNew))
        {
            try
            {
                // ......
            }
            catch (Exception e)
            {

            }
        }
    }
};
// 참고 : C#에서의 자원관리
// - 파일, 네트워크 등의 자원을 관리하는 객체 : Dispose() 메서드를 호출해서 명시적으로 자원을 해지해야 한다.