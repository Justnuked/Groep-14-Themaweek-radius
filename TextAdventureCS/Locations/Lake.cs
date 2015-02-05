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
 
        }
        public override void Description()
        {
            Console.WriteLine("You are standing in front of a lake. . .");
        }
    }
}
