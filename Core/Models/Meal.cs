using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;

namespace Tamagotchi_Game.Core.Models
{
    public class Meal : Food
    {
        public Meal(string name, int value, int nutritionalValue) : base(name, value, 40) { }

        public override void Use(APet pet)
        {
            pet.PetStats.LvlHungry = Math.Min(100, pet.PetStats.LvlHungry + NutritionalValue);
            Console.WriteLine($"Has donat de menjar a {pet.Name} un {Name} (Meal) 🍖.");
        }
    }
}
