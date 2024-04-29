using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory.Brands
{
    public abstract class Brand
    {
        public abstract string Name { get; }
        public abstract Device CreateDevice();
    }
}
