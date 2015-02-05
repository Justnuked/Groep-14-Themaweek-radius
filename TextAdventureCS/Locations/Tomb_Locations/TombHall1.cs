using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombHall1 : Location
    {
        public TombHall1(string name)
            : base(name)
        {
 
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a gaint, ill lit room.");
        }
    }
}
