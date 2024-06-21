using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyConsoleApp
{
    //business class => operation, service
    internal class AdminManager
    {
   
        public bool AdminLogin(Admin admin)
        {
            //default data
             Admin adminBase = new()
            {
                Id = 1,
                FullName = "Murad Musali",
                Username = "admin",
                Password = "admin123"
            };
            if (admin.Username == adminBase.Username && admin.Password == adminBase.Password)
            {
               return true;
            }
            else
            {
                Console.WriteLine("Username ve ya password yanlishdir");
                return false;
            }
        }

        public void AddSeller(Seller seller) 
        {
            Console.WriteLine($"{seller.FullName} has been successfuly created!");
            MenuManager menu = new MenuManager();
            menu.AdminMenu();
            
        }

    }
}
