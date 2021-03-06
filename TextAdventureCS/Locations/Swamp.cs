﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Swamp : Location
    {
        public Swamp(string name)
            : base(name)
        {
            Rope rope = new Rope("Rope", true);
            items.Add(rope.GetName(), rope);
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in a swamp.");
            Console.WriteLine("The air is thick, and it smells terrible");
        }
    }
}
