using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Bchief : Monster
    {
        public Bchief(string name)
            : base("Bandit Chief", 25, 25)
        {
            this.name = "Bandit Chief";
            this.str = 15;
            this.though = 10;
        }

        public string Description()
        {
            return "The chief of the bandits, he is wielding a huge basterdsword!";
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
