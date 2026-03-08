using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;

namespace Tamagotchi_Game.Core.Models
{
    public class Dog : APet
    {
        public Dog(string name, EmotionalState petState, Stats petStats, bool isAlive) : base(name, petState, petStats, isAlive)
        { }

        public override string GetSprites(EmotionalState petState)
        {
            return petState switch
            {
                EmotionalState.Happy => " /^ ^\\\n" + "/ 0 0 \\\n" + "V\\ Y /V\n" + " / v \\\n" + " |    \\\n" + " || (__V",
                EmotionalState.Sad => " /^ ^\\\n" + "/ ╥ ╥ \\\n" + "V\\ Y /V\n" + " / ^ \\\n" + " |    \\\n" + " || (__V",
                EmotionalState.Angry => " /^ ^\\\n" + "/ ಠ ಠ\\\n" + "V\\ Y /V\n" + " / ^ \\\n" + " |    \\\n" + " || (__V",
                EmotionalState.Tired => " /^ ^\\\n" + "/ _ _\\ Zzz\n" + "V\\ Y /V\n" + " / ^ \\\n" + " |    \\\n" + " || (__V",
                EmotionalState.Sick => " /^ ^\\\n" + "/ x x\\\n" + "V\\ Y /V\n" + " / ^ \\\n" + " |    \\\n" + " || (__V"
            };
            
        }
    }
}
