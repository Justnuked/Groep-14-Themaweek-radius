using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Tomb : Location
    {
        public Tomb(string name)
            : base(name)
        {

        }
        public override void Description()
        {
            Console.WriteLine("You are standing in front of a tomb.(Dunbarrow)");
            Console.WriteLine("After looking closely at the door you find several dwarvish runes on the door");
        }
    }
}
