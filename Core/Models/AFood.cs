using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;

namespace Tamagotchi_Game.Core.Models
{
    public abstract class AFood : AItem
    {
        protected int NutritionalValue { get; set; }

        protected TypeFood FoodType { get; set; }


        public AFood(string name, int value, int nutritionalValue, TypeFood foodType) : base(name, value) { }
    }
}
