using System;

namespace hungryNinja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool isFull
        {
            get
            {
                if(calorieIntake >= 1500)
                {
                    Console.WriteLine("SweetTooth is Full!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //provide override for consume
        public override void Consume(IConsumable item)
        {
            if(calorieIntake < 1500)
            {
                if( item.IsSweet == true )
                {
                    this.calorieIntake += item.Calories + 10;
                    Console.WriteLine("I just ate something too!");
                }
                else
                {
                    this.calorieIntake += item.Calories;
                    Console.WriteLine("I just ate something too!");
                }
            }
            else
            {
                Console.WriteLine("SweetTooth is Full!");
            }
            this.foodHistory.Add(item);
            item.GetInfo();
        }
    }
}