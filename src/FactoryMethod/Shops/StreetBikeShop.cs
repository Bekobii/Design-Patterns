using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Shops;

public class StreetBikeShop : IBikeShop
{
    public IBicycle Create()
    {
        return new StreetBike()
        {
            Type = BikeType.StreetBike,
            Name = "Street Bike"
        };
    }
}