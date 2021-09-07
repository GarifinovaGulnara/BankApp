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
            }

            return (int)summ;
        }

        public static int Deposit(Account account, double summ)     //Пополнение
        {
            account.Balance += summ;

            return (int)summ;
        }

        public static void TakeCredit()
        {
            ;
        }

        public static void Profit(Account account)
        {
            Console.WriteLine("Введите кол-во месяцев");
            int manthCount = Convert.ToInt32(Console.ReadLine());
            static double interestRate;
            account.Balance += (account.Balance * interestRate / 12) * manthCount;

            Console.WriteLine(account.Balance);
        }
    }
}
