using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Armour_Leather : Objects
    {
        public Armour_Leather(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Leather Chestpiece";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("A sturdy leather chestplate is hanging on the wall.");
        }
    }
}
