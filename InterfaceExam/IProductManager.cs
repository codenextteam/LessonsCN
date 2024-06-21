using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    internal interface IProductManager<T>
    {
        //void AddProduct();

         void Add(T t);
        void Test()
        {
            Console.WriteLine("test");
        }
    
        
    }
}
