using System;

namespace wizards
{
    abstract class Human
    {
        private string Name;
        private int Strength;
        private int Intelligence;
        private int Dexterity;
        private int Health;
        
        public string name  { get; set; }
        public int strength  { get; set; }
        public int intelligence  { get; set; }
        public int dexterity  { get; set; }
        public int health  { get; set; }
        
        public Human(string fighterName)
        {
            Name = fighterName;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        
        public Human(string fighterName, int str, int intel, int dex, int hp)
        {
            Name = fighterName;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        
        // Build Attack method
        public abstract int Attack(IFighter target);

    }
}