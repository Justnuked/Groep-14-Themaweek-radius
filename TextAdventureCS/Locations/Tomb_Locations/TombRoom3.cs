using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class TombRoom3 : Location
    {
            public TombRoom3(string name)
            : base(name)
        {
            Armour_Steel sa = new Armour_Steel("Steel Armour", true);
            items.Add(sa.GetName(), sa);
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You enter the room and find yourself standing on top of a pile of skulls. . .");
        }
    }
}
