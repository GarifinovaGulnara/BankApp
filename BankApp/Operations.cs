using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Operations
    {
        public static void ShowBalance(Account account)
        {
            Console.WriteLine(account.Balance);
        }

        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            if(accountSeller.Balance < -1000)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                accountSeller.Balance -= summ;
                accountGetter.Balance += summ;
                Console.WriteLine($"balance sell - {accountSeller.Balance}, balance gett - {accountGetter.Balance}");
            }
        }

        public static int Widtraw(Account account, double summ)     //Снятие наличных
        {
            if (account.Balance < summ)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                account.Balance -= summ;
                return summ;
            }
        }

        public static int Deposit()     //Пополнение
        {
            return 0;
        }

        public static void TakeCredit()
        {
            ;
        }
    }
}
