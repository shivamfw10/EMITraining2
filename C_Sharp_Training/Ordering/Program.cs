using System;

namespace Ordering {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("************************** Order By Numbers **********************");
            Sample_OrderBy_Number();
            Console.WriteLine("************************** Order By Date **********************");
            Sample_OrderBy_Dates();
            Console.WriteLine("************************** Order By Object **********************");
            Sample_OrderBy_Object();
            Console.WriteLine("************************** OrderByDescending **********************");
            Sample_OrderByDescending();
            Console.WriteLine("************************** OrderBy ThenBy **********************");
            Sample_ThenBy();
            Console.WriteLine("************************** OrderBy ThenByDescending **********************");
            Sample_ThenByDescending();
        }

        //	OrderBy: Sorts a collection in ascending order.
        //This Lambda Expression sample sorts array of numbers in ascending order.

        static void Sample_OrderBy_Number() { 
            int[] numbers = {2,3,1};  
            //Lambda Expression
            var result = numbers.OrderBy(x => x);
            //Query Expression
            var result1 = from n in numbers orderby n select n;
            Console.WriteLine("Ordered list of numbers");
            foreach (int number in result) {
                Console.WriteLine(number);
            }
        }
        //OrderBy: Sorts a collection in ascending order.
        //This Lambda Expression sample sorts array of dates in ascending order.
        static void Sample_OrderBy_Dates(){
            var dates = new DateTime[] {
                new DateTime(2015,2,15),
                new DateTime(2015,3,25),
                new DateTime (2015,1,5)
            };
            //Lambda Expression
            var result = dates.OrderBy(x => x);
            //Query Expression
            var result1 = from date in dates orderby date select date;
            Console.WriteLine("Ordered list of Dates");
            foreach (DateTime dt in result) { 
                Console.WriteLine(dt);
            }

        }

        //OrderBy: Sorts a collection in ascending order.
        //This Lambda Expression sample sorts array of cars by "HorsePower", in ascending order.
        static void Sample_OrderBy_Object() {
            Car[] cars = {
                new Car { Name="Super Car",HorsePower=125,Average=10 },
                new Car { Name="Economy Car",HorsePower=75,Average=15},
                new Car { Name="Family Car",HorsePower=50,Average=20}
            };
            //Lambda Expression
            var result = cars.OrderBy(c=>c.HorsePower);

            //Query Expression
            var result1 = from car in cars orderby car select car;
            Console.WriteLine("Ordered list of cars by horsepower");
            foreach (Car car in result) {
                Console.WriteLine(String.Format("{0} :: {1} horses {2} Average", car.Name, car.HorsePower,car.Average));
                //Console.WriteLine($"{car.Name},{car.HorsePower}, {car.Average}");
            }
        }
        //OrderByDescending: Sorts a collection in descending order.
        //This Lambda Expression sample sorts array of names in descending order.
        //This Query Expression sample sorts array of names in descending order.
        static void Sample_OrderByDescending() {
            string[] names = { "Ned", "Ben", "Susan" };

            //Lambda Expression
            var result = names.OrderByDescending(x => x);

            //Query Expression
            var result1 = from name in names orderby name descending select name; 
            Console.WriteLine("Descending ordered list of names");
            foreach (string name in result1) { 
                Console.WriteLine(name);
            }
        }
        //Reverse: Reverses elements in a collection.
        //This Lambda Expression sample reverts characters in array.
        //This Query Expression sample reverts characters in array.

        static void Sample_Reverse() {
            char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };
            //Lambda Expression
            var result = characters.Reverse();

            //Query Expression
            var result1 = from c in characters.Reverse() select c;
            Console.WriteLine("Characters in reverse order");
            foreach (char c in result) { 
                Console.WriteLine(c);
            }
        }
        //ThenBy: Use after earlier sorting, to further sort a collection in ascending order.
        //This Lambda Expression sample first sorts array by string length of city capital, and then by alphabet.
        //This Query Expression sample first sorts array by string length of city capital, and then by alphabet.
        static void Sample_ThenBy() {
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London", "Athens", "Seol" };
            //Lambda Expression
            var result = capitals.OrderBy(c=>c.Length).ThenBy(c=>c);

            //Query Expression
            var result1 = (from c in capitals orderby c.Length select c).ThenBy(c=>c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabet");
            foreach (string capital in result) {
                Console.WriteLine(capital);
            }
        }
        //ThenByDescending: Use after earlier sorting, to further sort a collection in descending order.
        //This Lambda Expression sample first orders a list of dates by year descending, and then by month descending.
        static void Sample_ThenByDescending() {
            var dates = new DateTime[] {
                new DateTime(2015, 3, 1),
                new DateTime(2014, 7, 1),
                new DateTime(2013, 5, 1),
                new DateTime(2015, 1, 1),
                new DateTime(2015, 7, 1)
            };
            //Lambda Expression
            var result = dates.OrderByDescending(d=>d.Year).ThenByDescending(d=>d.Month);

            //Query Expression
            var result1 = from d in dates orderby d.Year descending, d.Month descending select d;

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime d in result) {
                Console.WriteLine(d.ToString("yyyy/MM/dd"));
            }
        }
    }
}