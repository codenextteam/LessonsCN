
using InterfaceExam;

Phone phone1 = new Phone();

phone1.Id = 1;
phone1.ProductName = "Samsung s23";
phone1.Price = 3456;
phone1.CameraPixel = "345";

Computer comp1 = new Computer();
comp1.Id = 1;
comp1.ProductName = "Hp Envy";
comp1.Price = 45678;
comp1.Ram = "64ram";

Tv tv = new();
tv.Id = 1;
tv.ProductName = "Samsung Ultra 4k";
tv.Price = 678;
tv.TvInch = "56inch";


IProductManager<Phone> phoneManager = new PhoneManager();
phoneManager.Add(phone1);

ComputerManager compManager = new();
compManager.Add(comp1);

IProductManager<Tv> tvManager = new TvManager();
tvManager.Add(tv);

tvManager.Test();



