using lab_2.TechFactory.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory.Products
{
    public class Laptop : Device
    {
        public override string Name => "Laptop";
        public override string ScreenSize => "15.6 inches";
        public override string Processor => "Intel Core i7";
    }
}
