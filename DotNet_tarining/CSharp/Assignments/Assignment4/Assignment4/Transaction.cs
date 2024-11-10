using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class InsuffientBalanceException : ApplicationException
    {
        public InsuffientBalanceException(string msg) : base(msg) { }
    }

    class Account
    {
        static double balance = 10000;

        public static void DepositMoney()
        {
            Console.WriteLine("Enter the Amount : ");

            double amount = Convert.ToDouble(Console.ReadLine());

            balance += amount;

            Console.WriteLine("The Amount Credited..."+balance);
        }

        public static void WithdrawMoney()
        {
            Console.WriteLine("Enter the Amount : ");

            double amount = Convert.ToDouble(Console.ReadLine());

            if(balance < amount)
            {
                throw (new InsuffientBalanceException("Insuffient Balance : "));
            }
            else
            {
                Console.WriteLine("Debited Amount : " + amount);
            }
        }

        public static void Balance()
        {
            Console.WriteLine("Balance : " + balance);
        }
    }
    class Transaction
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 for Deposit , 2 for Withdraw , 3 for CheckBalance");

            int temp = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    Account.DepositMoney();
                    break;

                case 2:
                    try
                    {
                        Account.WithdrawMoney();
                    }
                    catch (InsuffientBalanceException ibe)
                    {
                        Console.WriteLine(ibe.Message + " " + "Please try again...");
                    }
                    break;

                case 3:
                    Account.Balance();
                    break;

                default:
                    break;
            }
            Console.Read();
        }

        
    }
    
}
