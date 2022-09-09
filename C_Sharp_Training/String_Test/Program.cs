using System;
using System.IO;

namespace String_Test 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string Hello = "I'm Shivam";
            Console.WriteLine(Hello.Length);
            Console.WriteLine(Hello.ToUpper());
            Console.WriteLine(Hello.ToLower());
            Console.WriteLine(string.Concat(Hello," ","from Kanpur"));
            */

            //String Interpolation with example

            /*
            Console.WriteLine("Welcome ! Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Quantity :");
            string quantity = Console.ReadLine();
            Console.WriteLine($"Hi! {name}. You got {quantity} candies.");//String Interpolation
            */

            //Escape Sequence Character
            Console.WriteLine("Welcome! \n May I Help You");//For New Line \n
            Console.WriteLine("Welcome! \t May I Help You");//For One Tab Space \n
            Console.WriteLine("Welcome! \" May I Help You");




        }
    }
}