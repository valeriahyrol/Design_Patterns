using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Decorator
{
    public class Mage : Hero 
    {
        public Mage(string name, float strength) : base(name, strength)
        {
            Armor = 50;
            ArtifactPower = 150;
        }
    }
}
