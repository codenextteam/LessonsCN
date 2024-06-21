using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndField
{
    internal class Product
    {
        public Product(int id, string productName, double unitPrice)
        {
            Id = id;
            ProductName = productName;
            UnitPrice = unitPrice;
            Console.WriteLine($"id: {id}, name: {productName}, price: {unitPrice}");
        }
        //overloading
        public Product()
        {
            
        }
        public Product(int id, string productName="yoxdur")
        {
            ProductName = productName;
        }

       
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
    }
}
