
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



//Operation => business classes

class ProductManager
{


    public  ProductManager()
    {

    }

    public void AddToCart(Product product)
    {
        Console.WriteLine($"{product.ProductName} adli mehsul sebete elave olundu, qiymeti : {(product.IsDiscount ? product.DiscountPrice : product.UnitPrice)}");
    }
}


