using System;
using System.Collections.Generic;

namespace WizardNinjaSamari
{
    class Samaurai : Human
    {
        public Samaurai(string name) : base(name)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.health < 50)
            {
                target.health = 0;
            }
            return Health;
        }


        public int Meditate()
        {
            health = 100;

            return Health;
        }

    }
}