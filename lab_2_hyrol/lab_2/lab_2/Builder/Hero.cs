using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Builder
{
   public class Hero
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Name: {Name}, Height: {Height}, Build: {Build}, Hair Color: {HairColor}, Eye Color: {EyeColor}, Clothing: {Clothing}, Inventory: {string.Join(", ", Inventory)}";
        }
    }
}
