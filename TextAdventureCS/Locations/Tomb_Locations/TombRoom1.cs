using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombRoom1 : Location
    {
        public TombRoom1(string name)
            : base(name)
        {

        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a small, dark room.");
        }
    }
}
