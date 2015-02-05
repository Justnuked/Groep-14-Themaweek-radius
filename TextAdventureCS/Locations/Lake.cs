using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Lake : Location
    {
        public Lake(string name)
            : base(name)
        {
            hasBossEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in front of a lake(Blacklake). . .");
            Console.WriteLine("It is misty and you think you saw something moving in the water. . .");
        }
    }
}
