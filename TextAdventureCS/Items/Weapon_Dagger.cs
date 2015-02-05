using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Dagger : Objects
    {
        public Dagger(string name, bool acquirable)
            : base(name, acquirable)
        {
            name = "Dagger";
            acquirable = true;
        }

        override protected void Description()
        {
            Console.WriteLine("A small dagger lies on a table.");
        }
    }
}
