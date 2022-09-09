using System;
using System.IO;

namespace Conversion {
    class Program {
        static void Main(string[] args) {
            string[] names = { "John", "Suzy", "Dave" };
            string[] words = { "one", "two", "three", "four", "five", "six" };
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            AsEnumerable(names);
            Cast();
            Sample_OfType();
            Sample_ToArray(numbers);
            Sample_ToList(names);
            Sample_ToLookup(words);
        }

        //AsEnumerable: casts a collection to IEnumerable of same type.
        static void AsEnumerable(string[] names) { 
            var result = names.AsEnumerable();
            Console.WriteLine("Iterating over IEnumrable collection");
            foreach (var name in names) { 
                Console.WriteLine(name);
            }
        }
        //Cast: Casts a collection to a specified type.
        static void Cast() {
            List<Object> vegetables = new List<Object> { "Cucumber", "Tomato", "Broccoli",5};
            var result = vegetables.Cast<Object>();
            //Query
            //var result = from v in vegetables.Cast<string>();
            Console.WriteLine("List of vegetables casted to a simple string array:");
            foreach (var vegetable in result) { 
                Console.WriteLine(vegetable);
            }
        }
        //OfType: Filters elements of specified type in a collection.
        static void Sample_OfType() {
            object[] objects = { "Thomas", 31, 5.02,null, "Joey" };
            var result = objects.OfType<string>();
            //var result = objects.OfType<int>();
            //Query Expression , var result = from o in objects.OfType<string>() select o;
            Console.WriteLine("Objects being of type string have the values:");
            foreach (string str in result) {
                Console.WriteLine(str);
            }
        }
        static void Sample_ToArray(int[] numbers) { 
            var result = numbers.ToArray();
            //var result = from n in numbers.ToArray<int>();
            Console.WriteLine("New array contains identical values");
            foreach (int number in result) { 
                Console.WriteLine(number);
            }
        }
        //ToList: Converts collection into a List
        static void Sample_ToList(string[] names){
            List<string> result = names.ToList();
            Console.WriteLine(string.Format("Name is of type :{0}", names.GetType().Name));
            Console.WriteLine(String.Format("result is og type :{0}",result.GetType().Name));
        }

        //ToLookup: Converts a collection into a Lookup, grouped by key.
        //This Lambda Expression sample puts array elements into a one-to-many Lookup, where key equals element length.

        static void Sample_ToLookup(string[] words) { 
            var result = words.ToLookup(w=>w.Length);
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Element with a length of {0}",i));
                foreach (string word in result[i]) {
                    Console.WriteLine(word);
                }
            }
        }

    }
}
