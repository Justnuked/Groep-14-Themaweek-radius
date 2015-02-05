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
            Key key = new Key("Key", true);
            items.Add(key.GetName(), key);
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in the middle of a gaint, ill lit room.");
        }
    }
}
