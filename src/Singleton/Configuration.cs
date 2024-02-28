namespace Singleton;

public class Configuration
{
    
    private static Configuration? Instance;


    private Configuration()
    {
        
    }

    
    public static Configuration GetInstance()
    {
        return Instance ??= new Configuration();
    }
    
    
    
}