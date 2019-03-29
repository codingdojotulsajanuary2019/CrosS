using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet TuesdayBuffet = new Buffet();
            Food meal = TuesdayBuffet.Serve();
            Food meal1 = TuesdayBuffet.Serve();
            Food meal2 = TuesdayBuffet.Serve();
            Console.WriteLine(meal.name);
            Ninja bob = new Ninja();
            bob.Eat(meal);
            bob.Eat(meal1);
            bob.Eat(meal2);
            Console.WriteLine(bob.foodHistory);
        }
    }
}
