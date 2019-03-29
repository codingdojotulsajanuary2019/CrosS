using System;

namespace wizards
{
    abstract class Enemy 
   {
        public string Name;
        public int Strength;
        public int Health;
        
        public string name  { get; set; }
        public int strength  { get; set; }
        public int health  { get; set; }
        
        public Enemy(string fightername)
        {
            Name = name;
            Strength = 1;
            health = 50;
        }
        
        
        // Build Attack method
        public abstract int Attack(IFighter target);
    }
}