using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Cliff : Location
    {
        public Cliff(string name)
            : base(name)
        {
            Item_Pickaxe pick = new Item_Pickaxe("Pickaxe", true);
            Armour_Leather la = new Armour_Leather("Leather Armour", true);
            items.Add(la.GetName(), la); 
            items.Add(pick.GetName(), pick);
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in front of a cliff(The hanger).");
            Console.WriteLine("This is a dead end. You can only go back");
        }
    }
}
