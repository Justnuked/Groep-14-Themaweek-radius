using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Castle : Location
    {
        public Castle(string name)
            : base(name)
        {
            hasBossEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in front of a castle.");
            Console.WriteLine("The entrance is barricaded. You need something heavy to clear it.");
        }
    }
}
