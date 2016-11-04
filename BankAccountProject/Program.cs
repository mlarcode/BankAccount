using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {   //Hard code client name, account balance, exit after transaction
            Console.WriteLine("Welcome Xavier Sharp");
            Console.WriteLine("Starting Balance is $1,750.25");

            // Deposit money
            account.balance = transaction.Deposit(account.balance, 500.00);
            account.GetBalance();

            // Withdraw money
            account.balance = transaction.Withdrawal(account.balance, 30.00);
            account.GetBalance();

          public void calcInterest();

        }
    }
}
