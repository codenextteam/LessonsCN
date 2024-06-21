using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    internal class PhoneManager : IProductManager<Phone>
    {
        public void Add(Phone phone)
        {
            Console.WriteLine($"{phone.ProductName} {phone.CameraPixel} elave olundu");
        }
        
    }
}
