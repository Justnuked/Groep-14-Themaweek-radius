using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Axe : Objects
    {
        public Axe(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Axe";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("A big waraxe is resting on a stand.");
        }
    }
}
