using System;
using System.IO;
using System.Configuration;

namespace CSharp_Banking_Application
{
    class Bank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in EMI Bank");
            
            int selectOption = Convert.ToInt32(Console.ReadLine());
            
            if (selectOption == 1)
            {
                Console.WriteLine("1. Savings Account \n 2. Current Account");
                int accountType = Convert.ToInt32(Console.ReadLine());
                if(accountType == 1)
                {
                    Console.WriteLine("Enter Your Personal Details");
                    SavingAccount savingAccount = new SavingAccount();
                    savingAccount.setType("Saving");
                    savingAccount.createAccount();
                    if(savingAccount.dob<68)
                    {
                        Console.WriteLine("Enter Deposit Amount");
                        savingAccount.Deposit(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("Enter Withdraw Amount");
                        savingAccount.Withdraw(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("Enter Account No to get detail");
                        savingAccount.accountDetails(Console.ReadLine());
                    }
                    else
                        Console.WriteLine("You are not eligble");
                }
                else if(accountType == 2)
                {
                    Console.WriteLine("Enter Your Personal Details");
                    CurrentAccount currentAccount = new CurrentAccount();
                    currentAccount.setType("Current");
                    currentAccount.createAccount();
                    if (currentAccount.dob < 68)
                    {
                        Console.WriteLine("Enter Deposite Amount");
                        currentAccount.Deposit(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("Enter Withdraw Amount");
                        currentAccount.Withdraw(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("Enter Account No to get detail");
                        currentAccount.accountDetails(Console.ReadLine());
                    }
                    else
                        Console.WriteLine("You are not eligble");
                }
                else
                    Console.WriteLine("You have entered wrong Number");
            }

        }
    }
}