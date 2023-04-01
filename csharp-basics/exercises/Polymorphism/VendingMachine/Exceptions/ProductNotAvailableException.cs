using System;

namespace VendingMachine.Exceptions
{
    public class ProductNotAvailableException : Exception
    {
        public ProductNotAvailableException() : base("Product not available") { }
    }
}
