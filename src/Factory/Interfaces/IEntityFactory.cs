using Factory.Enums;

namespace Factory.Interfaces;

public interface IEntityFactory
{
    IEntity? Create(EntityType entityType);
}