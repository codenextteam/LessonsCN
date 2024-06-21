using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    internal class TvManager : IProductManager<Tv>
    {
        public void Add(Tv tv)
        {
            Console.WriteLine($"{tv.ProductName} {tv.TvInch} elave edildi");
        }
        
    }
}
