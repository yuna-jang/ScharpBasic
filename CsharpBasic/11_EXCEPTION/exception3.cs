using System;

// 오류전달방식
public static class FileManager
{
    public static bool CopyFile(string srcFileName, string dstFileName, out int len)
    {
        // ......
        len = 100;
        return false;
    }
}

class Program
{
    static void Main()
    {
        // 2. out 파라미터 활용 : 반환값과 오류의 전달을 분리하자.
        // - 함수의 성공실패 여부와 반환값이 분리된다.
        // - 사용자가 실패를 반드시 처리하도록 강제할 수 없다. 까다롭다.

        int len;
        bool ret = FileManager.CopyFile("C:\\a.txt", "C:\\b.txt", out len);

        if (ret == false)
        {
            // ......
        }

        //FileManager.DeleteFile("C:\\a.txt");
        //FileManager.OpenFile("D:\\a.txt");
    }
}
