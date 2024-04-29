﻿using lab_2.TechFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory.Brands
{
    public class Balaxy : Brand
    {
        public override string Name => "Balaxy";

        public override Device CreateDevice()
        {
            return new Smartphone();
        }
    }
}
