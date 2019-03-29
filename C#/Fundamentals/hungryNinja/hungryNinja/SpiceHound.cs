using System;

namespace hungryNinja
{
    class SpiceHound : Ninja
    {
        public override bool isFull
        {
            get
            {
                if(calorieIntake >= 1200)
                {
                    Console.WriteLine("SpiceHound is Full!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            if(calorieIntake < 1200)
            {
                if(item.IsSpicy == true)
                {
                    this.calorieIntake += item.Calories - 5;
                    Console.WriteLine("I just ate something!");
                }
                else
                {
                    this.calorieIntake += item.Calories;
                    Console.WriteLine("I just ate something!");
                }
            }
            else
            {
                Console.WriteLine("SpiceHound is Full!");
            }
            this.foodHistory.Add(item);
            item.GetInfo();
        }
    }
}