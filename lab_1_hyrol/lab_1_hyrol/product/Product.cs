using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_hyrol.product
{
    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Money Price { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }

        public Product(string name, Category category, Money price, int quantity, DateTime lastDeliveryDate)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
        }

        public void DecreasePrice(int amount)
        {
            Price.Dollars -= amount;
        }
       

    }
}

