using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Game.Core.Models
{
    public class Inventory
    {
        public AItem[] ItemsInventory { get; set; }

        public Inventory (AItem[] itemsInventory) { }

    }
}
