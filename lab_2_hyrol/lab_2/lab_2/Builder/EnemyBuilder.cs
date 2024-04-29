using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_2.Builder;


namespace lab_2.Builder
{
    public class EnemyBuilder : IHeroBuilder
    {
        private Hero _enemy = new Hero();

        public IHeroBuilder SetName(string name)
        {
            _enemy.Name = name;
            return this;
        }

        public IHeroBuilder SetHeight(string height)
        {
            _enemy.Height = height;
            return this;
        }

        public IHeroBuilder SetBuild(string build)
        {
            _enemy.Build = build;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
            _enemy.HairColor = hairColor;
            return this;
        }

        public IHeroBuilder SetEyeColor(string eyeColor)
        {
            _enemy.EyeColor = eyeColor;
            return this;
        }

        public IHeroBuilder SetClothing(string clothing)
        {
            _enemy.Clothing = clothing;
            return this;
        }

        public IHeroBuilder AddToInventory(string item)
        {
            _enemy.Inventory.Add(item);
            return this;
        }
        public Hero Build()
        {
            return _enemy;
        }
        public IHeroBuilder AddEvilDeeds(List<string> deeds)
        {
            _enemy.Inventory.AddRange(deeds);
            return this;
        }
    }
}
