using Dumpify;
using Factory.Enums;
using Factory.Interfaces;

namespace Factory;

class Program
{
    static void Main(string[] args)
    {
        IEntityFactory entityFactory = new EntityFactory();
        var user = entityFactory.Create(EntityType.User);
        var email = entityFactory.Create(EntityType.Email);

        user.Dump();
        email.Dump();

        
        var admin = entityFactory.Create(EntityType.Admin);
    }
}