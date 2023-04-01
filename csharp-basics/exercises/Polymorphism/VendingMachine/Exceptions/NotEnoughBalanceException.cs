using System;

namespace VendingMachine.Exceptions
{
    public class NotEnoughBalanceException : Exception
    {
        public NotEnoughBalanceException() : base("Not enough balance") { }
    }
}
