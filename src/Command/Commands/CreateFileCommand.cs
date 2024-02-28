using Command.Interfaces;

namespace Command.Commands;

public class CreateFileCommand : ICommand
{
    private readonly IFileManager FileManager;
    private readonly string Path;

    public CreateFileCommand(IFileManager fileManager, string path)
    {
        FileManager = fileManager;
        Path = path;
    }
    
    public void Execute()
    {
        FileManager.CreateFile(Path);
    }
    
}