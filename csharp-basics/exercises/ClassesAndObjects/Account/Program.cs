using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account firstAccount = new Account("Barto's account", 100.00);

            Console.WriteLine("Initial State");
            Console.WriteLine(firstAccount);

            firstAccount.Withdrawal(20.00);

            Console.WriteLine("Final State");
            Console.WriteLine(firstAccount);
            Console.WriteLine("************************");

            Account mattsAcount = new Account("Matt's account", 1000.00);
            Account myAccount = new Account("My account", 0);
            mattsAcount.Withdrawal(100.00);
            myAccount.Deposit(100.00);

            Console.WriteLine(mattsAcount);
            Console.WriteLine(myAccount);
            Console.WriteLine("************************");

            Account a = new Account("A", 100.00);
            Account b = new Account("B", 0);
            Account c = new Account("C", 0);

            Console.WriteLine("Initial State");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Transfer(a, b, 50.00);
            Transfer(b, c, 25.00);

            Console.WriteLine("Final State");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }

        public static void Transfer(Account fromAccount, Account toAccount, double howMuch)
        {
            fromAccount.Withdrawal(howMuch);
            toAccount.Deposit(howMuch);
        }
    }
}
