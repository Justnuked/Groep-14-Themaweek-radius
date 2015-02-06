using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Kraken : Monster
    {
        public Kraken(string name)
            : base("Kraken", 50, 50)
        {
            this.str = 18;
            this.though = 10;
            this.name = "Kraken";
        }

        public string Description()
        {
            return "A gaint Kraken, it has strong tentacles and it's mouth is filled with huge teeth!";
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
