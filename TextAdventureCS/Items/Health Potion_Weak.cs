using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Weak_Health_Potion : Objects
    {
        public Weak_Health_Potion(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Weak Health Potion";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("You see a small vial with red liquid in it.");
        }
    }
}
