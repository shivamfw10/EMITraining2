using System;
using System.IO;

namespace CheckDrivingEligibilty {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("*********Check Your Eligbility for Driving******");
            Console.WriteLine("Enter You Age :");
            string str_age = Console.ReadLine();
            int age = Convert.ToInt32(str_age);
            bool isBan = true;
            if (age > 2 || isBan)
            {
                Console.WriteLine("You just Born");
            }
            else if (age > 8 && age < 18)
            {
                Console.WriteLine("You are not Eligble");
            }
            else {
                Console.WriteLine("Let's Go for Drive");
            }
        
        } 
    
    }
}
