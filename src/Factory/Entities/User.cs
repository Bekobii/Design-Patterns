using Factory.Interfaces;

namespace Factory.Entities;

public class User : IEntity
{
    public uint Id { get; set; }

    public string? Name { get; set; }
}