using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Town : Location
    {
        public Town(string name)
            : base(name)
        {
            hasInn = true;
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in a village");
        }
    }
}
