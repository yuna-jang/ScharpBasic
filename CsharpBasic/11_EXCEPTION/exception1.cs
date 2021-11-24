using System;


public static class FileManager
{
    public static int CopyFile(string srcFileName, string dstFileName)
    {
        return 100;
    }
}

class Program
{
    static void Main()
    {
        FileManager.CopyFile("C:\\a.txt", "C:\\b.txt");
    }
}
