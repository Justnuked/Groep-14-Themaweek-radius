using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Sword : Objects
    {
        public Sword(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Sword";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("A long sword is stuck in the ground.");
        }
    }
}