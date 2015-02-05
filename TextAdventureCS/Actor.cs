using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    abstract class Actor
    {
        protected string name;
        protected int maxHealth;
        protected int health;
        protected int str;
        protected int armour;
        
        public Actor( string name, int maxHealth, int str, int armour )
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.health = maxHealth;
            this.str = HasBuff(str);
            this.armour = armour;
        }

        public abstract void TakeHit(int damage);

        public abstract int HasBuff(int str);

        public string GetName()
        {
            return name;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }

        public int GetHealth()
        {
            return health;
        }

        public int SetHealth()
        {
           return health = maxHealth;           
        }

        public int HasBuff(Player player)
        {
            if (player.HasObject("Dagger") == true)
            {
                return player.str = 2;
            }
            else
                return player.str = 1;
        }
    }
}
