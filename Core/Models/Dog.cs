using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;

namespace Tamagotchi_Game.Core.Models
{
    public class Dog : APet
    {
        public string[] SpritesDog { get; set; }
        public Dog(string name, EmotionalState petState, Stats petStats, bool isAlive) : base(name, petState, petStats, isAlive)
        { }

        public override void PetPlay()
        {

        }

        public override void PetSleep()
        {

        }

        public override void PetEat(AFood food)
        {

        }
    }
}
