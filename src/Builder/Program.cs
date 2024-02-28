
using Builder.Entities;
using Builder.Interfaces;
using Dumpify;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerBuilder computerBuilder = new ComputerBuilder();

            var ram = new RAM()
            {
                Model = "DDR4", Gigabytes = 16
            };

            var cpu = new CPU()
            {
                Model = "Intel Core i7", Cores = 8
            };

            var motherboard = new Motherboard()
            {
                Model = "ASUS ROG Strix Z390-E Gaming"
            };

            var computer = computerBuilder
                .AddRAM(ram)
                .AddCPU(cpu)
                .AddMotherboard(motherboard)
                .Build();

            computer.Dump();
        }
    }
}