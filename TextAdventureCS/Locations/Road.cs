using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Road : Location
    {
        public Road(string name)
            : base(name)
        {
 
        }
        public override void Description()
        {
            Console.WriteLine("You are standing on a road.");
        }
    }
}
