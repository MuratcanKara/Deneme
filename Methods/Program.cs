using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.productId = 1;
            product1.productName = "skirt";
            product1.productPrice = 17.78;
            product1.productDetails = "This's a nice skirt.";
            product1.productQuantity = 5;


            Product[] products = new Product[] {
            product1,
                        
            };

            foreach (Product product in products)
            {
                Console.WriteLine(product.productId + " " + product.productName + " " + product.productPrice);
            }

            BasketManager basketManager = new BasketManager();
            basketManager.AddToBasket(product1);
            
        }
    }
}
