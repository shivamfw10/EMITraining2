using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Banking_Application
{
    public class Account
    {
        public string? customerName;
        public int? dob;
        public string? emailId;
        public string? location;
        public string? state;
        public string? country;
        public string? accountType;
        public string? accountNumber;
        public double? balence;
        public Account()
        {

        }
        public void setType(string type)
        {
            this.accountType = type;
        }
        public string getType(string type)
        {
            return this.accountType = type;
        }
        public virtual void Deposit(double amount)
        {
            Console.WriteLine("Deposite Method");
        }
        public void createAccount()
        {
            Console.WriteLine("Fill the Correct Deatils");
            Console.WriteLine("Enter Your Name :");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            dob=Convert.ToInt32(Console.ReadLine());
            if(dob>68)
            {
                Console.WriteLine("Your is grater than 68");
            }
            else 
            {
                Console.WriteLine("Enter Your Location :");
                location = Console.ReadLine();
                Console.WriteLine("Enter Your State :");
                state = Console.ReadLine();
                Console.WriteLine("Enter Your Country");
                country = Console.ReadLine();
                Console.WriteLine("Enter Your Email ID :");
                emailId = Console.ReadLine();

                if(accountType=="Saving")
                {
                    Random r = new Random();
                    var accnum = r.Next(1000000, 9999999);
                    accountNumber = "Sav"+accnum;
                    Console.WriteLine("Congratulations! Your Account Open Successfully" +
                        "\n Sir/Madam," +
                        "\n Your Saving Account Number is {0}", accountNumber);
                }
                else
                {
                    Random r = new Random();
                    var accnum = r.Next(1000000, 9999999);
                    accountNumber = "Curr" + accountNumber;
                    Console.WriteLine("Congratulations! Your Account Open Successfully" +
                        "\n Sir/Madam," +
                        "\n Your Current Account Number is {0}", accountNumber);

                }
            }


        }
        
        public void ShowBalence(string name)
        {
            if (customerName == name)
                Console.WriteLine("Your balence is {0}", balence);
            else
                Console.WriteLine("Name does not exists");
        }
        public void accountDetails(string accountNo)
        {
            if (accountNumber == accountNo)
                Console.WriteLine("Hi {0}", customerName);
            else
                Console.WriteLine("Please enter correct account no");
        }
    }
   

}
