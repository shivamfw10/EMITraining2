using System;

namespace LINQ_Anonymous {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("**********Example : 1 ***********");
            AnonymousEx1();
 
        }
        //Note : This limitation of anonymous types being immutable would not normally be a problem,
        //but should you ever need to change the values inside of an anonymous type you can pass data to a named class and then alter data.
        public static void AnonymousEx1() {
            var people = new[] {
                            new{ Name="Patty",Age=25,IsMale=false },
                            new{ Name="Kenny",Age=43,IsMale=false },
                            new { Name="Kate",Age=37,IsMale=false }
                            };
            var res = people.Where(x => x.Name.StartsWith("K")).Select(x => x);//Print Data whoose persons name start with K

            Console.WriteLine("Name Start with");
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }

            var res1 = people.Where(x => x.Name.EndsWith("y")).Select(x => x);//Print Data whoose persons name end with y
            Console.WriteLine("Name End with");
            foreach (var item in res1)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("Name Start with K and age greater than equal to 40");
            res = people.Where(p => p.Age >= 40).Select(p => p);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }
           
        }
    }
}
