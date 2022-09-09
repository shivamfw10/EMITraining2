using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101_Practice.DataSource
{
    public class Grouping
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int GroupingSyntax() {
            #region grouping-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numberGroups = from n in numbers
                               group n by n % 5 into g
                               select (Remainder: g.Key, Numbers: g);
            foreach (var g in numberGroups) { 
                Console.WriteLine($"Numbers with a remainder of {g.Remainder} when divided by 5:");
                foreach (var n in g.Numbers) {
                    Console.WriteLine(n);
                }
            }
            #endregion
            return 0;
        }
        public int GroupByCategory() {
            #region groupby-category
            List<Product> products = GetProductList();
            var orderGroup = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, Products: g);
            foreach (var orderGroups in orderGroup) {
                Console.WriteLine($"Products in {orderGroups.Category} category");
                foreach (var product in orderGroups.Products) {
                    Console.WriteLine($"\t{product}");
                }
            }
            #endregion
            return 0;
        }
        public int NestedGroupBy() {
            #region nestedby-group
            List<Customer> customers = GetCustomerList();
            var customerOrderGroups = from c in customers
                                      select (c.CompanyName, YearGroup: from o in c.Orders
                                                                        group o by o.OrderDate.Year into yg
                                                                        select (Year: yg.Key,
                                                                        MonthGroups:from o in yg
                                                                                   group o by o.OrderDate.Month into mg
                                                                                   select (Month: mg.Key,Orders:mg)
                                                                        ));
            foreach (var orderByCustomer in customerOrderGroups) {
                Console.WriteLine($"Customer Name:{orderByCustomer.CompanyName}");
                foreach (var orderByYear in orderByCustomer.YearGroup) {
                    Console.WriteLine($"\tYear:{orderByYear.Year}");
                    foreach (var ordersByMonth in orderByYear.MonthGroups) {
                        Console.WriteLine($"\t\tMonth:{ordersByMonth.Month}");
                        foreach (var order in ordersByMonth.Orders) {
                            Console.WriteLine($"\t\t\tOrder :{order}");
                        }
                    }
                }
            }
            #endregion
            return 0;
        }
        public int GroupByCustomerComparer() {
            #region groupby-custom-comparer
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());
            foreach (var set in orderGroups) {
                //The key would be the first ietm in the set
                foreach (var word in set) { 
                    Console.WriteLine(word);
                }
                Console.WriteLine(".....");
            }
            #endregion
            return 0;

        }
        public int NestedGroupCustom() {
            #region nested-group-custom
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            var orderGroups = anagrams.GroupBy(
                            w=>w.Trim(),
                            a=>a.ToUpper(),
                            new AnagramEqualityComparer());
            foreach (var set in orderGroups) { 
                Console.WriteLine(set.Key);
                foreach (var word in set) {
                    Console.WriteLine($"\t{word}");
                }
            }
            #endregion
            return 0;
        }
        #region anagram-comparer
        public class AnagramEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y) => getCanonicalString(x) == getCanonicalString(y);

            public int GetHashCode(string obj) => getCanonicalString(obj).GetHashCode();

            private string getCanonicalString(string word)
            {
                char[] wordChars = word.ToCharArray();
                Array.Sort<char>(wordChars);
                return new string(wordChars);
            }
        }
        #endregion
    }
}
