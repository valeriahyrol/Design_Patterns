using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_2.Builder; 


namespace lab_2.Builder
{
    public interface IHeroBuilder
    {
        IHeroBuilder SetName(string name);
        IHeroBuilder SetHeight(string height);
        IHeroBuilder SetBuild(string build);
        IHeroBuilder SetHairColor(string hairColor);
        IHeroBuilder SetEyeColor(string eyeColor);
        IHeroBuilder SetClothing(string clothing);
        IHeroBuilder AddToInventory(string item);
        IHeroBuilder AddEvilDeeds(List<string> deeds); 
        Hero Build();
    }


}
