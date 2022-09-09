using System;

namespace LoopsInCSharp {

    class Program {
        static void Main(string[] args) {

            //Loop

            //While Loop
            int i = 0;
            while (i < 5) { 
                Console.WriteLine(i);
                i++;
            }

            //Do While
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);
        } 
    }

}