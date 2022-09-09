using System;

namespace Aggregation {
    class Program {
       
        static void Main(string[] args) { 
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Aggregate_Simple(numbers);
            Aggregate_Seed(numbers);
            Average(numbers);
            Count(numbers);
            //LongCount();
            Max(numbers);  
            Min(numbers);
            Sum(numbers);

        }
        static void Aggregate_Simple(int[] number) { 
            var result = number.Aggregate((a, b) => a + b);
            Console.WriteLine("Aggregated numbers by addition:");
            Console.WriteLine(result);
        }
        static void Aggregate_Seed(int[] numbers) { 
            var result = numbers.Aggregate(10,(a, b) => a + b); //result seed by 10 , result is 31
            Console.WriteLine("Aggregate numbers by addition with a seed of 10:");
            Console.WriteLine(result);
        }

        static void Average(int[] numbers) {
            var result = numbers.Average();
            Console.WriteLine("Average is :"+" "+result);
        }

        static void Count(int[] numbers) { 
            var result = numbers.Count();
            Console.WriteLine("Total Numbers in Array :"+result);
        }
        //static void LongCount()
        //{
        //    var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));
        //    Int64 result = largeArr.LongCount();
        //    Console.WriteLine("Counting AlrgeArr elements:" + result);
        //}
        static void Max(int[] numbers) { 
            var result = numbers.Max();
            Console.WriteLine("Max number in the array :" + " " + result);
        }
        static void Min(int[] numbers) {
            var result = numbers.Min();
            Console.WriteLine("Min number in the Array :" + " " + result);
        }
        static void Sum(int[] numbers) {
            var result = numbers.Sum();
            Console.WriteLine("Summing the numbers yields :" + " " + result);
        }
    }
}
