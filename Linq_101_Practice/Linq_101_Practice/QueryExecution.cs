using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101_Practice.DataSource
{
    public class QueryExecution
    {
        public int DeferredExecution() {
            #region deferred-execution
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int i = 0;
            var q = from n in numbers
                    select ++i;
            foreach (var v in q) { 
                Console.WriteLine($"v={v},i={i}");
            }
            #endregion
            return 0;
        }
        public int EagerExecution() {
            #region eager-execution
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int i = 0;
            var q = (from n in numbers select ++i).ToList();
            foreach (var v in q) {
                Console.WriteLine($"v={v},i={i}");
            }
            #endregion
            return 0;
        }
        public int ReuseQueryDefinition() {
            #region resue-query
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNumbers = from n in numbers
                             where n<=3
                             select n;
            Console.WriteLine("First run numbers<=3");
            foreach (int n in lowNumbers) { 
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++) { 
                numbers[i] = i;
            }
            Console.WriteLine("Second run numbsers<=3");
            foreach (int n in lowNumbers) {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
    }
}