using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Game.Core.Models
{
    public class Player
    {
        public string Name { get; set; }
        public APet? PetPlayer { get; set; }
        public Inventory InventoryPlayer { get; set; }

        public Player(string name, APet petPlayer, Inventory inventoryPlayer) { }
    }
}
