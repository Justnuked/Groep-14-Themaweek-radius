using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Armour_Steel : Objects
    {
        public Armour_Steel(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Steel Chestplate";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("An impressive steel chestplate lies next to a skeleton.");
        }
    }
}
