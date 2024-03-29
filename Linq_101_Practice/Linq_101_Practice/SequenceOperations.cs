﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101_Practice.DataSource
{
    public class SequenceOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;
        
        public int EqualSequence()
        {
            #region equal-sequence
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };
            bool match = wordsA.SequenceEqual(wordsB);
            Console.WriteLine($"The sequence match : {match}");
            #endregion
            return 0;
        }
        public int Linq97() {
            #region not-equal-sequence
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };
            bool match = wordsA.SequenceEqual(wordsB);
            Console.WriteLine($"The sequence match :{match}");
            #endregion
            return 0;
        }
        public int ConcatSeries() {
            #region concat-series
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var allNumbers = numbersA.Concat(numbersB);
            Console.WriteLine("All numbers from both arryas");
            foreach (var n in allNumbers) { 
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
        public int ConcatProjections() {
            #region concat-projections
            List<Customer> customers = GetCustomerList();
            List<Product> products = GetProductList();
            var customerNames = from c in customers
                                select c.CompanyName;
            var productsNames = from p in products
                                select p.ProductName;
            var allNames = customerNames.Concat(productsNames);
            Console.WriteLine("Customer and Product Names");
            foreach (var n in allNames) { 
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
        public int DotProduct() {
            #region dot-product
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };
            int dotProduct = vectorA.Zip(vectorB,(a,b)=>a*b).Sum();
            Console.WriteLine($"Dot product:{dotProduct}");
            #endregion
            return 0;
        }
    }
}
