using System;

namespace LINQ_Lambda_Query {
    class Program {
        static void Main(string[] args) {
            SimpleLambda();
            SimpleQuery();
            Mix();
        }
        static void SimpleLambda() {
            int[] numbers = { 7, 9, 5, 3, 6 };
            //The Lambda Expression way of Writing LINQ
            var res = numbers.Where(n => n > 5);
            foreach (var n in res) { 
                Console.WriteLine(n);
            }
        }
        static void SimpleQuery() {
            int[] numbers = { 7, 9, 5, 3, 6 };
            //Query Express way of Writing LINQ
            var res = from n in numbers where n>5 select n;

            foreach (var n in res) {
                Console.WriteLine(n);
            }
        }

        static void Mix() { 
            int[] numbers = new int[] { 7, 9, 5, 3, 6 };
            //Lambda and Query Expression Mix
            var res = (from n in numbers where n>5 select n).Sum();
            Console.WriteLine(res);
        }
    }
}