
using System;

namespace c_sharp_method {
    class Program {
        static void Main(string[] args)
        {
            Greet("Shivam");
            Hello hello = new Hello();
            Console.WriteLine(hello.name);
            Console.WriteLine(Average(10, 15, 25));
            Console.ReadLine();
        }
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning"+name);
        }

        private static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum/3;
        }
    }
}