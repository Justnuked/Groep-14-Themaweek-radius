using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Strong_Health_Potion : Objects
    {
        public Strong_Health_Potion(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Strong Health Potion";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("You see a large vial with red liquid in it.");
        }
    }
}
