using System;

// 오류전달방식
public static class FileManager
{
    public static int CopyFile(string srcFileName, string dstFileName)
    {
        // ......
        if (실패)
        {
            throw new Exception("파일 접근 권한 없음");
        }

        return 100;
    }
}

class Program
{
    static void Main()
    {
        // 3. 예외처리 (Exception)
        // - throw 키워드로 예외를 던진다.
        // - 오류의 전달과 메서드의 반환값이 완전히 분리된다.
        // - 오류에 대한 다양한 정보 전달 가능
        // - 예외를 처리하지 않으면 오류 메시지 발생후 프로그램 종료 -> 오류처리에 대한 강제성 부여
        //   -> try ~ catch

        try
        {
            FileManager.CopyFile("C:\\a.txt", "C:\\b.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("프로그램은 계속 실행됨");
    }
}
