using lab_1_hyrol.product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_1_hyrol
{
    internal class Warehouse
    {
        private List<Product> Products { get; set; }

        public Warehouse()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public Product FindProductByName(string name)
        {
            return Products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
