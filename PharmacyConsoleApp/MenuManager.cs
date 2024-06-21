using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyConsoleApp
{
    internal class MenuManager
    {

        public string AdminMenu()
        {
            Console.WriteLine(">> 1. Add Seller ");
            Console.WriteLine(">> 2. Add Medicine");
            Console.WriteLine(">> 3. Delete Medicine");
            Console.WriteLine(">> 4. Get Medicine");
            Console.WriteLine(">> 5. Logout");
            Console.Write(">> choose: ");
          return  Console.ReadLine();
        }

    }
}
