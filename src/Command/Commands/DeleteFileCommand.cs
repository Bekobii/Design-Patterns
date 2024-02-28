using Command.Interfaces;

namespace Command.Commands;

public class DeleteFileCommand : ICommand
{
    private readonly IFileManager FileManager;
    private readonly string Path;

    public DeleteFileCommand(IFileManager fileManager, string path)
    {
        FileManager = fileManager;
        Path = path;
    }
    
    public void Execute()
    {
        FileManager.DeleteFile(Path);
    }
}