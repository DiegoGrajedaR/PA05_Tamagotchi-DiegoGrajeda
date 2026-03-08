using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Models;

namespace Tamagotchi_Game.Core.Interfaces
{
    public interface IEat
    {
        void PetEat(Food food);
    }
}
