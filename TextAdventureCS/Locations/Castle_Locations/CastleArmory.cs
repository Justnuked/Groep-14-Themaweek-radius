using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class CastleArmory : Location
    {
        public CastleArmory(string name)
            : base(name)
        {
            hasBossEnemy = true;
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a armory.");
            Console.WriteLine("You see several weaponracks on the wall, on the other side are some armourstands. . .");
        }
    }
}
