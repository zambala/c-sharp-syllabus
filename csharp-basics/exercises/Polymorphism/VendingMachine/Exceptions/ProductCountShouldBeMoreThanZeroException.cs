using System;

namespace VendingMachine.Exceptions
{
    public class ProductCountShouldBeMoreThanZeroException : Exception
    {
        public ProductCountShouldBeMoreThanZeroException() : base("Atleast one product must be added") { }
    }
}
