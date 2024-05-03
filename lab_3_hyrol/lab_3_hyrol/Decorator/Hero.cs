using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Decorator
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public float Strength { get; set; }
        public float Armor { get; set; }
        public float WeaponDamage { get; set; }
        public float ArtifactPower { get; set; }

        public Hero(string name, float strength)
        {
            Name = name;
            Strength = strength;
        }
        public virtual float GetPower()
        {
            return Strength + Armor + WeaponDamage + ArtifactPower;
        }
    }
}
    

