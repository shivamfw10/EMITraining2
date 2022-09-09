using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_101_Practice.DataSource 
{
    public class AggregateOperators {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        //static void Main(string[] args)
        //{
        //    AggregateOperators a = new AggregateOperators();
        //    //a.CountSyntax();
        //    //a.CountConditional();
        //    //a.NestedCount();
        //    //a.GroupedCount();
        //    //a.SumSyntax();
        //    //a.SumProjection();
        //    //a.SumGrouped();
        //    //a.MinSyntax();
        //    //a.MinProjection();
        //    //a.MinGrouped();
        //    //a.MinEachGroup();
        //    //a.MaxSyntax();
        //    //a.MaxProjection();
        //    //a.MaxGrouped();
        //    //a.MaxEachGroup();
        //    //a.AverageSyntax();
        //    //a.AverageProgection();
        //    //a.AverageGroup();
        //    //a.AggregateSyntax();
        //    //a.SeededAggregate();
            
        //}
        public int CountSyntax() {
            #region count-syntax
            int[] factorsof300 = { 2, 2, 3, 5, 5 };
            int uniqueFactors = factorsof300.Distinct().Count();
            Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
            #endregion
            return 0;
        }
        public int CountConditional() {
            #region count-conditional
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine("There are {0} odd numbers in the list",oddNumbers);
            #endregion
            return 0;
        }
        public int NestedCount() {
            #region nested-count
            List<Customer> customers = GetCustomerList();
            var orderCounts = from c in customers select (c.CustomerID,OrderCount:c.Orders.Count());
            foreach (var customer in orderCounts) {
                Console.WriteLine($"ID :{customer.CustomerID},count:{customer.OrderCount}");
            }
            #endregion
            return 0;
        }
        public int GroupedCount() {
            #region grouped-count
            List<Product> products = GetProductList();
            var categoryCounts = from p in products
                                 group p by p.Category into g
                                 select (Category: g.Key, ProductCount: g.Count());
            foreach (var c in categoryCounts) { 
                Console.WriteLine($"Category:{c.Category},Product Count :{c.ProductCount}");
            }
            #endregion
            return 0;
        }
        public int SumSyntax() {
            #region sum-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            double numSum = numbers.Sum();
            Console.WriteLine($"The sum of the numbers is {numSum}");
            #endregion
            return 0;
        }
        public int SumProjection() {
            #region sum-of-projection
            string[] words = { "cherry", "apple", "blueberry" };
            double tottalChars = words.Sum(w => w.Length);
            Console.WriteLine($"There are a totoal of {tottalChars} characters in these words");
            #endregion
            return 0;
        }
        public int SumGrouped() {
            #region grouped-sum
            List<Product> products = GetProductList();
            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, TotalUnitsInStock: g.Sum(p => p.UnitsInStock));
            foreach (var pair in categories) { 
                Console.WriteLine($"Category:{pair.Category},Units in stock :{pair.TotalUnitsInStock}");
            }
            #endregion
            return 0;
        }
        public int MinSyntax() {
            #region min-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int minNum = numbers.Min();
            Console.WriteLine($"The minimum number us {minNum}");
            #endregion
            return 0;
        }
        public int MinProjection() {
            #region min-projection
            string[] words = { "Cherry", "Apple", "Blueberry" };
            int shortedWord = words.Min(w=>w.Length);
            Console.WriteLine($"The shortest word is {shortedWord} characters long");
            #endregion
            return 0;
        }
        public int MinGrouped() {
            # region min-each-group
            List<Product> products = GetProductList();
            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, CheapestPrice: g.Min(p=>p.UnitPrice));

            foreach (var c in categories) {
                Console.WriteLine($"Category:{c.Category},Lowest Price:{c.CheapestPrice}");
            }
            #endregion
            return 0;
        }
        public int MinEachGroup() {
            #region min-each-group
            List<Product> products = GetProductList();
            var categories = from p in products
                             group p by p.Category into g
                             let minPrice = g.Min(p => p.UnitPrice)
                             select (Category: g.Key, CheapestProduct: g.Where(p => p.UnitPrice == minPrice));

            foreach (var c in categories) {
                Console.WriteLine($"Categoey:{c.Category}");
                foreach (var p in c.CheapestProduct) {
                    Console.WriteLine($"\tProduct:{p}");
                }
            }
            #endregion
            return 0;
        }
        public int MaxSyntax() {
            #region max-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int maxNum = numbers.Max();
            Console.WriteLine($"The maximum numbers is {maxNum}");
            #endregion
            return 0;
        }
        public int MaxProjection() {
            #region max-projection
            string[] words = { "Cherry", "Apple", "Blueberry"};
            int longestLength = words.Max(w => w.Length);
            Console.WriteLine($"The longest word is {longestLength} character long");
            #endregion
            return 0;
        }
        public int MaxGrouped() {
            #region max-grouped
            List<Product> products = GetProductList();
            var categories = from p in products
                             group p by p.Category into g
                             select (Category:g.Key,MostExpensivePrice:g.Max(p=>p.UnitPrice));
            foreach (var c in categories) {
                Console.WriteLine($"Category:{c.Category} Most expensive producr:{c.MostExpensivePrice}");
            }
            #endregion
            return 0;
        }
        public int MaxEachGroup() {
            #region max-each-group
            List<Product> products = GetProductList();
            var categogies = from p in products
                             group p by p.Category into g
                             let maxPrice = g.Max(p => p.UnitPrice)
                             select (Category: g.Key, MostExpensiveProducts: g.Where(p => p.UnitPrice == maxPrice));
            foreach (var c in categogies) {
                Console.WriteLine($"Category:{c.Category}");
                foreach(var p in c.MostExpensiveProducts)
                {
                    Console.WriteLine($"\t{p}");
                }
            }
            #endregion
            return 0;
        }
        public int AverageSyntax() {
            #region average-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            double averageNum = numbers.Average();
            Console.WriteLine($"The average numbers is {averageNum}");
            #endregion
            return 0;
        }
        public int AverageProgection() {
            #region average-projection
            string[] words = { "cherry", "apple", "blueberry" };
            double averageLength = words.Average(w=>w.Length);
            Console.WriteLine($"The average word length is {averageLength} characters");
            #endregion
            return 0;
        }
        public int AverageGroup() {
            #region average-grouped
            List<Product> products = GetProductList();
            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, AveragePrice: g.Average(p => p.UnitPrice));
            foreach (var c in categories) {
                Console.WriteLine($"Category:{c.Category},Average Price:{c.AveragePrice}");
            }
            #endregion
            return 0;
        }
        public int AggregateSyntax() {
            #region aggregate-syntax
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            double products = doubles.Aggregate((runningProduct,nextFactor)=>runningProduct*nextFactor);
            Console.WriteLine($"Total product of all numbers :{products}");
            #endregion
            return 0;
        }
        public int SeededAggregate() {
            #region aggregate-seeded
            double startBalence = 100.0;
            int[] attemptWithdrawls = { 20, 10, 40, 50, 10, 70, 30 };
            double endBalence = attemptWithdrawls.Aggregate(startBalence, (balence, nextwithdrawal) => ((nextwithdrawal <= balence) ? (balence - nextwithdrawal) : balence));
            Console.WriteLine($"Ending balence :{endBalence}");
            #endregion
            return 0;
        }
    
    }
    
}
