using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_9_1
{
    internal class Player
    {
        private List<Item>inventory = new List<Item>();

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void UseItem()
        {
            if (inventory.Count > 0)
            {
                inventory[0].Use();
                inventory[1].Use();
                inventory[2].Use();
                inventory.RemoveAt(0);
            }
        }
    }
}
