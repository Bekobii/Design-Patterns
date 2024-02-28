using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Shops;

public class MountainBikeShop : IBikeShop
{
    public IBicycle Create()
    {
        return new MountainBike()
        {
            Type = BikeType.MountainBike,
            Name = "Mountain Climber X"
        };
    }
}