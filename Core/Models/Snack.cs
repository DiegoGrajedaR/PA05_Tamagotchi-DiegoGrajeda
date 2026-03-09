using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;

namespace Tamagotchi_Game.Core.Models
{
    public class Snack : Food
    {
        public Snack(string name, int value) : base(name, value, 15) { }

        public override void Use(APet pet) 
        {
            pet.PetStats.LvlHungry = Math.Min(100, pet.PetStats.LvlHungry + 15);
            pet.NumSnacks++;

            if (pet.NumSnacks >= 5)
            {
                pet.PetState = EmotionalState.Sick;
                Console.WriteLine($"Oh no! It seems that {pet.Name} has eaten too many snacks!");
            }
            else 
            {
                pet.PetState = EmotionalState.Happy;
                Console.WriteLine($"{pet.Name} ate {Name} (Snack) 🥓. Now it is happy.");
            }

        }
    }
}
