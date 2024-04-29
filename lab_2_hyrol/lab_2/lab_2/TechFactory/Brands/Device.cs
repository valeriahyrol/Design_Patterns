using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory.Brands
{
    public abstract class Device
    {
        public abstract string Name { get; }
        public abstract string ScreenSize { get; }
        public abstract string Processor { get; }
    }
}
