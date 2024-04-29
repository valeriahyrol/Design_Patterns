using lab_2.TechFactory.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory.Products
{
    public class Netbook : Device
    {
        public override string Name => "Netbook";
        public override string ScreenSize => "11.6 inches";
        public override string Processor => "Intel Celeron";
    }
}
