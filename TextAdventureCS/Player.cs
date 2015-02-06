﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Player : Actor
    {
        private Dictionary<string, Objects> inventory;

        public Player(string name, int maxHealth, int str, int armour)
            : base(name, maxHealth, str, armour)
        {
            inventory = new Dictionary<string, Objects>();
        }

        public void ShowStats(Player player)
        {
            Console.WriteLine("Your Health = {0}/{1}", player.health, player.maxHealth);
            Console.WriteLine("Your Strength = {0}", player.str);
            Console.WriteLine("Your Armour = {0}", player.armour);
        }

        public void DropItem(string itemName)
        {
            if (HasObject(itemName))
            {
                inventory.Remove(itemName);
                Console.WriteLine("{0} is removed from your inventory",itemName);
                //ShowInventory();
                Console.WriteLine("Press a key to continue..");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your inventory does not contain an item");
                Console.WriteLine("with the name {0}. Please try again.", itemName);
                Console.WriteLine("Press a key to continue..");
                Console.ReadKey();
            }
        }

        public void PickupItem(Objects obj)
        {
            // Add an if-statement here when you want to have a maximum number of items
            inventory.Add(obj.GetName(), obj);
            Console.WriteLine("Picked up a(n) {0}", obj.GetName());
            obj.SetIsAcquirable(false);
        }

        public void ShowInventory()
        {
            Console.WriteLine("There are {0} item(s) in your inventory.", (int)inventory.Count());
            if (inventory.Count() > 0)
            {
                Console.WriteLine("These are:");
                foreach (var item in inventory)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        public bool HasObject(string name)
        {
            if (inventory.ContainsKey(name))
                return true;
            else
                return false;
        }

        public override void TakeHit( int damage )
        {
            if (damage < 0)
            {
                damage = 1;
            }
            if (health - damage < 0)
            {
                Console.Clear();
                Console.WriteLine("You took too much damage. You fall to the ground.");
                Console.WriteLine("As you feel the cold floor below you, you realise your greediness");
                Console.WriteLine("is the cause of your oncoming death. It is only a matter of time now.");
                Console.WriteLine("The treasure shall remain where it has been since the death of its owner.");
                Console.WriteLine("Locked away, waiting for someome to come and grab it.");
                Console.WriteLine("Sadly, that someone will not be you. At least not in this lifetime.");
                Console.WriteLine("Better luck next time!");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else
            {
                health -= damage;
                //Console.Clear();
                Console.WriteLine("You took {0} points of damage.", damage);
                Console.WriteLine("You now have {0} HP left.", health);

                if (health < (maxHealth >> 2))
                {
                    Console.WriteLine("You took some serious hits and you are bleeding.");
                    Console.WriteLine("You start to feel weak and desperately need some");
                    Console.WriteLine("medical attention.");
                }
                else if (health < (maxHealth >> 1))
                {
                    Console.WriteLine("You took some hits. You have some scratches and some cuts.");
                    Console.WriteLine("Your body starts to ache and you have to be careful.");
                }
                else if (health < (maxHealth - (maxHealth >> 2)))
                {
                    Console.WriteLine("You have a few scratches, nothing to worry about yet.");
                }
               // Console.WriteLine("Press a key to continue");

                Console.ReadKey();
            }
        }

        public override int HasStrBuff(int str)
        {
            return str;
        }

        public override int HasArmBuff(int armour)
        {
            return armour;
        }
    }
}
