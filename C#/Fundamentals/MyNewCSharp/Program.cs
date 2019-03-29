using System;
using System.Collections.Generic;

namespace MyNewCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bikes = new List<string>();
            bikes.Add("Kawasaki");
            bikes.Add("Honda");
            bikes.Add("KTM");
            bikes.Add("Yamaha");
            bikes.Add("Suzuki");

            Console.WriteLine(bikes[2]); //prints "KTM"
            Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

            Console.WriteLine("The current manufacturers we have seen are:");
            for(var i=0; i<bikes.Count; i++){
                Console.WriteLine("-" + bikes[i]);
            }
            bikes.Insert(2, "BMW");

            bikes.Remove("Suzuki");
            bikes.RemoveAt(3);

            Console.WriteLine("List of Non-Cool Manufacturers:");
            foreach(string manu in bikes){
                Console.WriteLine("-" + manu);
            }
        }
    }
}
