using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    //50 18 == 6 6
    class DwarfKing : Monster
    {
        public DwarfKing(string name)
            : base ("Ðurin", 75,75)
        {
            this.name = "Ðurin";
            this.str = 20;
            this.though = 10;
        }

        public string Description()
        {
            return "The last king under the mountain. . .";
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
