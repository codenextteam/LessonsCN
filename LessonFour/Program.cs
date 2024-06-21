
//OOP => Object Oriented Programming


//string productName = "Iphone 14";
//bool isDelivery = false;
//double deliveryPrice = 0;
//double unitPrice = 1899.99;
//bool isDiscount = true;
//double discountPrice = 1719.99;
//bool isCash = true;
//double cashDiscount = 180;
//string description = "6.1 ekran, 6gb ram 128 yaddash";
//string imgUrl = "img1.jpg";



//Clean Code Best practice


Product productOne = new()
{
    ProductName = "Iphone 14 Pro max",
    ImgUrl = "img1.jpg",
    Description = "6gb ram, 128 yaddash, 6 ekran, dark cyan color",
    IsDelivery = true,
    DeliveryPrice = 5.00,
    UnitPrice = 2799.99,
    IsDiscount = true,
    DiscountPrice = 1799.99,
    IsCash = true,
    CashDiscount = 180.00
};
Product productTwo = new()
{
    ProductName = "Iphone 14 Pro max-2",
    ImgUrl = "img1.jpg",
    Description = "6gb ram, 128 yaddash, 6 ekran, dark cyan color",
    IsDelivery = true,
    DeliveryPrice = 5.00,
    UnitPrice = 2799.99,
    IsDiscount = true,
    DiscountPrice = 1799.99,
    IsCash = true,
    CashDiscount = 180.00
};

Product productThree = new()
{
    ProductName = "Iphone 14 Pro max-3",
    ImgUrl = "img1.jpg",
    Description = "6gb ram, 128 yaddash, 6 ekran, dark cyan color",
    IsDelivery = true,
    DeliveryPrice = 5.00,
    UnitPrice = 2799.99,
    IsDiscount = true,
    DiscountPrice = 1799.99,
    IsCash = true,
    CashDiscount = 180.00
};

Product productFour = new()
{
    ProductName = "Iphone 14 Pro max-4",
    ImgUrl = "img1.jpg",
    Description = "6gb ram, 128 yaddash, 6 ekran, dark cyan color",
    IsDelivery = true,
    DeliveryPrice = 5.00,
    UnitPrice = 2799.99,
    IsDiscount = false,
    DiscountPrice = 1799.99,
    IsCash = true,
    CashDiscount = 180.00
};

ProductManager productManager = new();
Product[] products = { productOne, productTwo, productThree, productFour };

foreach (var item in products)
{
    Console.WriteLine($"productName: {item.ProductName}, Description: {item.Description}, Price: {(item.IsDiscount ? item.DiscountPrice : item.UnitPrice)}");
    Console.WriteLine("---------------------------------------------");
    productManager.AddToCart( item );
    Console.WriteLine("---------------------------------------------");
}


//Operation => business classes






