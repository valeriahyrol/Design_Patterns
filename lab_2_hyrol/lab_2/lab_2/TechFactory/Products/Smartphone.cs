using lab_2.TechFactory.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory.Products
{
    public class Smartphone : Device
    {
        public override string Name => "Smartphone";
        public override string ScreenSize => "6.2 inches";
        public override string Processor => "Snapdragon 878";
    }
}

