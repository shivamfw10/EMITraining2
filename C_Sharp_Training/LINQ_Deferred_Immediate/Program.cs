namespace LINQ_Deferred_Immediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Example : 1 ***********");
            DeferredExample();
            Console.WriteLine("**********Example : 2 ***********");
            DeferredExample1();
            Console.WriteLine("**********Example : 3 ***********");
            DeferredExample2();
            Console.WriteLine("**********Example : 4 ***********");
            ImmediateExample();
        }

        //Deferred Execution
        //AsEnumerable, Cast, Concat, DefaultIfEmpty, Distinct, Except, GroupBy, GroupJoin, Intersect,
        //Join, OfType, OrderBy, OrderByDescending, Range, Repeat, Reverse, Select, SelectMany, Skip,
        //SkipWhile, Take, TakeWhile, ThenBy, ThenByDescending, Union, Where.
        //Source : https://linqsamples.com/tutorials/deferred-and-immediate-execution-in-linq
        public static void DeferredExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var result = numbers.Where(n => n >= 2 && n <= 4);//Lamda Expression
            Console.WriteLine(result.Max());
        }

        //Chained Operation
        //(Select(),then Where() and ToList())
        public static void DeferredExample1()
        {
            string[] words = { "one", "two", "three" };
            var result = words.Select((w, i) => new { Index = i, Value = w }).Where(w => w.Value.Length == 3).ToList();
            foreach (var word in result)
            {
                Console.WriteLine(word.Index.ToString());//Print Index for words that have a string length of 3;
            }
        }

        public static void DeferredExample2()
        {
            List<string> vegetables = new List<string> { "Carrot", "Selleri" };
            var result = from v in vegetables select v;
            Console.WriteLine("Element in vegetables array(before add)\n" + "Count " + result.Count());

            vegetables.Add("Broccoli");
            Console.WriteLine("Elements in Vegetable array(after add\n" + "Count " + result.Count());
        }

        public static void ImmediateExample() { 
            int[] numbers = { 1, 5, 10, 18, 23 };
            var baseQuery = from n in numbers select n;
            var oddQuery = from b in baseQuery where b%2==1 select b;
            Console.WriteLine("Sum of Odd numbers :" + " " + oddQuery.Sum());

            var evenQuery = from c in baseQuery where c%2!=1 select c;
            Console.WriteLine("Sum of even numbers :"+evenQuery.Sum());
        }
        //Immediate Execution
        //Aggregate, All, Any, Average, Contains, Count, ElementAt, ElementAtOrDefault, Empty, First,
        //FirstOrDefault, Last, LastOrDefault, Max, LongCount, Min, SelectMany, SequenceEqual, Single,
        //SingleOrDefault, Sum, ToArray, ToDictionary, ToList, ToLookup.
    }
}