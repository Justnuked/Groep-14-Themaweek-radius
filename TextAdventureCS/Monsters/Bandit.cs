using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
   public class Bandit : Monster
    {
        public Bandit(string Name)
            :base(Name)
        {
            this.str = 5;
            this.though = 5;
            this.name = "Bandit";
        }

        //public void HitBandit(ref Player player)
        //{
        //   player.TakeHit(10);
        //}

        public void Description()
        {
            Console.WriteLine("You encounter a vicious bandit");
        }

        public int GetStre()
        {
            return str;
        }

        public int GetThoughe()
        {
            return though;
        }

    }
}
