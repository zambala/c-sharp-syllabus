using System;

namespace VendingMachine.Exceptions
{
    public class ProductNotChangedException : Exception
    {
        public ProductNotChangedException() : base("No Changes Added") { }
    }
}
