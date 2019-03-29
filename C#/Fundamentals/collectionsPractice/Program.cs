using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = {0,1,2,3,4,5,6,7,8,9};
            string[] newArr2 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] newArr3 = {true, false, true, false, true, false, true, false, true, false};

            Random rand = new Random();

            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Strawberry");
            iceCream.Add("Rocky Road");
            iceCream.Add("Cookies n Cream");

            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);

            Dictionary<string, int> Flavors = new Dictionary<string, int>();

            for(int i=0; i<4; i++){
                Flavors.Add(newArr2[i], rand.Next(0,5));
            }
            foreach(KeyValuePair<string, int> kvp in Flavors){
                Console.WriteLine("Name = {0}, Flavor ID = {1}", kvp.Key, kvp.Value);
            }
                Console.WriteLine("Flavor IDs:");
                Console.WriteLine("0 - Chocolate");
                Console.WriteLine("1 - Vanilla");
                Console.WriteLine("2 - Strawberry");
                Console.WriteLine("3 - Rocky Road");
                Console.WriteLine("4 - Cookies n Cream");
            Console.WriteLine(Flavors.Count);
        }
    }
}
