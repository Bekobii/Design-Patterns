namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        var firstInstance = Configuration.GetInstance();
        var secondInstance = Configuration.GetInstance();

        Console.WriteLine($"Instances equal: {firstInstance.Equals(secondInstance)}");
    }
}