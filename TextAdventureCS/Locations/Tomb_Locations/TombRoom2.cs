using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombRoom2 : Location
    {
        public TombRoom2(string name)
            : base(name)
        {
            hasEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a room.");
            Console.WriteLine("You see several graves chiseled in the wall.");
        }
    }
}
