
using PharmacyConsoleApp;
using static System.Net.Mime.MediaTypeNames;




//hello page
Console.WriteLine("                 >>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Welcome Pharmcy App <<<<<<<<<<<<<<<<<<<<<<<<<<<<");


AdminManager adminManager = new();
Admin admin = new();
MenuManager menuManager = new();

void MenuCommand()
{
    Console.WriteLine(">> 1. login");
    Console.WriteLine(">> 2. exit");

    Console.Write(">> choose: ");
    string setCommant = Console.ReadLine();

    switch (setCommant)
    {
        case "1" :  AdminCredential();
                break;
            case "2" :
              ExitApp();
            ; break;
        default:
            Console.WriteLine("Sehv input");
            break;
    }

}
MenuCommand();

void AdminCredential()
{
    
    Console.Write("Enter your username: ");
    admin.Username = Console.ReadLine();
    Console.Write("Enter your password: ");
    admin.Password = Console.ReadLine();
   bool isLogged =  adminManager.AdminLogin(admin);
    if (isLogged)
    {
        Console.Clear();
       
        string selectedMenu = menuManager.AdminMenu();

        switch (selectedMenu)
        {
            case "1" :
                Console.Write(">> enter seller fullname: ");
                string setSellerFullName = Console.ReadLine();

                Console.Write(">> enter seller username: ");
                string setSellerUsername = Console.ReadLine();

                Console.Write(">> enter seller password: ");
                string setSellerPassword = Console.ReadLine();

                Seller seller = new() 
                {
                    Id = 1,
                    FullName = setSellerFullName,
                    Username = setSellerUsername,
                    Password = setSellerPassword,

                };
                adminManager.AddSeller(seller);
                break;
            default:
                Console.WriteLine("secim yanlishdir");
                menuManager.AdminMenu();
                break;
        }
    }
    
}

void ExitApp()
{
    Environment.Exit(0);
}




