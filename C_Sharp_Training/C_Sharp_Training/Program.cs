using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hello {
    //Check C# Version using below text
     //#error version
    //class Program {
        //static void Main(string[] args) {
            // Console.WriteLine("Hello, World!"); //Print Line by Line
            //Console.Write("Hello! Shivam"); // Print multiple statement in one line 
            // Console.Write("Hello! Shivam");
            // Single Line Comment
            /* Mulitple Line 
             Comment*/

            /* Data Types in C#
             Integer - int ; 4 bytes
             Long - long ; 8 bytes
             Floating point number - ; 4 bytes
             Double double; 8 bytes;
             Character - char a ='A'; 2 bytes
             Boolean - bool is Great = true; 1 bytes
             String - string inp = 'Shivam'; 2 bytes per character
             */
            //int shivam = 34;
            //Console.WriteLine(shivam);

            ////Data Type Examples
            //int a = 34;
            //float b = 34.4F;
            //double c = 34.4D;
            //char d = 'a';
            //string e = "this is a string";
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);

            //Type Casting
            /*There are two types of type cating
             1. Implicit Casting 
            //char to int to long to float
             2. Explicit Casting
             manual casting
             */
            //Implicit Type Casting
            //int g = 3;
            //double h = g;
            //Console.WriteLine(g);
            //Console.WriteLine(h);

            //Explicit Type Casting
            //int i = (int) 3.5;
            //double j = (double) 3.5;
            //Console.WriteLine(j);
            //Console.WriteLine(i);

            //float j1 = Convert.ToInt32(3.55); //Manual Type Casting
            // Console.WriteLine(j1);

            //string str = "Random String";
            //Console.Write(str);

            //Conversion
            //Convert.ToDecimal();
            //Convert.ToByte();
            //Convert.ToSingle();
            //Convert.ToInt();
            //Convert.ToBoolean();
            //Convert.ToChar();

            //Example -1
            //Console.WriteLine("Enter Your Name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey Hello"+" "+ name);
            //Console.WriteLine("How many candies do you want?");
            //string can = Console.ReadLine();
            //if (Convert.ToInt32(can) == 0)
            //{
            //    Console.WriteLine("Ohh No! You missed a surprise");
            //}
            //else {
            //    Console.WriteLine("You will get 4 more candies" + " " + (Convert.ToInt32(can) + 4));
            //}

            //Operators
            /*
            1. Arithmatic Operator
            2. Assignment Operators
            3. Logical Operators
            4. Comparison Operators
            */
            //Arithmatic Operator
            /*
            int a = 5;
            int b = 4;
            Console.WriteLine("The value of a+b is : "+(a + b));
            Console.WriteLine("The value of a-b is : "+(a - b));
            Console.WriteLine("The value of a*b is : "+(a * b));
            Console.WriteLine("The value of a/b is : "+(a / b));
            */

            //Assignment Operator
            /*
            int a = 4;
            int b = a;
            b += 4;
            b *= 4;
            b -= 4;
            Console.WriteLine(b);
            */

            //Logical Operatoar

            /*
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            Console.WriteLine(!false);
            */

            //Comparison Operator

            /*
            Console.WriteLine(324 > 555);
            Console.WriteLine(324 <= 555);
            Console.WriteLine(324 >= 555);
            Console.WriteLine(324 != 555);
            Console.WriteLine(324==555);
            */

          /*
            int a = Math.Max(25, 50);
            int b = Math.Min(25, 50);
            double c = Math.MaxMagnitude(3.55, 4.55);

            double d = Math.Sqrt(36);

            Console.WriteLine(c);

            Console.ReadLine();
          */
        //}
    //}
}
