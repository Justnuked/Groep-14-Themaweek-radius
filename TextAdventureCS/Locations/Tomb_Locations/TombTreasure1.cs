using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombTreasure1 : Location
    {
        public TombTreasure1(string name)
            : base(name)
        {
            hasTreasure = true;
        }

        public override void Description()
        {
            Console.WriteLine("After defeating the skeletal dwarf, you enter in the main treasure room. You find riches beyond belief");
        }
    }
}
