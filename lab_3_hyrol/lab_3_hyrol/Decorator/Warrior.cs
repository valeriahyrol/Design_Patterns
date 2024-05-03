using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Decorator
{
    public class Warrior : Hero 
    {
        public Warrior(string name, float strength) : base(name, strength)
        {
            Armor = 100;
            WeaponDamage = 50;
        }
    }
}
