using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Church : Location
    {
        public Church(string name)
            : base(name)
        {
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in front of an abandoned church(church of Stendarr).");
            Console.WriteLine("The door is open. . .");
        }
    }
}
