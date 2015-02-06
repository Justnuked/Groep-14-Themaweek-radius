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
            Strong_Health_Potion shp = new Strong_Health_Potion("Strong Health Potion", true);
            items.Add(shp.GetName(), shp);
            Weak_Health_Potion whp = new Weak_Health_Potion("Weak Health Potion", true);
            items.Add(whp.GetName(), whp);
            Axe axe = new Axe("Axe", true);
            items.Add(axe.GetName(), axe);
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in front of a lake(Blacklake). . .");
            Console.WriteLine("It is misty and you think you saw something moving in the water. . .");
        }
    }
}
