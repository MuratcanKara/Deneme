using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void AddToBasket(Product product) {

            Console.WriteLine("Added to basket! : " + product.productName + product.productQuantity);

        }

    }
}
