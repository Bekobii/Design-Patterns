using Builder.Entities;
using Builder.Interfaces;

namespace Builder;

public class ComputerBuilder : IComputerBuilder
{
    private Computer Computer = new();

    public IComputerBuilder AddRAM(RAM ram)
    {
        Computer.RAM = ram;
        return this;
    }

    public IComputerBuilder AddCPU(CPU cpu)
    {
        Computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder AddMotherboard(Motherboard motherboard)
    {
        Computer.Motherboard = motherboard;
        return this;
    }

    public Computer Build()
    {
        return Computer;
    }
}