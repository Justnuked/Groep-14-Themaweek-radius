using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Ravine : Location
    {
        public Ravine(string name)
            : base(name)
        {
        }
        public override void Description()
        {
            Console.WriteLine("You are standing on the edge of a ravine.");
            Console.WriteLine("You see a lake at the bottom");
        }
    }
}
