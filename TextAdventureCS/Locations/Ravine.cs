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
            hasBossEnemy = true;
            hasEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing on the edge of a ravine.");
        }
    }
}
