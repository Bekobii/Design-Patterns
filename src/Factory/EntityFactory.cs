using Factory.Entities;
using Factory.Enums;
using Factory.Interfaces;

namespace Factory;

public class EntityFactory : IEntityFactory
{
    public IEntity? Create(EntityType entityType)
    {
        IEntity createdEntity;
        
        switch (entityType)
        {
            case EntityType.Email:
                createdEntity = new Email();
                break;
            case EntityType.User:
                createdEntity = new User();
                break;
            default:
                throw new NotSupportedException($"{entityType} is not supported.");
        }

        return createdEntity;
    }
}