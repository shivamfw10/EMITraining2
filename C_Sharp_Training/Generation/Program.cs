using System;
namespace Generation {
    class Program {
        static void Main(string[] args) {
            string[] emptyStr = { };
            int[] emptyInt = { };
            string[] words = { "One", "Two", "Three" };
            Console.WriteLine("************************** DefaultIfEmpty **********************");
            Sample_DefaultIfEmpty(emptyStr, emptyInt, words);
            Console.WriteLine("************************** DefaultIfEmpty with Default value **********************");
            Sample_DefaultIfEmpty(emptyStr);
            Console.WriteLine("************************** Empty **********************");
            Sample_Empty();
            Console.WriteLine("************************** Range **********************");
            Sample_Range();
            Console.WriteLine("************************** Repeat **********************");
            Sample_Repeat();
        }
        //DefaultIfEmpty: If a collection is empty, its default value is returned. Default value depends on collection type.
        //This Lambda Expression sample returns default values for each of the empty collections, while "words" array is returned as is.
        static void Sample_DefaultIfEmpty(string[] emptyStr,int[] emptyInt,string[] words) {
            var resultStr = emptyStr.DefaultIfEmpty();//Default is null for string
            var resultInt = emptyInt.DefaultIfEmpty();//Default is 0 for Int
            var resultwords = words.DefaultIfEmpty();//Not empty, so words array is just copied

            Console.WriteLine("resultStr has one element with a value of null:");
            Console.WriteLine(resultStr.Count()==1 && resultStr.First()==null);
            Console.WriteLine("resultInt has one element with a value of 0 :");
            Console.WriteLine(resultInt.Count()==1 && resultInt.First()==0);
            Console.WriteLine("resultWords has same content as words array:");
            Console.WriteLine(resultwords.SequenceEqual(words));

        }

        static void Sample_DefaultIfEmpty(string[] emptystr) { 
            var result = emptystr.DefaultIfEmpty("Hello");
            Console.WriteLine("result contains one element with a value of Hello");
            Console.WriteLine(result.Count()==1 && result.First()=="Hello");
        }

        //Empty: Generates an empty collection (with no elements).
        //This Lambda Expression sample creates an empty sequence of type string.
        static void Sample_Empty() { 
            var result = Enumerable.Empty<string>();
            //To make sequence into an array use empty.ToArray();
            Console.WriteLine("Sequence is Empty :");
            Console.WriteLine(result.Count()==0);
        }
        //Range: Generates sequence of numeric values.
        //This Lambda Expression sample generates sequence within a range from 0-10.
        static void Sample_Range() { 
            var result = Enumerable.Range(0,10);
            Console.WriteLine("Counting from 0 to ");
            foreach (int number in result) {
                Console.WriteLine(number);
            }
        }

        //	Repeat: Creates a collection of repeated elements, where first argument is value to repeat, and second argument is number of times to repeat.
        //This Lambda Expression sample repeats the word "Banana" 5 times.
        static void Sample_Repeat() {
            string word = "Hello";
            var result = Enumerable.Repeat(word, 10);
            Console.WriteLine("String is repeated  5 times");
            foreach (string str in result) { 
                Console.WriteLine(str);
            }
        }
    }
}