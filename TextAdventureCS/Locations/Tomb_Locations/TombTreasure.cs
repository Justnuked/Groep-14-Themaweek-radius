using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombTreasure : Location
    {
        public TombTreasure(string name)
            : base(name)
        {
            hasBossEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a gaint, ill lit room.");
        }
    }
}
