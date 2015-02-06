using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Forest : Location
    {
        public Forest(string name)
            : base(name)
        {
            // If there is an enemy, set enemy to true
            hasEnemy = true;              
        }

        public override void Description()
        {
            // Insert a nice description
            Console.WriteLine("You are standing in a thick, gloomy forest(Woodhearth)");
            Console.WriteLine("What are you going to do. . ? ");
        }
    }
}
