using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101_Practice.DataSource
{
    public class ElementOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int FirstElement() {
            #region-element
            List<Product> products = GetProductList();
            Product products12 = (from p in products where p.ProductID==12 select p).First();
            Console.WriteLine(products12);
            #endregion
            return 0;
        }
        public int FirstMatchingElement() {
            #region first-macth-element
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string startWithO = strings.First(s => s[0] == 'o');
            string startWithS = strings.First(s => s[0] == 's');
            Console.WriteLine($"A string starting with 'o':{startWithO}");
            Console.WriteLine($"A string starting with 's':{startWithS}");
            #endregion
            return 0;

        }
        public int MaybeFirstElement() {
            #region maybe-first-element
            int[] numbers = { };
            int firstNumOrDefualt = numbers.FirstOrDefault();
            Console.WriteLine(firstNumOrDefualt);
            #endregion
            return 0;
        }
        public int MaybeFirstMatchingElement() {
            #region maybe-first-matching-element
            List<Product> products = GetProductList();
            Product product789 = products.FirstOrDefault(p => p.ProductID == 789);
            Console.WriteLine($"Product 789 exits :{product789!=null}");
            #endregion
            return 0;
        }
        public int ElementAtPosition() {
            #region element-position
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int fourthLowNum = (from n in numbers where n > 5 orderby n select n).ElementAt(1);
            Console.WriteLine($"Second number>5:{fourthLowNum}");
            #endregion
            return 0;
        }
    }
}
