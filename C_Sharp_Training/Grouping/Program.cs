using System;

namespace Grouping {
    class Program {
        static void Main(string[] args) {
            int[] numbers  = {10, 15, 20, 25, 30, 35, 40};
            Console.WriteLine("************************** Group By **********************");
            Sample_GroupBY(numbers);
        }
        //GroupBy: Projects elements of a collection into groups by key.
        //This Lambda Expression sample splits array of numbers into two groups: one which is divisible by 10, and one which is not.

        static void Sample_GroupBY(int[] numbers) {
            var result = numbers.GroupBy(n => (n % 10 == 0));
            Console.WriteLine("Group has created two groups");
            foreach (IGrouping<bool, int> group in result) {
                if (group.Key == true)
                {
                    Console.WriteLine("Divisble by 0");
                }
                else {
                    Console.WriteLine("Not Divisble by 10");
                }
                foreach (int number in group) { 
                    Console.WriteLine(number);
                }
            }
        }
    }
}