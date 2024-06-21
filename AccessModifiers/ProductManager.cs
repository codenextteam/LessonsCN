using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //access Modifier => private, protected, internal, public
    public class ProductManager
    {
        public int Id { get; set; }
        public void Add()
        {
            Id++;
        }
    }

    
}
