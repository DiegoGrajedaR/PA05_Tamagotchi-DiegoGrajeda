using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Game.Core.Models
{
    public class Stats
    {
        public int LvlHungry { get; set; }
        public int LvlEnergy { get; set; }
        public int LvlHealthy => (LvlHungry + LvlEnergy) / 2;

        public Stats(int lvlHungry, int lvlEnergy) 
        {
            LvlHungry = lvlHungry;
            LvlEnergy = lvlEnergy;
        }

    }
}
