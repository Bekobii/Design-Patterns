using Command.Commands;
using Command.FileManagers;
using Command.Interfaces;

namespace Command;

class Program
{
    static void Main(string[] args)
    {

        var fileManager = new WindowsFileManager();

        string path = @"test.txt";
        
        List<ICommand> commands = new();

        var createFileCommand = new CreateFileCommand(fileManager, path);
        createFileCommand.Execute();
        
        
        commands.Add(createFileCommand);

        var deleteFileCommand = new DeleteFileCommand(fileManager, path);
        deleteFileCommand.Execute();
        
        commands.Add(deleteFileCommand);
        
        foreach (var command in commands)
        {
            Console.WriteLine($"Executed command: ${command}");
        }



    }
}