using Command.Interfaces;

namespace Command.FileManagers;

public class WindowsFileManager : IFileManager
{
    public void CreateFile(string path)
    {
        try
        {
            File.Create(path).Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteFile(string path)
    {
        try
        {
            File.Delete(path);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}