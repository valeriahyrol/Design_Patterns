using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Decorator
{
    public class Weapon : InventoryDecorator
    {
        public Weapon(Hero hero) : base(hero) { }

        public override float GetPower()
        {
            return base.GetPower() + 200;
        }
    }
}
