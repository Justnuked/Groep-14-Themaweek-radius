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
            // Add items here
            Diamond dia = new Diamond("Diamond", true);
            items.Add(dia.GetName(), dia);
            // If there is an enemy, set enemy to true
            hasEnemy = true;
            Monster monster = new Monster("Bandit");
            
            
        }

        public override void Description()
        {
            // Insert a nice description
            Console.WriteLine("You are standing in a thick, gloomy forest(Woodhearth)");
            Console.WriteLine("What are you going to do. . ? ");
        }
    }
}
