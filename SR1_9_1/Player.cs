using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_9_1
{
    internal class Player
    {
        Item useItem;

        public Player(Item item) 
        {
            useItem = item;
        }

        public void UseItem()
        {
            useItem.Use();
        }
    }
}
