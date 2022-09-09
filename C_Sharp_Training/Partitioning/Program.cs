using System;
namespace Partitioning {
    class Program {
        static void Main(string[] args) {
            string[] words = { "one", "two", "three", "four", "five", "six" };
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("************************** Skip **********************");
            Sample_Skip(words);
            Console.WriteLine("************************** SkipWhile **********************");
            Sample_SkipWhile(words);
            Console.WriteLine("************************** Take **********************");
            Sample_Take(words);
            Console.WriteLine("************************** TakeWhile **********************");
            Sample_TakeWhile(numbers);
        }
        //Skip: Skips specified number of elements in a collection.
        //This Lambda Expression sample skips first 4 words in array.
        static void Sample_Skip(string[] words) {
            
            //lambda Expresison
            var result = words.Skip(4);
            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in result) {
                Console.WriteLine(word);
            }

        }
        //SkipWhile: Skips elements in a collection while specified condition is met.
        //This Lambda Expression sample skips words in array, as long as word has length of 3 characters.
        static void Sample_SkipWhile(string[] words) {
            var result = words.SkipWhile(w => w.Length == 3);//Skip while from starting
            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result) {
                Console.WriteLine(word);
            }
        }
        //Take: Takes specified number of elements in a collection, starting from first element.
        //This Lambda Expression sample takes only 5 first numbers in array.

        static void Sample_Take(string[] words) {
            var result = words.Take(5);
            Console.WriteLine("Takes the first 5 numbers only:");
            foreach (string word in result) {
                Console.WriteLine(word);
            }
        }
        //akeWhile: Takes elements in a collection while specified condition is met, starting from first element.
        //This Lambda Expression sample takes numbers from array, while number is less than 5.
        static void Sample_TakeWhile(int[] numbers) {
            var result = numbers.TakeWhile(n => n < 5);
            var result1 = numbers.TakeLast(5);
            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int n in result) { 
                Console.WriteLine(n);
            }
        }

    }
}
