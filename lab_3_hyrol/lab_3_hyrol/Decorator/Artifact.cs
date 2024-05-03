using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Decorator
{
    class Artifact : InventoryDecorator
    {
        public Artifact(Hero hero) : base(hero) { }

        public override float GetPower()
        {
            return base.GetPower() + 300;
        }
    }
}
