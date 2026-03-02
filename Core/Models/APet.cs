using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;

namespace Tamagotchi_Game.Core.Models
{
    public abstract class APet : ISleep, IEat, IPlay
    {
        protected string Name { get; set; }
        protected EmotionalState PetState { get; set; }
        protected Stats PetStats { get; set; }
        protected bool IsAlive { get; set; }
        protected int NumSnacks { get; set; }

        protected APet(string name, EmotionalState petState, Stats petStats, bool isAlive = true, int numSnacks = 0) { }


        public virtual void PetPlay() { }

        public virtual void PetSleep() { }

        public virtual void PetEat(AFood food) { }
    }

}
