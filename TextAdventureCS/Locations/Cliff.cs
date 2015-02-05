using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Cliff : Location
    {
        public Cliff(string name)
            : base(name)
        {
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in front of a cliff(The hanger).");
            Console.WriteLine("This is a dead end. You can only go back");
        }
    }
}
