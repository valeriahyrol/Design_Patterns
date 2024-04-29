using lab_2.TechFactory.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory.Products
{
    public class EBook : Device
    {
        public override string Name => "EBook";
        public override string ScreenSize => "6 inches";
        public override string Processor => "N/A";
    }
}
