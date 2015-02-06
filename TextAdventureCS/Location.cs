using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    abstract class Location
    {
        protected string name;
        public bool hasEnemy;
        public bool hasBossEnemy;
        protected bool hasInn;
        protected bool hasTreasure;
        protected Dictionary<string, Objects> items;
        protected Dictionary<string, Monster> monster;

        public Location(string name)
        {
            this.name = name;
            hasEnemy = false;
            hasBossEnemy = false;
            hasInn = false;
            hasTreasure = false;
            items = new Dictionary<string, Objects>();
            monster = new Dictionary<string, Monster>();
        }

        abstract public void Description();

        public virtual string GetName()
        {
            return name;
        }

        public virtual bool HasEnemy()
        {
            return hasEnemy;
        }

        public virtual bool HasTreasure()
        {
            return hasTreasure;
        }

        public virtual bool HasBossEnemy()
        {
            return hasBossEnemy;
        }

        public virtual bool HasInn()
        {
            return hasInn;
        }

        public virtual bool CheckForItems()
        {
            if (items.Count() == 0)
                return false;
            else
                return true;
        }

        public Dictionary<string, Objects> GetItems()
        {
            return items;
        }

        public Dictionary<string, Monster> GetMonsters()
        {
            return monster;
        }
    
    }
}
