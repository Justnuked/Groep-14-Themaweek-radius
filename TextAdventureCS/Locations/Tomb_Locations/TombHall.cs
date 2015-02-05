using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombHall : Location
    {
        public TombHall(string name)
            : base(name)
        {
            
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a long, dark hallway.");
        }

    }
}
