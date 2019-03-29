using System;

namespace wizards
{
    class Spider : Enemy, IFighter
    {
        public Spider(string name): base(name)
        {
            Name = name;
            Strength = 15;
            health = 65;
        }
        public override int Attack(IFighter target)
        {
            int dmg = Strength * 5;
            Console.WriteLine($"{this.name} attacked {target.name} for {dmg} damage!");
            target.health -= dmg;
            return target.health;
        }
    }
}