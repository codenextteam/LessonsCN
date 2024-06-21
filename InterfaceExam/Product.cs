using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    internal class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
