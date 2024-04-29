using lab_1_hyrol.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_hyrol
{
    public class ShopCart
    {
        private List<Product> products;

        public ShopCart()
        {
            products = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            products.Add(product);
        }

        public void PrintCart()
        {
            Console.WriteLine("Shopping Cart Contents:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price.Dollars}.{product.Price.Cents}");
            }
        }
        public Money CalculateTotal()
        {
            Money total = new Money();

            foreach (var product in products)
            {
                total.Dollars += product.Price.Dollars;
                total.Cents += product.Price.Cents;

                if (total.Cents >= 100)
                {
                    total.Dollars += total.Cents / 100;
                    total.Cents %= 100;
                }
            }

            return total;
        }
    }
}
