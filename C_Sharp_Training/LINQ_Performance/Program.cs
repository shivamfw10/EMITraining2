using System;
using System.Diagnostics;

namespace LINQ_Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Example :1*****");
            LinqPerformance1();
            Console.WriteLine("*****Example :2*****");
            LinqPerformance2();
            Console.WriteLine("*****Example :3*****");
            LinqPerformance3();
        }

        //Scenario 1
        //Scenario 1 is a code example which counts all numbers with a value of 12 from an array with random numbers.
        //Code complexity: LINQ with 2 chains (Where and Count).
        //Code description:
        //Set up array with 10,000,000 random integer values between 0-20.
        //LINQ approach to take all numbers from array with a value of 12, and count these.
        //Traditional approach to take all numbers from array with a value of 12, and count these.
        public static void LinqPerformance1()
        {
            //Array with 10,000,000 random integers values between 0-20
            Random randNum = new Random();
            int[] numbers = Enumerable.Repeat(0, 10000000).Select(i => randNum.Next(0, 20)).ToArray();

            //Start Stopwatch

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //LINQ Approach
            var cntLinq = numbers.Where(n => n == 12).Count();

            //Stop stopwatch
            stopwatch.Stop();

            //Print Result
            Console.Write("Time elapsed for LINQ approach :{0}ms", stopwatch.ElapsedMilliseconds);

            //Restart stopwatch
            stopwatch.Reset();
            stopwatch.Start();

            //Traditional Approach
            int cntTraditional = 0;
            foreach (int n in numbers)
            {
                if (n == 12)
                {
                    ++cntTraditional;
                }
            }
            //Stop Stopwatch
            stopwatch.Stop();

            //Print Result
            Console.Write("Time elapsed for LINQ approach :{0}ms", stopwatch.ElapsedMilliseconds);

            //Make sure both approaches give same result
            Console.WriteLine(cntLinq == cntTraditional);
        }
        //Scenario 2
        //Scenario 2 is a code example which first finds values larger than or equal to 5 from an array with random numbers, multiplies each of the found values by themselves, and then calculates the sum.
        //Code complexity: LINQ with 3 chains(Where, Select and Sum).
        //Code description:
        //Set up array with 10,000,000 random integer values between 0-20.
        //LINQ approach to take all numbers from array with a value of 5 or more, multiply value by itself, and lastly sum all values.
        //Traditional approach to take all numbers from array with a value of 5 or more, multiply value by itself, and lastly sum all values.

        public static void LinqPerformance2()
        {
            Random randum = new Random();
            int[] numbers = Enumerable.Repeat(0, 10000000).Select(i => randum.Next(0, 20)).ToArray().ToArray();
            //Start stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //LINQ approach
            var sumLinq = numbers.Where((n) => n == 5).Select(n => n * n).Sum();

            //Stop stopwatch
            stopwatch.Stop();

            //Print result
            Console.Write("Time elapsed for LINQ approach :{0}ms", stopwatch.ElapsedMilliseconds);

            //Restart stopwatch
            stopwatch.Reset();
            stopwatch.Start();

            //Traditional approach
            int sumTraditional = 0;
            foreach (int n in numbers)
            {
                if (n >= 5)
                {
                    sumTraditional += n * n;
                }
            }

            //stop stopwatch
            stopwatch.Stop();

            //Print result
            Console.Write("Time elapsed for LINQ approach :{0}ms", stopwatch.ElapsedMilliseconds);

            Console.WriteLine(sumLinq == sumTraditional);

        }

        //Scenario 3
        //Scenario 3 is a code example which first finds values between 1-5 from an array with random numbers,
        //joins with array of anonymously typed elements by number, takes spelled out numbers from join result being exactly three letters of length, and finally counts these.
        //Code complexity: LINQ with 4 chains (Where, Join, Select and Count).
        //Code description:
        //Set up array called numbers with 10,000,000 random integer values between 0-5.
        //Set up array called words of anonymously typed elements, consisting of numbers 1-5 and corresponding spelled out values.
        //LINQ approach to take all numbers from numbers array with a value between 1-5, join by words array, take only words which are exactly three letters in length, and then count these.
        //Traditional approach to take all numbers from numbers array with a value between 1-5, join by words array, take only words which are exactly three letters in length, and then count these.

        public static void LinqPerformance3()
        {
            Random random = new Random();
            int[] numbers = Enumerable.Repeat(0,10000000).Select(i=>random.Next(0, 20)).ToArray();

            // Create an array of anonymously typed elements with numbers 1-5, and spelled out values 
            var words = new[] {
                new { number = 1, word = "one" },
                new { number = 2, word = "two" },
                new { number = 3, word = "three" },
                new { number = 4, word = "four" },
                new { number = 5, word = "five" },
            };

            //Start stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //LINQ approach
            var cntLinq = numbers.Where(n => n >= 1 && n <= 5)
                .Join(words, n => n, w => w.number, (n, w) => new { w.word })
                .Select(w=>w.word.Length==3)
                .Count();

            //stop stopwatch
            stopwatch.Stop();

            //Print result
            Console.Write("Time elapsed for LINQ approach :{0}ms", stopwatch.ElapsedMilliseconds);

            //Restart Stopwatch
            stopwatch.Reset();
            stopwatch.Start();

            //Traditional approach
            int cntTraditional = 0;
            List<string> lstWord = new List<string>();
            foreach (int n in numbers) {
                if (n >= 1 && n <= 5) { 
                    lstWord.Add(words[n-1].word);
                    ++cntTraditional;
                }
            }
            //Stop stopwatch
            stopwatch.Stop();

            //Print result
            Console.Write("Time elapsed for LINQ approach :{0}ms", stopwatch.ElapsedMilliseconds);

            Console.WriteLine(cntLinq == cntTraditional);

        }
    }
}
