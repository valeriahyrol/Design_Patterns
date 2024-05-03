using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Decorator
{
    public class Paladin : Hero 
    {
        public Paladin(string name, float strength) : base(name, strength)
        {
            Armor = 120;
            WeaponDamage = 40;
            ArtifactPower = 100;
        }
    }
}
