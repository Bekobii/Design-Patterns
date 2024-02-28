namespace Prototype.Interfaces;

public interface IVehicle
{
    
    string? Name { get; set; }

    int PS { get; set; }

    IVehicle Clone();
}