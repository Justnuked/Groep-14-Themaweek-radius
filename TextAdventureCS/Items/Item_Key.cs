using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Key : Objects
    {
        public Key(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Key";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("There is a rusty key lying on a table.");
        }
    }
}
