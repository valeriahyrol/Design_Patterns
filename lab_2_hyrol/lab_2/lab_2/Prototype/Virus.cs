using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Prototype
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }
        public object Clone()
        {
            Virus clonedVirus = new Virus(Weight, Age, Name, Type);
            foreach (var child in Children)
            {
                clonedVirus.Children.Add((Virus)child.Clone());
            }
            return clonedVirus;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Weight: {Weight}, Age: {Age}");
            foreach (var child in Children)
            {
                Console.WriteLine($"Child: {child.Name}, Type: {child.Type}, Weight: {child.Weight}, Age: {child.Age}");
            }
        }
    }
}
