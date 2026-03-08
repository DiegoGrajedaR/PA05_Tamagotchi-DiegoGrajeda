using System;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;
using Tamagotchi_Game.UI;

namespace Tamagotchi_Game.Core.Models
{
    public abstract class APet : ISleep, IEat, IPlay
    {
        public string Name { get; set; }
        public EmotionalState PetState { get; set; }
        public Stats PetStats { get; set; }
        public bool IsAlive { get;  protected set; }
        public int NumSnacks { get; set; }

        protected APet(string name, EmotionalState petState, Stats petStats, bool isAlive = true, int numSnacks = 0) 
        {
            Name = name;
            PetState = petState;
            PetStats = petStats;
            IsAlive = isAlive;
            NumSnacks = numSnacks;
        }


        public virtual void PetPlay() { }

        public virtual void PetSleep() { }

        public virtual void PetEat(Food food) { }
    }

}
