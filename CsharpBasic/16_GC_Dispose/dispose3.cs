using System;
using System.IO;

// FileStream을 오픈한 후 닫지 않으면 다른 누구도 사용할 수 없다.
// 그래서 사용 후 닫기를 해야하는데, GC가 바로 사용을 해제하지 않으므로
// Dispose() 메서드로 즉시, 직접 닫아야 한다. 

class XFileStream
{
    private IntPtr handle;
    public XFileStream(string path)
    {
        // win32 API인 CreateFile()을 사용해서 파일 오픈
    }
    ~XFileStream()
    {
        // win32 API인 CloseFile() 을 사용해서 파일 닫기
    }
    public void Dispose() { }
}

class Program
{
    static void Main()
    {
        XFileStream xfs = new XFileStream("a.txt");
        xfs.Dispose();
        xfs = null;
    }
}