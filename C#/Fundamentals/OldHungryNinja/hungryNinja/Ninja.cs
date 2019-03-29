using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Food
    {
        public string name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string type, int cal, bool spicy, bool sweet)
        {
            name = type;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;
    
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Tacos", 1000, true, false),
                new Food("Donuts", 700, false, true),
                new Food("Steak", 1200, false, false),
                new Food("Snickers", 150, false, true),
                new Food("Potato", 200, false, false),
                new Food("Curry & Rice", 800, true, false),
                new Food("Fries", 400, false, false)
                
            };
        }


        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count)];
        }
    }

    class Ninja
    {
        private int calorieIntake;        
        public List<Food> foodHistory;
        
        public Ninja()
        {
            calorieIntake = 0;
            foodHistory = new List<Food>();
        }
        public bool isFull
        {
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void Eat(Food item)
        {
            if(isFull == true)
            {
                Console.WriteLine("Ninja cannot eat anymore");
            }
            else
            {   
                foodHistory.Add(item);
                string spicy = null;
                string sweet = null;

                if(item.IsSpicy == false)
                {
                    spicy = "not";
                }
                else
                {
                    spicy = "very";
                }
                
                if(item.IsSweet == false)
                {
                    sweet = "not";
                }
                else
                {
                    sweet = "very";
                }

                calorieIntake += item.Calories;

                Console.WriteLine($"You just ate {item.name} it was {spicy} spicy and {sweet} sweet.");
            }
        }
    }
}