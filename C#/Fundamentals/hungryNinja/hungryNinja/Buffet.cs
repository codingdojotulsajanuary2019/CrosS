using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
    
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Tacos", 1000, true, false),
                new Food("Donuts", 700, false, true),
                new Food("Steak", 1200, false, false),
                new Food("Snickers", 150, false, true),
                new Food("Potato", 200, false, false),
                new Food("Curry & Rice", 800, true, false),
                new Food("Fries", 400, false, false),
                new Drink("Pepsi", 200, false, true),
                new Drink("Juice", 150, false, true),
                new Drink("Mtn Dew", 350, false, true)
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0,Menu.Count)];
        }
    }
}