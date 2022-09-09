using System;

namespace Projection {
    class Program
    {
        static void Main(string[] args){
            decimal[] numbers = { 3.4M, 8.33M, 5.225M };
            double[] angles = { 30D, 60D, 90D };
            string[] words = { "One", "Two", "Three" };
            Console.WriteLine("************************** Select Simple **********************");
            Sample_Select_Simple(numbers);
            Console.WriteLine("************************** Select Anonymous Type **********************");
            Sample_Select_AnonymousType(angles);
            Console.WriteLine("************************** Select Indexed **********************");
            Sample_Select_Indexed(words);
            Console.WriteLine("************************** Select Many **********************");
            Sample_SelectMany();
        }
        //Select: Selects, projects and transforms elements in a collection.
        //This Lambda Expression sample selects and rounds down each number in array.
        static void Sample_Select_Simple(decimal[] numbers) {
           
            //Lambda Expression
            var result = numbers.Select(n=>Math.Floor(n));
            //Query Expression
            var result1 = from n in numbers select Math.Floor(n);
            Console.WriteLine("Numbers rounded down");
            foreach (int number in result) { 
                Console.WriteLine(number);
            }
        }
        //Select: Selects, projects and transforms elements in a collection.
        //This Lambda Expression sample selects and rounds down each number in array.
        //this Query Expression sample selects and rounds down each number in array.

        static void Sample_Select_AnonymousType(double[] angles) {

            var result = angles.Select(a => new { Angle = a, Cos = Math.Cos(a), Sin = Math.Sin(a) });
            var result1 = from a in angles
                         select new { Angle = a, Cos = Math.Cos(a), Sin = Math.Sin(a) };

            Console.WriteLine("Calculated values:");
            foreach (var res in result)
                Console.WriteLine(String.Format("Angle {0}: Cos = {1}, Sin = {2}", res.Angle, res.Cos, res.Sin));

        }
        //Select: Selects, projects and transforms elements in a collection. Can be overloaded to get element index.
        //This Lambda Expression sample selects word and element index from array.
        static void Sample_Select_Indexed(string[] words)
        {
            var result = words.Select((w, i) => new { Index = i,Value=w });
            Console.WriteLine("Words with index and value:");
            foreach (var word in result) {
                Console.WriteLine(String.Format("Index {0} is {1}", word.Index, word.Value));
            }
        }
        //	SelectMany: Flattens collections into a single collection (similar to cross join in SQL).
        //This Lambda Expression sample cross joins two arrays, and gets cartesian product.
        static void Sample_SelectMany() {
            string[] fruits = { "Grape", "Orange", "Apple" };
            int[] amounts = { 1, 2, 3 };
            var result = fruits.SelectMany(f => amounts, (f, a) => new
            {
                Fruit = f,
                Amount = a
            });
            Console.WriteLine("Selecting all values from each array, and mixing them:");
            foreach (var o in result) {
                Console.WriteLine(o.Fruit + "," + o.Amount);
            }
        }

    }
}