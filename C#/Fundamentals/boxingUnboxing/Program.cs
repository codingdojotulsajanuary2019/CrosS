using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> newList = new List<object>();
            newList.Add(7);
            newList.Add(28);
            newList.Add(-1);
            newList.Add(true);
            newList.Add("chair");

            var sum = 0;
            for(var x=0; x<newList.Count; x++){
                if(newList[x] is int){
                    Console.WriteLine((int)newList[x]);
                    sum = sum + (int)newList[x];
                }
                if(newList[x] is bool){
                    Console.WriteLine(newList[x]);
                }
                if(newList[x] is string){
                    Console.WriteLine((string)newList[x]);
                }
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
