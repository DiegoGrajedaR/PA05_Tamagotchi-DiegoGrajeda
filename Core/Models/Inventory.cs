using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Game.Core.Models
{
    public class Inventory
    {
        public AItem[] ItemsInventory { get; private set; }

        public Inventory () 
        {
            ItemsInventory = new AItem[0];
        }

        public void AddItem(AItem item) { }
        public void RemoveItem(AItem item) { }
    }
}
