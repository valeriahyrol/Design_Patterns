using lab_2.TechFactory.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.TechFactory
{
    public class Tech_Factory
    {
        public Brand CreateBrand(string brand)
        {
            switch (brand)
            {
                case "IProne":
                    return new IProne();
                case "Kiaomi":
                    return new Kiaomi();
                case "Balaxy":
                    return new Balaxy();
                default:
                    throw new ArgumentException("Unknown brand");
            }
        }
    }
}
