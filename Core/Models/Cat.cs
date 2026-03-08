using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;

namespace Tamagotchi_Game.Core.Models
{
    public class Cat : APet
    {
        public Cat(string name, EmotionalState petState, Stats petStats, bool isAlive) : base(name, petState, petStats, isAlive)
        { }

        public override string GetSprites(EmotionalState petState)
        {
            return petState switch
            {
                EmotionalState.Happy => "  ^~^  ,\n ('v') )\n /   \\/\n(\\|||/)",
                EmotionalState.Sad => "  ^~^  ,\n (╥ ╥) )\n / ^ \\/\n(\\|||/)",
                EmotionalState.Angry => "  ^~^  ,\n (> <) )\n / ^ \\/\n(\\|||/)",
                EmotionalState.Tired => "  ^~^  ,\n (- -) )Zzz\n / ^ \\/\n(\\|||/)",
                EmotionalState.Sick => "  ^~^  ,\n (x x)\n / - \\/\n(\\|||/)"
            };
        }
    }
}
