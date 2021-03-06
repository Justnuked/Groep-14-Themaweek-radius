﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
   public class Bandit : Monster
    {
        public Bandit(string Name)
            :base(Name,15,15)
        {
            this.str = 12;
            this.though = 5;
            this.name = "Bandit";
        }


        public string Description()
        {
            return "A vicious bandit wielding a short sword!";
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
