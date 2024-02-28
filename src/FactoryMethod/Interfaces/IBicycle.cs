using FactoryMethod.Enums;

namespace FactoryMethod.Interfaces;

public interface IBicycle
{
    public string? Name { get; set; }

    public BikeType? Type { get; set; }
}