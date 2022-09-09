using System;
namespace C_Sharp_LINQ {
    class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("Normal Data");
            Data();
            Console.WriteLine("Query Result : Using Query Syntax");
            Data_LINQ();
            Console.WriteLine("Query Result : Using Method Syntax");
            Data_LINQ2();
        }
        public static void Data() { 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int i = 0;
            //Display numbers larger than 5
            while (i < numbers.GetLength(0)) {
                if (numbers[i] > 5) { 
                    Console.WriteLine(numbers[i]);
                }
                i++;
            }
        }
        //LINQ Data Sources
        //1. LINQ to Objects : for in-memory collections based on IEnumerable, such as Dictionary and List;
        //2. LINQ to Entities : for Entity Framework on object context.
        //3. LINQ to XML : for in-memory XML documents.
        
        //Examples of Query Structure
        //1. SQL like - Syntax calles Query Expression.
        public static void Data_LINQ() {
            int[] numbers = { 3, 6, 7, 9, 2, 5, 3, 7 };
            var res = from n in numbers where n > 5 select n;

            foreach (int n in res) {
                Console.WriteLine(n);
            }
            
        }
        //2. Method like Approach called - Expression
        public static void Data_LINQ2() {
            int[] numbers = { 7, 53, 45, 99 };
            var res = numbers.Where(n=>n>5).OrderBy(n=>n).Select(n=>n);
            foreach (int n in res)
            {
                Console.WriteLine(n);
            }
        }
    }
}
