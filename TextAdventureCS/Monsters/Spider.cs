using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Spider : Monster
    {
        public Spider(string name)
            : base(name, 6, 6)
        {
            this.name = "Giant spider";
            this.str = 5;
            this.though = 5;
        }
        public string Description()
        {
             return "A big spider with huge fangs!";
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
