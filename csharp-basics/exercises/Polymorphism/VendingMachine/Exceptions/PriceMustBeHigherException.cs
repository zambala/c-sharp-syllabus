using System;

namespace VendingMachine.Exceptions
{
    public class PriceMustBeHigherException : Exception
    {
        public PriceMustBeHigherException(Money price) : base($"Price must be more than {price}") { }
    }
}
