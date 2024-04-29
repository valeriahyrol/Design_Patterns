using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_2.Builder; 


namespace lab_2.Builder
{
    public class HeroBuilder : IHeroBuilder
    {
        private Hero _hero = new Hero();

        public IHeroBuilder SetName(string name)
        {
            _hero.Name = name;
            return this;
        }

        public IHeroBuilder SetHeight(string height)
        {
            _hero.Height = height;
            return this;
        }

        public IHeroBuilder SetBuild(string build)
        {
            _hero.Build = build;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
            _hero.HairColor = hairColor;
            return this;
        }

        public IHeroBuilder SetEyeColor(string eyeColor)
        {
            _hero.EyeColor = eyeColor;
            return this;
        }

        public IHeroBuilder SetClothing(string clothing)
        {
            _hero.Clothing = clothing;
            return this;
        }

        public IHeroBuilder AddToInventory(string item)
        {
            _hero.Inventory.Add(item);
            return this;
        }

        public Hero Build()
        {
            return _hero;
        }
        public IHeroBuilder AddEvilDeeds(List<string> deeds)
        {
            _hero.Inventory.AddRange(deeds);
            return this;
        }
    }
}
