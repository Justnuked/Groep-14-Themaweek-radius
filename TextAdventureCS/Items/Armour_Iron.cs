using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Armour_Iron : Objects
    {
        public Armour_Iron(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Iron Chestplate";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("A heavy iron chestplate lies on the floor.");
        }
    }
}
