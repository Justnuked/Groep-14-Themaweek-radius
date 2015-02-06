using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Snake : Monster
    {
            public Snake(string Name)
            :base(Name,35,35)
        {
            this.str = 15;
            this.though = 5;
            this.name = "Snake";
        }

        public string Description()
        {
            return "A venomous snake with big teeth!";
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
