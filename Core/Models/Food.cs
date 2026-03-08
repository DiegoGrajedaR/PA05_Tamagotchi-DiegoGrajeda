using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;

namespace Tamagotchi_Game.Core.Models
{
    public class Food : AItem
    {
        public int NutritionalValue { get; set; }

        public TypeFood FoodType { get; set; }


        public Food(string name, int value, int nutritionalValue, TypeFood foodType) : base(name, value) { }

        public override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
