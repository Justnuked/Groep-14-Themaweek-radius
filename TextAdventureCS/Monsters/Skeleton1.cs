using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Skeleton1 : Monster
    {
        public Skeleton1(string name)
            : base("Skeleton archer", 20, 20)
        {
            this.name = "Skeleton archer";
            this.str = 12;
            this.though = 5;
        }

        public string Description()
        {
            return "A Skeleton with a Longbow!";
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
