using Dumpify;
using Prototype.Entities;
using Prototype.Interfaces;

namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        IVehicle car = new Car("Audi A6", 100);
        var clonedCar = car.Clone();

        IVehicle bus = new Bus("Mercedes City", 430);
        var clonedBus = bus.Clone();


        var busHashCode = bus.GetHashCode();
        var clonedBusHashCode = clonedBus.GetHashCode();
        
        
        bus.Dump();
        clonedBus.Dump();

    }
}