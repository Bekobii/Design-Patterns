using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Entities;

public class StreetBike : IBicycle
{
    public string? Name { get; set; }
    
    public BikeType? Type { get; set; }
}