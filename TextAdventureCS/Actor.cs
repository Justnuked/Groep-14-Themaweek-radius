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
            this.str = HasStrBuff(str);
            this.armour = HasArmBuff(armour);
        }

        public abstract void TakeHit(int damage);

        public abstract int HasStrBuff(int str);
        public abstract int HasArmBuff(int armour);

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

        public int HasStrBuff(Player player)
        {
            if (player.HasObject("Axe") == true)
            {
                if (player.HasObject("Sword") == true)
                {
                    Console.WriteLine("The axe is better than your sword.\nYou decide to drop your sword.");
                    player.DropItem("Sword");
                }
                if (player.HasObject("Dagger") == true)
                {
                    Console.WriteLine("The axe is better than your dagger.\nYou decide to drop your dagger.");
                    player.DropItem("Dagger");

                }
                return player.str = 6;
            }
            else if (player.HasObject("Sword") == true)
            {
                if (player.HasObject("Dagger") == true)
                {
                    Console.WriteLine("The sword is better than your dagger.\nYou decide to drop your dagger.");
                    player.DropItem("Dagger");
                }
                return player.str = 4;
            }
            else if (player.HasObject("Dagger") == true)
            {
                return player.str = 2;
            }
            else
            {
                return player.str = 1;
            }
        }

        public int HasArmBuff(Player player)
        {
            if (player.HasObject("Steel Armour") == true)
            {
                if (player.HasObject("Iron Armour") == true)
                {
                    Console.WriteLine("Steel armour is better than iron armour.\nYou decide to leave the iron armour behind");
                    player.DropItem("Iron Armour");
                }
                if (player.HasObject("Leather Armour") == true)
                {
                    Console.WriteLine("Steel armour is better than leather armour.\nYou decide to leave the leather armour behind");
                    player.DropItem("Leather Armour");
                }
                return player.armour = 6;
            }
            else if (player.HasObject("Iron Armour") == true)
            {
                if (player.HasObject("Leather Armour") == true)
                {
                    Console.WriteLine("Iron armour is better than leather armour.\nYou decide to leave the leather armour behind");
                    player.DropItem("Leather Armour");
                }
                return player.armour = 4;
            }
            else if (player.HasObject("Leather Armour") == true)
            {
                return player.armour = 2;
            }
            else
            {
                return player.armour = 0;
            }
        }

        public int HealPlayer(Player player)
        {
            int menuchoice = 0;
            while (menuchoice != 3)
            {
                Console.Clear();
                Console.WriteLine("Which potion do you want to use?");
                Console.WriteLine("If no potions show up, that means you are at full health.");
                if (player.HasObject("Strong Health Potion") == true && player.health < 100)
                {
                    Console.WriteLine("1. Strong Health Potion (Heals 50 hitpoints)");
                }
                if (player.HasObject("Weak Health Potion") == true && player.health < 100)
                {
                    Console.WriteLine("2. Weak Health Potion (Heals 25 hitpoints)");
                }
                Console.WriteLine("3. Exit");
                try
                {
                    menuchoice = int.Parse(Console.ReadLine());
                }
                catch (Exception) { }

                switch (menuchoice)
                {
                    case 1:
                        if (player.HasObject("Strong Health Potion") == true && player.health < 100)
                        {
                            Console.WriteLine("You drink the health potion. You feel invigorated.");
                            player.DropItem("Strong Health Potion");
                            return player.health += 50;
                        }
                        break;

                    case 2:
                        if (player.HasObject("Weak Health Potion") == true && player.health < 100)
                        {
                            Console.WriteLine("You drink the health potion. You feel slightly invigorated.");
                            player.DropItem("Weak Health Potion");
                            return player.health += 25;
                        }
                        break;

                    case 3:
                        break;
                }
            }
            return player.health += 0;
        }

        public void CheckHealth(Player player)
        {
            if (player.health > 100)
            {
                player.health = 100;
            }
        }

        public int GetStr()
        {
            return str;
        }

        public int GetThough()
        {
            return armour;
        }

    }
}
