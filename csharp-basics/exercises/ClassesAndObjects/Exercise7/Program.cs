using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?");
            var balance = Convert.ToDecimal(Console.ReadLine());

            if (balance < 0)
            {
                Console.WriteLine("Error try again");
                balance = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("Enter annual interest rate");
            var interest = Convert.ToDecimal(Console.ReadLine());

            if (interest < 0)
            {
                Console.WriteLine("Error try again");
                interest = Convert.ToDecimal(Console.ReadLine());
            }

            SavingsAccount acc1 = new SavingsAccount(balance, interest);

            Console.WriteLine("How long has the account been opened?");
            var monthsOpened = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= monthsOpened; i++)
            {
                Console.WriteLine($"Enter amount deposited for month {i}");
                decimal depoAmount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Enter amount withdrawn for month {i}");
                decimal WithrAmount = Convert.ToDecimal(Console.ReadLine());

                acc1.Deposit(depoAmount);
                acc1.Withdrawal(WithrAmount);
                acc1.Interest(interest);
            }

            Console.WriteLine();
            Console.WriteLine($"Total deposited: {Math.Round(acc1.TotalDeposit, 2)}");
            Console.WriteLine($"Total withdrawn: {Math.Round(acc1.TotalWithdrawal, 2)}");
            Console.WriteLine($"Interest earned: {Math.Round(acc1.TotalInterest, 2)}");
            Console.WriteLine($"Ending balance: {Math.Round(acc1.Balance, 2)}");
            Console.ReadKey();
        }
    }
}