using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Skeleton : Monster
    {
        public Skeleton(string name)
            : base(name, 20, 20)
        {
            this.name = "Skeleton";
            this.str = 12;
            this.though = 10;
        }
        public string Description()
        {
            return "A Skeleton with a two handed axe!";
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
