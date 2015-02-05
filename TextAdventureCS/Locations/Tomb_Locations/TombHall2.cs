using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombHall2 : Location
    {
        public TombHall2(string name)
            : base(name)
        {
 
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a gaint, ill lit room.");
        }
    }
}
