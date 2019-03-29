using System;
using System.Collections.Generic;

namespace hungryNinja
{
    abstract class Ninja
    {
        protected int calorieIntake;        
        public List<IConsumable> foodHistory;
        
        public Ninja()
        {
            calorieIntake = 0;
            foodHistory = new List<IConsumable>();
        }
        public abstract bool isFull {get;}
        public abstract void Consume(IConsumable item);
    }
}
