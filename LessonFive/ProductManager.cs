using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFive
{
    internal class ProductManager
    {
        public void AddProduct()
        {
            Console.WriteLine("Mehsul ugurla elave olundu");
        }
        public void ProductAddToCart(Product product)
        {
            Console.WriteLine($"Sebete {product.ProductName} adli mehsul elave olundu. qiymeti: {product.UnitPrice} ");
        }
       
        public void GetProduct(Product product)
        {
            Console.WriteLine($"adi: {product.ProductName}, xususiyyeti: {product.Description}, qiymeti: {product.UnitPrice} Azn stock sayi: {product.StockCount}");
        }
    }
}
