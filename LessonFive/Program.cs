


using LessonFive;

Product productOne =  new() {Id=1, ProductName = "Iphone", Description = "8gbram, 256gb yaddash, reng qara",UnitPrice = 2300, PhotoUrl="img1.png", StockCount = 23 };
Product productTwo = new() {Id=2, ProductName="HP Envy x360", Description="256ssd 16ram intel i7-13th", UnitPrice = 4500, PhotoUrl = "img2.jpg", StockCount = 12 };

productOne = productTwo;
productTwo.ProductName = "samsung";
Console.WriteLine(productOne.ProductName);
//CRUD - Create, Read, Update, Delete

//Operation class - Business classes, Service classes


ProductManager productManager = new();

productManager.ProductAddToCart(productOne);
productManager.ProductAddToCart(productTwo);


productManager.GetProduct(productOne);
productManager.GetProduct(productTwo);

int num1 = 34;
int num2 = 45;
num1 = num2;
num2 = 67;
Console.WriteLine(num1);

int[] numbersOne =  { 22, 78, 89 };
int[] numbersTwo = new int[] { 99, 42, 43 };
numbersOne = numbersTwo;
numbersTwo[0] = 11;

Console.WriteLine(numbersOne[0]);


Calculate calculate = new();

Console.WriteLine(calculate.PlusTwo(2, 5)); 

int num5 = calculate.PlusTwo(3, 5);

int num7 = num5 + 13;