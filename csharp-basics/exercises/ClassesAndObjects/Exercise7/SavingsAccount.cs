namespace Exercise7
{
    internal class SavingsAccount
    {
        public decimal InterestRate;
        public decimal Balance;
        public decimal TotalDeposit;
        public decimal TotalWithdrawal;
        public decimal TotalInterest;

        public SavingsAccount(decimal startingBalance, decimal interest)
        {
            Balance = startingBalance;
            InterestRate = interest;
        }

        public void Withdrawal(decimal amount)
        {
            Balance -= amount;
            TotalWithdrawal += amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            TotalDeposit += amount;
        }

        public void Interest(decimal interest)
        {
            var monthlyInterest = InterestRate / 12 * Balance;

            TotalInterest += monthlyInterest;
            Balance = monthlyInterest + Balance;
        }
    }
}
