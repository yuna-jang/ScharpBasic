using System;

// 오류전달방식
public static class FileManager
{
    public static int CopyFile(string srcFileName, string dstFileName)
    {
        // ......
        return -1;
    }
}

class Program
{
    static void Main()
    {
        // 1. 반환값을 사용해서 전달
        // - 반환값과 오류값이 모호함
        // - 오류에 대한 자세한 정보를 알려줄 수 없음
        // - 사용자가 실패를 반드시 처리하도록 강제할 수 없음
        // - 정상적인 흐름의 코드와 오류를 처리하는 코드가 분리되지 않고 섞여 있음
        int ret = FileManager.CopyFile("C:\\a.txt", "C:\\b.txt");

        if (ret < 0)
        {
            // ......
        }

        //FileManager.DeleteFile("C:\\a.txt");
        //FileManager.OpenFile("D:\\a.txt");
    }
}
