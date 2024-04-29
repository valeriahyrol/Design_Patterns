using lab_1_hyrol.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_hyrol
    {
        internal class Reporting
        {
        public Warehouse Warehouse { get; set; }

        public Reporting(Warehouse warehouse)
        {
            Warehouse = warehouse;
        }

        public void RegisterProduct(Product product, int quantity, string date)
        {
            
        }

        public void InventorReport()
        {
            foreach (var product in Warehouse.GetProducts())
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price.Dollars}, Category: {product.Category.Name}, Quantity: {product.Quantity}, Last Delivery Date: {product.LastDeliveryDate}");
            }
        }
    }
}


