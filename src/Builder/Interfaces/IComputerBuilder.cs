using Builder.Entities;

namespace Builder.Interfaces;

public interface IComputerBuilder
{
    IComputerBuilder AddRAM(RAM ram);

    IComputerBuilder AddCPU(CPU cpu);

    IComputerBuilder AddMotherboard(Motherboard motherboard);
    
    Computer Build();
}