using System;

namespace wizards{
    
    class Ninja : Human, IFighter
    {
        public Ninja(string name): base(name)
        {
            dexterity = 15;
            health = 175;  
        } 

        public override int Attack(IFighter target)
        {
            Random rand = new Random();
            int crit = rand.Next(6);
            int dmg = dexterity * 5;
            if (crit == 1 )
            {
                dmg += 10;
            }
            target.health -= dmg;
            Console.WriteLine($"{name} judo chopped {target.name} for {dmg} damage!");
            return target.health;
        }
        public int Steal(IFighter target)
        {
            target.health -= 45;
            this.health += 45;
            Console.WriteLine($"{name} stole 45 health from {target.name}!");
            return this.health;
        }
    }
}