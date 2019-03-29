using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(){
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(new int[] {2,6,4});
            // GetAverage(new int[] {2,10,3});
            // OddArray();
            // GreaterThanY(new int[] {1,3,5,7}, 3);
            // SquareArrayValues(new int[] {1,2,3,4,5,6});
            // EliminateNegatives(new int[] {1,2,3,4,5,6,-2,-7});
            // MinMaxAverage(new int[] {3,6,9,12,15});
            ShiftValues(new int[] {1,2,3,4,5,6});
            }
        public static void PrintNumbers(){
            for(int x=1; x<256; x++){
                Console.WriteLine(x);
            }
        }
        public static void PrintOdds(){
            for(int x=1; x<256; x++){
                if(x%2 != 0){
                    Console.WriteLine(x);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for(int x=0; x<256; x++){
                Console.WriteLine("Number = " + x);
                sum = sum + x;
                Console.WriteLine("Sum = " + sum);
            }
        }
        public static void LoopArray(int[] numbers){
            for(int x=0; x<numbers.Length; x++){
                Console.WriteLine(numbers[x]);
            }
        }
        public static void GetAverage(int[] numbers){
            double avg = 0;
            int sum = 0;
            for(int x=0; x<numbers.Length; x++){
                sum = sum + numbers[x];
            }
            Console.WriteLine(avg = sum/numbers.Length);
        }
        public static int[] OddArray(){
            int[] numArray;
            for(var x=1; x<256; x++){
                if(x%2!=0){
                    Console.Write(x);
                    numArray = new int[] {x};
                }
            }
            return new int[] {5,6}; 
        }
        public static int GreaterThanY(int[] numbers, int y){
            int count = 0;
            for(var x=0; x<numbers.Length; x++){
                if(numbers[x]>y){
                    count = count +1;
                    Console.WriteLine(count);
                }
            }
            return count;
        }
        public static void SquareArrayValues(int[] numbers){
            for(int x=0; x<numbers.Length; x++){
                numbers[x] = numbers[x] * numbers[x];
                Console.WriteLine(numbers[x]);
            }
        }
        public static void EliminateNegatives(int[] numbers){
            for(int x=0; x<numbers.Length; x++){
                if(numbers[x] < 0){
                    numbers[x] = 0;
                }
                Console.WriteLine(numbers[x]);
            }
        }
        public static void MinMaxAverage(int[] numbers){
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            double avg = 0;
            for(int x=0; x<numbers.Length; x++){
                if(numbers[x]<min){
                    min = numbers[x];
                }
                if(numbers[x]>max){
                    max = numbers[x];
                }
                sum = sum + numbers[x];
            }
            avg = sum/numbers.Length;
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);
            Console.WriteLine("Average = " + avg);
        }
        public static void ShiftValues(int[] numbers){
            for(int x=0; x<numbers.Length-1; x++){
                numbers[x] = numbers[x+1];
                Console.Write(numbers[x]);
            }
            numbers[numbers.Length-1] = 0;
            Console.Write(numbers[numbers.Length-1]);
        }
    }
}
