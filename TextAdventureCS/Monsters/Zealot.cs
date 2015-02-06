using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Zealot : Monster
    {
             public Zealot(string Name)
            :base(Name,15,15)
        {
            this.str = 6;
            this.though = 5;
            this.name = "Zealot";
        }

        public string Description()
        {
            return "A warrior of faith screaming the name of his god!";
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
