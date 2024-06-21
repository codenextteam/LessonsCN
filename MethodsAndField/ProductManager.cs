using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndField
{
    internal class ProductManager
    {

        public void Add(Product product)
        {
            Console.WriteLine($"adi: {product.ProductName}, qiymeti: {product.UnitPrice} olan mehsul bazaya elave olundu");
        }
    }
}
