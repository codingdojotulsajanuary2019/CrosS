using System;

namespace WizardNinjaSamari
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int ReduceHealth = target.Dexterity * 5;
            Random Rand = new Random();
            int result = Rand.Next(0,6);
            if(result == 3)
            {
                ReduceHealth += 10;
            }

            return health;
        }

        public int Steal(Human target)
        {
            target.health -= 5;
            this.health += 5;

            return Health;
        }
    }
}