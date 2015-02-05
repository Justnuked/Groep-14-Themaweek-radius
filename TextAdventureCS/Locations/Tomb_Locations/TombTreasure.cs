using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombTreasure : Location
    {
        public TombTreasure(string name)
            : base(name)
        {
            hasBossEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a gaint room.");
            Console.WriteLine("The walls are made out of gold, there is a marble throne encrusted with rare gems");
            Console.WriteLine("Against the walls are piles of golden coins, on the side of the throne you see a big chest. . .");
        }
    }
}
