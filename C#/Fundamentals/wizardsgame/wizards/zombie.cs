using System;

namespace wizards
{
    class Zombie : Enemy, IFighter
    {
        public Zombie(string name): base(name)
        {
            Name = name;
            Strength = 10;
            health = 100;
        }
        public override int Attack(IFighter target)
        {
            int dmg = Strength * 5;
            int heal = dmg;
            this.health += heal;
            Console.WriteLine($"{this.Name} attacked {target.name} for {dmg} and healed for {heal} damage!");
            target.health -= dmg;
            return target.health;
        }
    }
}