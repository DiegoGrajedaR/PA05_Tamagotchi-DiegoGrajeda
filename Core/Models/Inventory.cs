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

        public void AddItem(AItem item) 
        {
            //Creem un array auxiliar amb un tamany +1 respecte a l'original
            AItem[] auxInventory = new AItem[ItemsInventory.Length + 1];

            //Copiem els items de l'array orignal a la nostra array auxiliar
            for (int i = 0; i < ItemsInventory.Length; i++) 
            {
                auxInventory[i] = ItemsInventory[i];
            }

            //Afegim el item que rebem com a paràmetre a l'última posició de l'array aux
            auxInventory[auxInventory.Length - 1] = item;

            //Reasignem la nostra array orignal gracies a la array auxiliar
            ItemsInventory = auxInventory;
        }
        public void RemoveItem(AItem item) 
        {
            int index = -1;

            //Buscarem en el nostre inventory la posició/index del item que volem eliminar
            for (int i = 0; i < ItemsInventory.Length; i++) 
            {
                if (ItemsInventory[i] == item) 
                {
                    index = i;
                }
            }

            //En cas de no existir el item s'acaba la funció
            if (index == -1) 
            {
                return;
            }

            //En cas de trobar el item es crea una nova array auxiliar de tamany -1 respecte a l'original
            AItem[] auxInventory = new AItem[ItemsInventory.Length - 1];
            int j = 0;

            //Copiarem tots els items de la nostre array original a l'auxiliar menys el item eliminat
            for (int i = 0; i < ItemsInventory.Length; i++) 
            {
                if (i != index) 
                {
                    auxInventory[j] = ItemsInventory[i];
                    j++;
                }
            }

            ItemsInventory = auxInventory;
        }
    }
}
