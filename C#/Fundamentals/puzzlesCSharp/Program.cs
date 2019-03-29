using System;

namespace puzzlesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
        }
        public static int[] RandomArray(){
            int min = 5;
            int max = 25;

            Random rand = new Random();
            int[] numArray = new int[10];
            for(int i = 0; i < numArray.Length; i++){
                numArray[i] = rand.Next(min, max);
            }
            foreach(var item in numArray){
                Console.Write(item.ToString() + ", ");
            }
            int arrmax = numArray[0];
            int arrmin = numArray[0];
            int arrsum = 0;

            for(var x=0; x<numArray.Length; x++){
                if(numArray[x] > arrmax){
                    arrmax = numArray[x];
                }
                if(numArray[x] <arrmin){
                    arrmin = numArray[x];
                }
                arrsum = arrsum + numArray[x];
            }
            Console.WriteLine(" ");
            Console.WriteLine("Minimum Value: " + arrmin);
            Console.WriteLine("Maximum Value: " + arrmax);
            Console.WriteLine("Sum: " + arrsum);

            return numArray;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random num = new Random();
            int side = num.Next(1,3);

            if(side == 1)
            {
                Console.WriteLine("HEADS");
                return ("Heads");
            }
            else
            {
                Console.WriteLine("TAILS");
                return ("Tails");
            }

        }
        public static double TossMultipleCoins(int num)
        {
            int head_count = 0;
            int tail_count = 0;
            string Toss;

            for(int i = 0; i <= num; i++)
            {
                Toss = TossCoin();
                if(Toss == "Heads")
                {
                    head_count ++;
                }
                if(Toss == "Tails")
                {
                    tail_count ++;
                }
            }
            Console.WriteLine($"Tossing {num} coins");
            Console.WriteLine(num/head_count);
            return(num/head_count);
        }
    }
}
