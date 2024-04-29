using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_2.Builder
{
    public class Director
    {
        private IHeroBuilder _builder;

        public Director(IHeroBuilder builder)
        {
            _builder = builder;
        }

        public Hero Construct()
        {
            return _builder
                .SetName("Unknown")
                .SetHeight("Average")
                .SetBuild("Medium")
                .SetHairColor("Brown")
                .SetEyeColor("Brown")
                .SetClothing("Casual")
                .Build();
        }
    }

}
