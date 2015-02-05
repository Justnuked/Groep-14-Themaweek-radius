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
            hasEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in front of a castle(Dragonstar).");
            Console.WriteLine("The gates are open, you see a flag on the wall belonging the the local bandit clan. . .");
        }
    }
}
