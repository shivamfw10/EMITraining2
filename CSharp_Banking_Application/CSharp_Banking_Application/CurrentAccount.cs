using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Banking_Application
{
    public class CurrentAccount:Account
    {
        double balence;
        public void Deposit(double amount)
        {
           Console.WriteLine("Your current balence is {0}", balence);
           if(amount > 800)
            {
                balence += amount;
                Console.WriteLine("Amount Deposited Successfully. \n Your total balance is {0}", balence);
            }
           else
            {
                Console.WriteLine("Deposite amount must be greater than 800");
            }
        }
        public void Withdraw(double amount)
        {
            if (balence < amount)
            {
                Console.WriteLine("You can not withdraw due to insufficient balence");
            }
            else
            {
                balence -= amount;
                Console.WriteLine("Your reamining balence is {0}", balence);
            }
        }
        public double Balence { get { return balence; } }
    }
}
