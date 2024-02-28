using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Shops;

public class CityBikeShop : IBikeShop
{
    public IBicycle Create()
    {
        return new CityBike()
        {
            Type = BikeType.CityBike,
            Name = "City Bike"
        };
    }
}