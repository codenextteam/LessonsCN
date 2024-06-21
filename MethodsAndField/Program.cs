
using MethodsAndField;

Product productOne = new Product(1, "Iphone", 3450);
Product productTwo = new Product(2, "Samsung", 1750);
Product productThree = new Product(3);

productThree.UnitPrice = 456;

ProductManager productManager = new ProductManager();

productManager.Add(productOne);
productManager.Add(productTwo);
productManager.Add(productThree);