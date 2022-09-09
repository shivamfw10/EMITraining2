using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101_Practice.DataSource
{
    public class SetOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int DistinctSyntax() {
            #region distinct-syntax
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            var uniqueFactors = factorsOf300.Distinct();
            Console.WriteLine("Prime factors of 300");
            foreach (var f in uniqueFactors) { 
                Console.WriteLine(f);
            }
            #endregion
            return 0;
        }
        public int DistinctPropertyValues() {
            #region distinct-property-values
            List<Product> products = GetProductList();
            var categoryNames = (from p in products select p.Category).Distinct();
            Console.WriteLine("Category Names");
            foreach (var n in categoryNames) { 
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
        public int UnionSyntax() {
            #region union-syntax
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var uniqueNumbers = numbersA.Union(numbersB);
            Console.WriteLine("Unique Numbers from both arrays");
            foreach (var n in uniqueNumbers) {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
        public int UnionOfQueryResults() {
            #region union-query-result
            List<Product> products = GetProductList();
            List<Customer> customers = GetCustomerList();
            var productFirstChars = from p in products
                                    select p.ProductName[0];
            var customerFirstChar = from c in customers
                                    select c.CompanyName[0];
            var uniqueFirstChars = productFirstChars.Union(customerFirstChar);
            Console.WriteLine("Unique first letters from product names and Customer names");
            foreach (var ch in uniqueFirstChars) {
                Console.WriteLine(ch);
            }
            #endregion
            return 0;
        }
        public int IntersectSyntax() {
            #region intersect-syntax
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var commonNumbers = numbersA.Intersect(numbersB);
            Console.WriteLine("Common numbers shared by both arryas");
            foreach (var n in commonNumbers) { 
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
        public int IntersectQueryResults() {
            #region intersect-different-queries
            List<Product> products = GetProductList();
            List<Customer> customers = GetCustomerList();
            var productFirstChars = from p in products
                                    select p.ProductName[0];
            var customerFirstChars = from c in customers
                                     select c.CompanyName[0];
            var commonFirstChars = productFirstChars.Intersect(customerFirstChars);
            Console.WriteLine("Common first letters from Product names and Customer names:");
            foreach (var ch in commonFirstChars) {
                Console.WriteLine(ch);
            }
            #endregion
            return 0;
        }
        public int DifferenceOfSets() {
            #region except-syntax
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);
            Console.WriteLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers) {
                Console.WriteLine(n);
            }   
            #endregion
            return 0;
        }
        public int DifferenceOfQueries() {
            #region difference-of-queries
            List<Product> products = GetProductList();
            List<Customer> customers = GetCustomerList();
            var productFirstChars = from p in products
                                    select p.ProductName[0];
            var customerFirstChars = from c in customers
                                     select c.CompanyName[0];
            var productOnlyFirstChars = productFirstChars.Intersect(customerFirstChars);
            Console.WriteLine("First letters from Product names,but not from Customer names");
            foreach (var ch in productFirstChars) {
                Console.WriteLine(ch);
            }
            #endregion
            return 1;
        }
    }
}
