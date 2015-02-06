using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
   public class Monster
    {
        public string name;
        public int str;
        public int though;
        public int health;
        public int maxhealth;

        public Monster(string name, int maxHealth, int health)
        {
            this.maxhealth = maxHealth;
            this.health = health;
            this.str = 1;
            this.though = 1;
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

    }
}
