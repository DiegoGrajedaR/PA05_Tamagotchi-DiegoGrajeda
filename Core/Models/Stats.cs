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
        public int LvlHealthy { get; }

        public Stats(int lvlHungry, int lvlEnergy, int lvlHealthy) { 
        
        }

    }
}
