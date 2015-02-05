using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Diamond : Objects
    {
        public Diamond(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Diamond";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("You see a shining Diamond lying on the ground.");
        }
    }
}
