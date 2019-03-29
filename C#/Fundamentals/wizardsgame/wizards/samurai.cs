using System;

namespace wizards
{
    
    class Samurai : Human, IFighter
    {
        public Samurai(string name): base(name)
        {
            strength = 10;
            health = 200;  
        }

        public override int Attack(IFighter target)
        {
            int dmg = strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{name} attacked {target.name} for {dmg} damage!");
            if(target.health < 50){
                target.health = 0;
            }
            return target.health;
        }
        public int Meditate()
        {
            int heal = 200-this.health;
            Console.WriteLine($"{name} meditated to regain {heal} health!");
            this.health += heal;
            return this.health;
        }
    }
}