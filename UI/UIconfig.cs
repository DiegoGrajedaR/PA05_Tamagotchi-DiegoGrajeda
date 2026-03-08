using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tamagotchi_Game.UI
{
    public class UIconfig
    {
        //Constants metodes PetPlay

        public static string MsgPetTired(string name) => $"La teva mascota {name} esta massa cansada i no pot jugar.";
        public static string MsgPetSick(string name) => $"{name} es troba malalt i no pot jugar. (Potser necessita atenció especial)";
        public static string MsgPetSad(string name) => $"La teva mascota {name} esta trista potser no vol jugar.";
        public static string MsgPetAngry(string name) => $"😠 La teva mascota {name} està enfadada amb tu! No vol jugar.";
        public static string MsgPetHappy(string name) => $"😊 {name} esta content i radiant.";
    }
}
