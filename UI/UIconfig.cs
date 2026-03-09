using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tamagotchi_Game.UI
{
    public class UIconfig
    {
        //Constants metodes PetPlay

        public static string MsgPetTired(string name) => $"💤 Your pet {name} is too tired and cannot play.";
        public static string MsgPetSick(string name) => $"🤒 {name} is sick and cannot play. (It might need special care)";
        public static string MsgPetSad(string name) => $"🥺 Your pet {name} is sad and may not want to play.";
        public static string MsgPetAngry(string name) => $"😠 Your pet { name } is angry with you! It doesn't want to play.";
        public static string MsgPetHappy(string name) => $"😊 {name} is happy and cheerful. It played but used some energy and is a little hungry.";
    }
}
