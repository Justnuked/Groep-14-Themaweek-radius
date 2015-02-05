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

        public Monster(string name)
        {
            this.str = 1;
            this.though = 1;
            this.name = name;
        }

        public int GetStr()
        {
            return str;
        }

        public int GetThough()
        {
            return though;
        }

        public string GetName()
        {
            return name;
        }

    }
}
