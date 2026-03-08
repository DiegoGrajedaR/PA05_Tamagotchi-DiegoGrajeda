using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;

namespace Tamagotchi_Game.Core.Models
{
    public abstract class AItem
    {
        public string Name { get; protected set; }
        public int Value { get; protected set; }

        protected AItem(string name, int value) 
        {
            Name = name;
            Value = value;
        }


        public abstract void Use(APet pet);
    }
}
