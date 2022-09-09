using System;

namespace Element {
    class Program {
        static void Main(string[] args) {
            string[] words = { "one", "two", "three", "four", "five", "six" };
            string[] color = { "red", "blue", "green" };
            string[] fruits = { "Banana", "Apple", "Orange", "Papaya" };
            string[] emptyArray = { };
            string[] singleName = { "Shivam" };
            Console.WriteLine("*********Exmaple : ElementAT *********");
            Sample_ElementAt(words);
            Console.WriteLine("*********Exmaple : ElementAtOrDefault *********");
            Sample_ElementAtOrDefault(color);
            Console.WriteLine("*********Exmaple : First *********");
            Sample_First(fruits);
            Console.WriteLine("*********Exmaple : First with Conditional *********");
            Sample_First_Conditional(words);
            Console.WriteLine("*********Exmaple : FirstOrDefault *********");
            Sample_FirstOrDefault(words);
            Console.WriteLine("*********Exmaple : Last *********");
            Sample_Last(words);
            Console.WriteLine("*********Exmaple : LastOrDefault_Simple*********");
            Sample_LastorDefault_Simple(words);
            Console.WriteLine("*********Exmaple : Last_Default_Conditional*********");
            Sample_LastOrDefault_Conditional(words);
            Console.WriteLine("*********Exmaple : Single*********");
            Sample_Single(emptyArray, words, singleName);
            Console.WriteLine("*********Exmaple : SingleOrDeault*********");
            Sample_SingleOrDefault(emptyArray, words, singleName);
        }
        //ElementAt: Retrieves element from a collection at specified (zero-based) index.
        static void Sample_ElementAt(string[] words) { 
            var result = words.ElementAt(1);
            Console.WriteLine("Element at Index 1 in the array is"+" "+result);
        }

        //ElementAtOrDefault: Retrieves element from a collection at specified (zero-based) index, but gets default value if out-of-range.
        //This Lambda Expression sample retrieves elements at index 1 and 10 from array, and because index 10 is out-of-range, it gets default value(null).

        static void Sample_ElementAtOrDefault(string[] color) { 
            var resultIndex1 = color.ElementAtOrDefault(1);
            var resultIndex10 = color.ElementAtOrDefault(10);
            Console.WriteLine("Element at index 1 in the array contains"+" "+resultIndex1);
            Console.WriteLine("Element at index 1 in the array does not exist");
            Console.WriteLine(resultIndex10 == null);
        }

        //First: Retrieves first element from a collection. Throws exception if collection is empty.
        // This Lambda Expression sample retrieves first element from an array.
        static void Sample_First(string[] fruits) { 
            var result = fruits.First();
            Console.WriteLine("First element in the array is:"+" "+result);
        }

        //	First: Retrieves first element from a collection. Throws exception if collection is empty.
        //  This Lambda Expression sample takes first element from collection which is 6 characters long.
        static void Sample_First_Conditional(string[] words) {
            var result = words.First(c => c.Length == 5);
            Console.WriteLine("First element with a length of 6 characters:" + " " + result);
        }
        //FirstOrDefault: Retrieves first element from a collection, or default value if collection is empty.
        //This Lambda Expression sample retrieves first element from "countries" array, but from "empty" array it gets default value(null).
        static void Sample_FirstOrDefault(string[] words) {
            string[] empty = { };
            var result = words.FirstOrDefault();
            var resultEmpty = empty.FirstOrDefault();
            Console.WriteLine("First element in the countries array contains:"+" "+result);
            Console.WriteLine("First element in the empty array does not exits");
            Console.WriteLine(resultEmpty==null);
        }
        //Last: Retrieves last element from a collection. Throws exception if collection is empty.
        static void Sample_Last(string[] words) { 
            var result = words.Last();
            Console.WriteLine("Last number in the array is : " + " " + result);
        }
        //LastOrDefault: Retrieves last element from a collection, or default value if collection is empty.
        //    This Lambda Expression sample retrieves last element from words array, but from empty array it gets default value(null).
        static void Sample_LastorDefault_Simple(string[] words) {
            string[] empty = { };
            var result = words.LastOrDefault();
            var resultEmpty = empty.LastOrDefault();
            Console.WriteLine("Last elememt in the words array contains" + " " + result);
            Console.WriteLine("Last element in the empty array dcoes not exits");
            Console.WriteLine(resultEmpty==null);
        }
        //LastOrDefault: Retrieves last element from a collection, or default value if collection is empty.
        //This Lambda Expression sample retrieves last element from "words" array having a length of 3 and 2 respectively.
        //As no elements have a length of 2, "resultNoMatch" array gets default value(null)
        static void Sample_LastOrDefault_Conditional(string[] words) { 
            var result = words.LastOrDefault(w=>w.Length == 3);
            var resultNoMatch = words.LastOrDefault(w=>w.Length == 2);
            Console.WriteLine("Last element in the words array having a length of 3" + " " + result);
            Console.WriteLine("Last element in the words array having a length of 2 does not exits");
            Console.WriteLine(resultNoMatch==null);
        }
        //Single: Retrieves only element in a collection. Throws exception if not exactly one element in collection.
        //This Lambda Expression sample retrieves a single element from each array, but from arrays with not exactly one element it throws exception.
        static void Sample_Single(string[] emptyArray, string[] words, string[] singleName) {
            var result1 = singleName.Single();
            Console.WriteLine("The only name in the array is");
            Console.WriteLine(result1);
            try
            {
                //This will throw an expection because arrya contains elements
                var resultEmpty = emptyArray.Single();
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
            try
            {
                //This will throw an exception as well because array contains more than one element
                var result3 = words.Single();
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
        //SingleOrDefault: Retrieves only element in a collection, or default value if collection is empty.
        //This Lambda Expression sample retrives a single element from array, but from arrays with not exactly one element it gets default value(null).
        static void Sample_SingleOrDefault(string[] singleName,string[] words,string[] emptyArray){
            var result1 = singleName.SingleOrDefault();
            var result2 = emptyArray.SingleOrDefault();
            Console.WriteLine("The only name in the array is" + " " + result1);
            Console.WriteLine("As array is empty, SingleOrDefault yields null");
            Console.WriteLine(result2==null);

            try
            {
                //This will throw an exception as we;; because array contains more than one element
                var result3 = words.SingleOrDefault();
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}