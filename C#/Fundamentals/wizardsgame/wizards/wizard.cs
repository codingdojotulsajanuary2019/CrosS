using System;

namespace wizards{

    class Wizard : Human, IFighter
    {

        public Wizard(string name): base(name)
        {
            intelligence = 10;
            health = 50;  
        }

        public override int Attack(IFighter target)
        {
            int dmg = intelligence * 5;
            int heal = dmg;
            Console.WriteLine($"{this.name} attacked {target.name} for {dmg} damage and healed themselves for {heal}!");
            this.health += heal;
            return target.health;
        }

        public int Heal(Human target)
        {
            int heal = intelligence * 10;
            Console.WriteLine($"{this.name} healed {target.name} for {heal}!");
            target.health += heal;
            return target.health;
        }
    }
}