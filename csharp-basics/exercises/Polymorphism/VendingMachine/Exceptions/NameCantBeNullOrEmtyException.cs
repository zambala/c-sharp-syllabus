using System;

namespace VendingMachine.Exceptions
{
    public class NameCantBeNullOrEmtyException : Exception
    {
        public NameCantBeNullOrEmtyException() : base("Product should have a name") {}
    }
}
