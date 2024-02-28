using Dumpify;
using FactoryMethod.Interfaces;
using FactoryMethod.Shops;

namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        IBikeShop bikeShop = new MountainBikeShop();
        var mountainBike = bikeShop.Create();

        bikeShop = new CityBikeShop();
        var cityBike = bikeShop.Create();

        Console.WriteLine(mountainBike.Type);
        Console.Write(cityBike.Type);
        
        mountainBike.Dump();
        cityBike.Dump();


    }
}