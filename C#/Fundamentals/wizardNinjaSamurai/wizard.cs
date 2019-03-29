using System;
using System.Collections.Generic;

namespace WizardNinjaSamari
{
    class Wizard : Human
    {
        
        public Wizard(string name) : base(name)
        {
            health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            int Damage = target.Intelligence * 5;
            target.health -= Damage;
            this.health += Damage;

            return Health;  
        }
        public int Heal(Human target)
        {
            int amount = target.Intelligence * 10;
            target.health += amount;
            return Health;
        }
    }
}