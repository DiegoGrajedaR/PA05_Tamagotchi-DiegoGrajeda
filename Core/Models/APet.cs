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

        public void CheckStatus() 
        {
            if (PetStats.LvlHealthy <= 20) PetState = EmotionalState.Sick;
            
            else if (PetStats.LvlEnergy <= 30) PetState = EmotionalState.Tired;
            
            else if (PetStats.LvlHungry <= 50) PetState = EmotionalState.Angry;

            else if (PetStats.LvlEnergy == 60 && PetStats.LvlHungry == 60) PetState = EmotionalState.Sad;

            else if (NumSnacks < 5) PetState = EmotionalState.Happy;
            

            if (PetStats.LvlHealthy == 0) 
            {
                IsAlive = false;
                Console.WriteLine($"💀 {Name} died. GAME OVER!");
            }
        }

        //Mètode Play() ja definit que utilitzen les subclases de Pet
        public virtual void PetPlay() 
        {
            if (PetState == EmotionalState.Tired)
            {
                Console.WriteLine(UIconfig.MsgPetTired(Name));
                return;
            }
            if (PetState == EmotionalState.Sick)
            {
                Console.WriteLine(UIconfig.MsgPetSick(Name));
                return;
            }
            if (PetState == EmotionalState.Sad)
            {
                Console.WriteLine(UIconfig.MsgPetSad(Name));
                return;
            }
            if (PetState == EmotionalState.Angry)
            {
                Console.WriteLine(UIconfig.MsgPetAngry(Name));
                return;
            }

            PetStats.LvlEnergy -= 10;
            PetStats.LvlHungry -= 10;
            PetState = EmotionalState.Happy;

            Console.WriteLine(UIconfig.MsgPetHappy(Name));
        }

        //Mètode Sleep() ja definit que utilitzen les subclases de Pet
        public virtual void PetSleep() 
        {
            PetStats.LvlEnergy = Math.Min(100, PetStats.LvlEnergy + 40);
            Console.WriteLine($"💤 {Name} slept and recovered energy.");
        }

        //Mètode Eat() ja definit que utilitzen les sublclases de Pet, aquesta esta enllazada amb el mètode Use() de Food
        public virtual void PetEat(Food food) 
        {
            food.Use(this);
        }

        //Mètode GetSprites() que no ve definit però que han de sobre escriure les sublclases de Pet.
        public abstract string GetSprites(EmotionalState petState);

    }

}
