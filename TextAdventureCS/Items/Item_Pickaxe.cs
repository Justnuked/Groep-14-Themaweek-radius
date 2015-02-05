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

        protected override void Description()
        {
            Console.WriteLine("You find a pickaxe on the ground");
        }
    }
}
