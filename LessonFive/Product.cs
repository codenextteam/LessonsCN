using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFive
{
    internal class Product
    {
     
        //entity class - data class

        //Foregin, Primary - Key
        public int Id { get;  set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public double UnitPrice { get; set; }
        public int StockCount { get; set; }
        public bool isDeliviry { get; set; }
    }
}
