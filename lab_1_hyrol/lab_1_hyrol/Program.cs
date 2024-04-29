using lab_1_hyrol.product;
using System;

namespace lab_1_hyrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(100, 50); 
            Money money2 = new Money(200, 25);
            Money money3 = new Money(150, 75, isUah: true);
            money1.PrintAmountUSD();
            money2.PrintAmountUSD();
            money3.PrintAmountUAH();

            Category category1 = new Category("Book");
            Category category2 = new Category("Magazine");

            Product product1 = new Product("Dan about Food", category1, money1, 100, DateTime.Now.AddDays(-5));
            Product product2 = new Product("VOGUE", category2, money2, 20, DateTime.Now.AddDays(-2));

            Console.WriteLine("Decreased product prices:");
            product1.DecreasePrice(10);
            product2.DecreasePrice(20);
            Console.WriteLine($"Product: {product1.Name}, Price: {product1.Price.Dollars}.{product1.Price.Cents}, Category: {product1.Category.Name}");
            Console.WriteLine($"Product: {product2.Name}, Price: {product2.Price.Dollars}.{product2.Price.Cents}, Category: {product2.Category.Name}");

            Warehouse warehouse = new Warehouse();

            warehouse.AddProduct(product1);
            warehouse.AddProduct(product2);

            Reporting reporting = new Reporting(warehouse);

            reporting.RegisterProduct(product1, 10, "2024-04-05");
            reporting.RegisterProduct(product2, 20, "2024-04-10");

            Console.WriteLine("Generated inventory report:");
            reporting.InventorReport();

            ShopCart shoppingCart = new ShopCart();
            string input;
            do
            {
                Console.WriteLine("Enter product name (or 'f' to finish):");
                input = Console.ReadLine();

                if (input.ToLower() != "f")
                {
                    Product foundProduct = warehouse.FindProductByName(input);
                    if (foundProduct != null)
                    {
                        shoppingCart.AddToCart(foundProduct);
                        Console.WriteLine("Product added to cart.");
                    }
                    else
                    {
                        Console.WriteLine("Product not found in warehouse.");
                    }
                }
            } while (input.ToLower() != "f");

            shoppingCart.PrintCart();
            Money total = shoppingCart.CalculateTotal();
            Console.WriteLine($"Total amount to pay: {total.Dollars}.{total.Cents}");
        }
    }
}
