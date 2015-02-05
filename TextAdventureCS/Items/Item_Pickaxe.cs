using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Item_Pickaxe : Objects
    {
        public Item_Pickaxe(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Pickaxe";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("A sturdy pickaxe lays on a bench in the church.");
        }
    }
}
