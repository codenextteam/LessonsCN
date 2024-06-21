using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    internal class ComputerManager : IProductManager<Computer>
    {
        public void Add(Computer computer)
        {
            Console.WriteLine($"{computer.ProductName} {computer.Ram}");
        }
        public void Update()
        {

        }
    }
}
