using System;

namespace VendingMachine.Exceptions
{
    public class NoProductsAvailableException : Exception
    {
        public NoProductsAvailableException() : base("No products available") { }
    }
}
