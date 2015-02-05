using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Town : Location
    {
        public Town(string name)
            : base(name)
        {
            hasInn = true;
            Dagger dag = new Dagger("Dagger", true);
            items.Add(dag.GetName(), dag);
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in a village");
        }
    }
}
