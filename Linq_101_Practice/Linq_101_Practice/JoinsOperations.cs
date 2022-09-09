using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101_Practice.DataSource
{
    public class JoinsOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int OrderBySyntax() {
            #region orderdy-syntax
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from word in words
                              orderby word
                              select word;
            Console.WriteLine($"The sorted list of words");
            foreach (var w in sortedWords) {
                Console.WriteLine(w);
            }
            #endregion
            return 0;
        }
        public int OrderByProperty() {
            #region
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from word in words
                              orderby words.Length
                              select word;
            Console.WriteLine($"The sorted list according to word length");
            foreach (var w in sortedWords) {
                Console.WriteLine(w);
            }
            #endregion
            return 0;
        }
        public int OrderByProducts() {
            #region orderby-product-types
            List<Product> products = GetProductList();
            var sortedProducts = from prod in products
                                 orderby prod.ProductName
                                 select prod;
            //list sorted by product Name
            foreach (var product in sortedProducts) { 
                Console.WriteLine(product);
            }
            #endregion
            return 0;
        }
        //#region custom-comparer
        //Custom comparer for use with ordering operators
        //public class CaseInsensitiveCompaere : IComparer<string>
        //{
        //    public int compare(string x, string y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        //}
        //#endregion
        //public int OrderByWithCustomComparer()
        //{
        //    #region orderby-custom-comparer
        //    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //    var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

        //    foreach (var word in sortedWords)
        //    {
        //        Console.WriteLine(word);
        //    }
        //    #endregion
        //    return 0;
        //}
        public int OrderByDescendingSyntax() {
            #region orderbydescending-syntax
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var sortedDoubles = from d in doubles
                                orderby d descending
                                select d;
            Console.WriteLine("the doubles from highest to lowest");
            foreach (var d in sortedDoubles) { 
                Console.WriteLine(d);
            }
            #endregion
            return 0;
        }
        public int OrderProductsDescending() {
            #region orderby-descending-type
            List<Product> products = GetProductList();
            var sortedProducts = from prod in products
                                 orderby prod.UnitsInStock descending
                                 select prod;
            foreach (var product in sortedProducts) {
                Console.WriteLine(product);
            }
            #endregion
            return 0;
        }
        //public int DescendingCustomComparer()
        //{
        //    #region desc-custom-comparer
        //    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //    var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());

        //    foreach (var word in sortedWords)
        //    {
        //        Console.WriteLine(word);
        //    }
        //    #endregion
        //    return 0;
        //}
        public int ThenBySyntax() {
            #region theby-syntax
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedDigits = from digit in digits
                               orderby digits.Length,digit
                               select digit;
            Console.WriteLine("Sorted Digits");
            foreach (var d in sortedDigits) {
                Console.WriteLine(d);
            }
            #endregion
            return 0;
        }
        //public int ThenByCustom()
        //{
        //    #region thenby-custom
        //    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //    var sortedWords = words
        //        .OrderBy(a => a.Length)
        //        .ThenBy(a => a, new CaseInsensitiveComparer());

        //    foreach (var word in sortedWords)
        //    {
        //        Console.WriteLine(word);
        //    }
        //    #endregion
        //    return 0;
        //}
        public int ThenByDefaultOrdering() {
            #region thenby-ordering
            List<Product> products = GetProductList();
            var sortedProducts = from prod in products
                                 orderby prod.Category, prod.UnitPrice descending
                                 select prod;
            foreach (var product in sortedProducts) { 
                Console.WriteLine(product);
            }
            #endregion
            return 0;
        }
        //public int CustomThenByDescending()
        //{
        //    #region thenby-custom-descending
        //    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //    var sortedWords = words
        //        .OrderBy(a => a.Length)
        //        .ThenByDescending(a => a, new CaseInsensitiveComparer());

        //    foreach (var word in sortedWords)
        //    {
        //        Console.WriteLine(word);
        //    }
        //    #endregion
        //    return 0;
        //}
        public int OrderingReversal() {
            #region reverse
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var reverseIDigits = (from d in digits
                                  where d[1]=='i'
                                  select d).Reverse();
            Console.WriteLine("A backwards list of the digits with a second character of 'i'");
            foreach (var d in reverseIDigits) {
                Console.WriteLine(d);
            }
            #endregion
            return 0;
        }

    }
}
