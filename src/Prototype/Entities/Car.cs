using Prototype.Interfaces;

namespace Prototype.Entities;

public class Car : IVehicle
{
    public string? Name { get; set; }

    public int PS { get; set; }

    public Car(string? name, int ps)
    {
        Name = name;
        PS = ps;
    }

    public IVehicle Clone()
    {
        return (IVehicle)this.MemberwiseClone();
    }
}