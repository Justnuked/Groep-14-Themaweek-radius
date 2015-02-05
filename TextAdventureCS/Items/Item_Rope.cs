using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Rope : Objects
    {
        public Rope(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Rope";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("There is a thick rope tied around a rock.");
        }
    }
}
