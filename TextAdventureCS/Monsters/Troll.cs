using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Troll : Monster
    {
            public Troll(string Name)
            :base(Name,25,25)
        {
            this.str = 10;
            this.though = 5;
            this.name = "Troll";
        }

        public string Description()
        {
            return "A giant cave troll with a huge club, he smells terrible!";
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
