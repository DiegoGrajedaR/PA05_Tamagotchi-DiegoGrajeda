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
        protected string Name;
        protected int Value;

        protected AItem(string name, int value) { }


        public abstract void Use();
    }
}
