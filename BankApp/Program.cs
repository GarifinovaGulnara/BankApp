using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Account acc2 = new Account();
            acc.Balance = 1000;
            acc2.Balance = 2000;
            Operations.Transaction(acc, acc2, 500);
        }
    }
}
