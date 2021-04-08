using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAcount(1000);
            bankAccount.Deposit(200);
            
        }
    }
}
