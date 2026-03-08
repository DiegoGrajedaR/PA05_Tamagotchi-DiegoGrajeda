using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;

namespace Tamagotchi_Game.Core.Models
{
    public class Chick : APet
    {
        public string[] SpritesChick { get; set; }
        public Chick(string name, EmotionalState petState, Stats petStats, bool isAlive) : base(name, petState, petStats, isAlive)
        { }

        public override string GetSprites(EmotionalState petState)
        {
            return petState switch
            {
                EmotionalState.Happy => " ,_,\n(^v^)\n(   )\n-\"-\"--",
                EmotionalState.Sad => " ,_,\n(╥v╥)\n(   )\n-\"-\"--",
                EmotionalState.Angry => " ,_,\n(>v<)\n(   )\n-\"-\"--",
                EmotionalState.Tired => " ,_,\n(-v-)Zzz\n(   )\n-\"-\"--",
                EmotionalState.Sick => " ,_,\n(xvx)\n(   )\n-\"-\"--"
            };
        }
    }
}
