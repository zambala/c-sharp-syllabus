using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class SavingsAccount
    {
        public decimal _interestRate;
        public decimal _balance;
        public decimal _totalDeposit;
        public decimal _totalWithdrawal;
        public decimal _totalInterest;

        public SavingsAccount(decimal startingBalance, decimal interest)
        {
            _balance = startingBalance;
            _interestRate = interest;
        }

        public void Withdrawal(decimal amount)
        {
            _balance -= amount;
            _totalWithdrawal += amount;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            _totalDeposit += amount;
        }

        public void Interest(decimal interest)
        {
            var monthlyInterest = _interestRate / 12 * _balance;

            _totalInterest += monthlyInterest;
            _balance = monthlyInterest + _balance;
        }
    }
}
