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
            Sword sword = new Sword("Sword", true);
            Weak_Health_Potion wh = new Weak_Health_Potion("Weak Health Potion", true);
            items.Add(sword.GetName(), sword);
            items.Add(wh.GetName(), wh);
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in front of an abandoned church(church of Stendarr).");
            Console.WriteLine("The door is open. . .");
        }
    }
}
