using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Skeleton2 : Monster
    {
        public Skeleton2(string name)
            : base("Big skeleton", 20, 20)        
        {
            this.str = 12;
            this.though = 5;
            this.name = "Big skeleton";
        }

        public string Description()
        {
            return "A Big Skeleton with sword and shield!";
        }

        public int GetStr()
        {
            return str;
        }

        public int GetThough()
        {
            return though;
        }
    }
}
