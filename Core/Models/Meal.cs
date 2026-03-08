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
        public Meal(string name, int value) : base(name, value, 30) { }

        public override void Use(APet pet)
        {
            pet.PetStats.LvlHungry = Math.Min(100, pet.PetStats.LvlHungry + 30);
            Console.WriteLine($"Has donat de menjar a {pet.Name} un {Name} (Meal) 🍖.");
        }
    }
}
